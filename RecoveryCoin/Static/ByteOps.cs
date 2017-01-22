using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace RecoveryCoin
{
    public static class ByteOps
    {
        public static byte[] ModuloAddBytes(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return null;
            byte[] res = new byte[a.Length];
            for (int x = 0; x < a.Length; x++) res[x] = (byte)((a[x] + b[x]) % 256);
            return res;
        }
        public static byte[] ModuloSubtractBytes(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return null;
            byte[] res = new byte[a.Length];
            for (int x = 0; x < a.Length; x++) res[x] = (byte)((a[x] - b[x]) % 256);
            return res;
        }

        public static string ByteToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        public static string ByteToAddress(byte[] addr)
        {
            string res = "";
            for (int x = 0; x < addr.Length; x++) {
                res += addr[x].ToString().PadLeft(2, '0');
            }
            return res;
        }
        public static byte[] AddressToBytes(string addr)
        {
            byte[] res = new byte[ECDSA.ADDRESS_LENGTH];
            for (int x = 0; x < addr.Length; x+=2)
            {
                res[x / 2] = Convert.ToByte(addr.Substring(x, 2));
            }
            return res;
        }

        public static byte[] HexToByte(string HexString)
        {
            if (HexString == "" || HexString.Length % 2 != 0 || Regex.IsMatch(HexString, "[^0-9A-Fa-f]")) return null;

            byte[] retArray = new byte[HexString.Length / 2];
            for (int i = 0; i < retArray.Length; ++i)
            {
                retArray[i] = byte.Parse(HexString.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return retArray;
        }
    }
}
