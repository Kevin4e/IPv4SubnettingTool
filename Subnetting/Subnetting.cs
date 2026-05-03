using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnetting
{
    public class IPv4
    {
        public byte[] Bytes { get; }
        public IPv4() : this(new byte[4]) {}
        public IPv4(byte[] bytes) => Bytes = (byte[])bytes.Clone();
        public string Address => string.Join('.', Bytes);

        // AND operator
        public static IPv4 operator &(IPv4 a, IPv4 b)
        {
            IPv4 result = new IPv4();

            for (int i = 0; i < 4; i++)
                result.Bytes[i] = (byte)(a.Bytes[i] & b.Bytes[i]);

            return result;
        }

        // OR operator
        public static IPv4 operator |(IPv4 a, IPv4 b)
        {
            IPv4 result = new IPv4();

            for (int i = 0; i < 4; i++)
                result.Bytes[i] = (byte)(a.Bytes[i] | b.Bytes[i]);

            return result;
        }

        // NOT operator: flips all the bits
        public static IPv4 operator ~(IPv4 a)
        {
            IPv4 result = new IPv4();

            for (int i = 0; i < 4; i++)
                result.Bytes[i] = (byte)~a.Bytes[i];

            return result;
        }
    }
    public class IPv4Network
    {
        public enum IPClass
        {
            A,
            B,
            C
        };

        private Dictionary<IPClass, byte> Classes = new Dictionary<IPClass, byte>
        {
            { IPClass.A,  8 },
            { IPClass.B, 16 },
            { IPClass.C, 24 }
        };

        public IPv4 IPAddress { get; set; } = new IPv4();
        public byte CIDR { get; set; } = 0;


        /* To compute */

        public IPClass ipClass { get; set; } = 0;
        public IPv4 SubnetMask { get; set; } = new IPv4();
        public IPv4 NetworkIP { get; set; } = new IPv4();
        public IPv4 SubnetIP { get; set; } = new IPv4();
        public IPv4 SubnetBroadcastIP { get; set; } = new IPv4();
        public ulong NumberOfHosts { get; set; } = 0;
        public ulong NumberOfSubnets { get; set; } = 0;

        private void ResolveType()
        {
            byte firstByte = IPAddress.Bytes[0];

            if (firstByte < 128)
                ipClass = IPClass.A;

            else if (firstByte < 192)
                ipClass = IPClass.B;

            else
                ipClass = IPClass.C;
        }
        private void ComputeSubnetMaskDecimalDotted()
        {
            int quotient = CIDR / 8;

            int i;

            for (i = 0; i < quotient; ++i)
                SubnetMask.Bytes[i] = 255;

            int carryOver = CIDR % 8;

            if (carryOver == 0)
                return;

            byte val = 0;
            byte mul = 128;

            for (int j = 0; j < carryOver; ++j)
            {
                val += mul;
                mul /= 2;
            }

            SubnetMask.Bytes[i] = val;
        }
        private void ComputeNetworkIP() => NetworkIP = IPAddress & SubnetMask;
        private void ComputeSubnetIP() => SubnetIP = IPAddress & SubnetMask;
        private void ComputeSubnetBroadcastIP() => SubnetBroadcastIP = NetworkIP | ~SubnetMask;

        private void CalcNumberOfHosts()
        {
            if (CIDR == 31) NumberOfHosts = 2;
            else if (CIDR == 32) NumberOfHosts = 1;
            else NumberOfHosts = (ulong)Math.Pow(2.0, 32 - CIDR) - 2; // Explicit casting required
        }
        private void CalcNumberOfSubnets()
        {
            if (Classes.TryGetValue(ipClass, out byte value))
                NumberOfSubnets = (ulong)Math.Pow(2.0, CIDR - value); // Explicit casting required
        }
        private void Resolve()
        {
            /* Resolving Type */

            ResolveType();

            if (!Enum.IsDefined(typeof(IPClass), ipClass)) // If neither A, nor B, nor C
                return;


            /* Calculating Subnet Mask given the CIDR */

            ComputeSubnetMaskDecimalDotted();


            /* Calcuating network IP */

            ComputeNetworkIP();


            /* Calculating subnet IP */

            ComputeSubnetIP();


            /* Calculating subent's broadcast IP */

            ComputeSubnetBroadcastIP();


            /* Number of hosts */

            CalcNumberOfHosts();


            /* Number of subnets */

            CalcNumberOfSubnets();
        }
        public string[] GetInfo(bool displayPowerOfTwo)
        {
            return new[]
            {
                IPAddress.Address,
                CIDR.ToString(),
                ipClass.ToString(),
                SubnetMask.Address,
                NetworkIP.Address,
                SubnetIP.Address,
                SubnetBroadcastIP.Address,
                displayPowerOfTwo ? Helpers.FormatNumberOfSubnets(NumberOfSubnets) : NumberOfSubnets.ToString(), // Get power of two if displayPowerOfTwo is true
                displayPowerOfTwo ? Helpers.FormatNumberOfHosts(NumberOfHosts, CIDR) : NumberOfHosts.ToString() // Same here
            };
        }
        public IPv4Network(IPv4 IPAddr, byte CIDR_)
        {
            IPAddress = IPAddr;
            CIDR = CIDR_;

            Resolve();
        }
    }
}