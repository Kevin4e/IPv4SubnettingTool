using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    internal class Helpers
    {
        static Random gen = new Random();

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
            byte[] bytes = new byte[4];

            int startIndex = 1;

            byte firstByte;

            do
                firstByte = (byte)gen.Next(0, 256);
            while (firstByte == 127 || (firstByte >= 224));

            bytes[0] = firstByte;

            if (firstByte == 169)
            {
                byte secondByte;

                do
                    secondByte = (byte)gen.Next(0, 256);
                while (secondByte == 254);

                bytes[1] = secondByte;

                ++startIndex;
            }

            for (int i = startIndex; i < 4; ++i)
                bytes[i] = (byte)gen.Next(0, 256);

            return string.Join('.', bytes);
        }

        // Generates a random CIDR with a minimum value (numerically)
        public static byte GenerateRandomCIDR(byte minCIDR)
        {
            return (byte)gen.Next(minCIDR, 33);
        }

        // Returns octects (byte) from an IP address (string)
        // If the IP is not valid, it returns an empty collection
        public static byte[] ConvertIPToBytes(string ip)
        {
            string[] bytesStr = ip.Split('.');

            if (bytesStr.Length != 4)
                return Array.Empty<Byte>();

            byte[] bytes;

            try
            {
                bytes = Array.ConvertAll(bytesStr, byte.Parse);
            }
            catch (Exception)
            {
                return Array.Empty<Byte>();
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
        public static string RemoveLeadingZeros(string s)
        {
            return (byte.Parse(s)).ToString();
        }

        // Removes leading zero's from an IP address for each octect
        public static string NormalizeIP(string ip)
        {
            string[] bytes = ip.Split('.');

            for (int i = 0; i < 4; ++i)
                bytes[i] = RemoveLeadingZeros(bytes[i]);

            return string.Join(".", bytes);
        }

        // Returns the exponent y such that 2^y equals the given number
        public static byte GetExponent(ulong n)
        {
            return (byte)Math.Log2(n);
        }
    }
}