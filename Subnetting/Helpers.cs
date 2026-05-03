using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    internal static class Helpers
    {
        /* 
         *  Generates a random IP address in string format
         *  
         *  Conditions:
         *  1) First byte != 127 (Loopback)
         *  2) First byte < 224 (Multicast)
         *  3) First byte != 169 AND Second byte != 254 (Link-local)
         */
        public static string GenerateRandomIP()
        {
            byte firstByte;

            do
            {
                firstByte = GenerateRandomByte();
            }
            while (firstByte == 127 || (firstByte >= 224));

            byte[] bytes = new byte[4];

            bytes[0] = firstByte;

            int startIndex = 1;

            if (firstByte == 169)
            {
                byte secondByte;

                do
                {
                    secondByte = GenerateRandomByte();
                }
                while (secondByte == 254);

                bytes[1] = secondByte;

                ++startIndex;
            }

            for (int i = startIndex; i < 4; ++i)
            {
                bytes[i] = GenerateRandomByte();
            }

            return string.Join('.', bytes);
        }

        // Generates a random CIDR with a minimum value (numerically)
        public static byte GenerateRandomCIDR(byte minCIDR) => GenerateRandomByte(minCIDR, 33);

        // Returns octects (byte) from an IP address (string)
        // If the IP is not valid, it returns an empty collection
        public static byte[] ConvertIPToBytes(string ip)
        {
            string[] bytesStr = ip.Split('.');

            if (bytesStr.Length != 4)
                return Array.Empty<byte>();

            byte[] bytes;

            try
            {
                bytes = Array.ConvertAll(bytesStr, byte.Parse);
            }
            catch (Exception)
            {
                return Array.Empty<byte>();
            }

            return bytes;
        }

        // Returns the default (classful) CIDR of an IP address
        public static byte GetClassfulCIDR(IPv4 ipAddr)
        {
            byte firstByte = ipAddr.Bytes[0];

            if      (firstByte >= 192) return 24;
            else if (firstByte >= 128) return 16;
            else                       return 8;
        }

        // Removes leading zero's from a string and returns the modified copy
        public static string RemoveLeadingZeros(string s) => byte.Parse(s).ToString();

        // Removes leading zero's from an IP address for each octect
        public static string NormalizeIP(string ip)
        {
            string[] bytes = ip.Split('.');

            for (int i = 0; i < 4; ++i)
            {
                bytes[i] = RemoveLeadingZeros(bytes[i]);
            }

            return string.Join(".", bytes);
        }

        // Returns the exponent y such that 2^y equals the given number
        public static byte GetExponent(ulong n) => (byte)Math.Log2(n);

        // Generates a random byte
        public static byte GenerateRandomByte(byte min = byte.MinValue, int max = byte.MaxValue + 1)
            => (byte)Random.Shared.Next(min, max);

        public static string FormatNumberOfHosts(ulong numberOfHosts, byte CIDR)
        {
            string format;

            if (CIDR == 31 || CIDR == 32)
                format = $"2^{GetExponent(numberOfHosts)}";
            else
                format = $"(2^{GetExponent(numberOfHosts + 2)}) - 2";

            return format;
        }

        public static string FormatNumberOfSubnets(ulong numberOfSubnets) => $"2^{GetExponent(numberOfSubnets)}";
    }
}