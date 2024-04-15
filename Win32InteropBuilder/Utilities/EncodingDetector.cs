using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Win32InteropBuilder.Utilities
{
    public static class EncodingDetector
    {
        public static Encoding UTF8NoBom { get; } = new UTF8Encoding(false);

        public static Encoding DetectEncoding(string filePath, EncodingDetectorMode mode, int autoDetectTestBytesLength = 1024)
        {
            ArgumentNullException.ThrowIfNull(filePath);
            ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(autoDetectTestBytesLength, 64);
            Encoding defaultEncoding;
            switch (mode)
            {
                case EncodingDetectorMode.UseUTF8AsDefault:
                    defaultEncoding = Encoding.UTF8;
                    break;

                case EncodingDetectorMode.UseAnsiAsDefault:
                    defaultEncoding = Encoding.Default;
                    break;

                default:
                    return DetectEncoding(filePath, autoDetectTestBytesLength);
            }

            using var reader = new StreamReader(filePath, defaultEncoding, true);
            reader.Peek();
            return reader.CurrentEncoding;
        }

        public static string ReadAllText(string filePath, EncodingDetectorMode mode, out Encoding detectedEncoding)
        {
            ArgumentNullException.ThrowIfNull(filePath);
            Encoding defaultEncoding;
            switch (mode)
            {
                case EncodingDetectorMode.UseUTF8AsDefault:
                    defaultEncoding = Encoding.UTF8;
                    break;

                case EncodingDetectorMode.UseAnsiAsDefault:
                    defaultEncoding = Encoding.Default;
                    break;

                default:
                    return ReadAllText(filePath, out detectedEncoding);
            }

            using var reader = new StreamReader(filePath, defaultEncoding, true);
            reader.Peek();
            detectedEncoding = reader.CurrentEncoding;
            return File.ReadAllText(filePath, detectedEncoding);
        }

        // https://devblogs.microsoft.com/oldnewthing/20190701-00/?p=102636
        [DllImport("kernel32")]
        private static extern int MultiByteToWideChar(int CodePage, int dwFlags, byte[] lpMultiByteStr, int cbMultiByte, [Out] ushort[] lpWideCharStr, int cchWideChar);

        private static readonly char[] _to1252Table = Init1252Table();
        private static char[] Init1252Table()
        {
            var as8bit = new byte[32];
            for (var i = 0; i < as8bit.Length; i++)
            {
                as8bit[i] = (byte)(i + 0x80);
            }

            var table = new ushort[32];
            _ = MultiByteToWideChar(1252, 0, as8bit, as8bit.Length, table, table.Length);
            return table.Select(us => (char)us).ToArray();
        }

        private static byte To1252(char ch)
        {
            if (ch < 0x100)
                return (byte)ch;

            for (var i = 0; i < _to1252Table.Length; i++)
            {
                if (_to1252Table[i] == ch)
                    return (byte)(i + 0x80);
            }
            return 0;
        }

        private static string ReadAllText(string filePath, out Encoding detectedEncoding)
        {
            using (var reader = new StreamReader(filePath, UTF8NoBom, true))
            {
                reader.Peek();
                if (reader.CurrentEncoding != UTF8NoBom) // is there a BOM?
                {
                    detectedEncoding = reader.CurrentEncoding;
                    return File.ReadAllText(filePath, detectedEncoding);
                }
            }

            var bytes = File.ReadAllBytes(filePath);
            var p = Encoding.UTF8.GetString(bytes);
            for (var i = 0; i < p.Length; i++)
            {
                if (IsSuspicious(p, i))
                {
                    detectedEncoding = Encoding.Default;
                    return detectedEncoding.GetString(bytes);
                }
            }

            detectedEncoding = UTF8NoBom;
            return p;
        }

        private static bool IsSuspicious(string str, int i)
        {
            char c = str[i];
            if (c == 0xFFFD)
                return true;

            var ch = To1252(c);
            if (ch > 0x7F)
            {
                if (((c & 0xE0) == 0xC0) && ((i + 1) < str.Length) && ((To1252(str[i + 1]) & 0xC0) == 0x80))
                    return true;

                if (((c & 0xF0) == 0xE0) && ((i + 2) < str.Length) && ((To1252(str[i + 1]) & 0xC0) == 0x80) && ((To1252(str[i + 2]) & 0xC0) == 0x80))
                    return true;

                if (((c & 0xF8) == 0xF0) && ((i + 3) < str.Length) && ((To1252(str[i + 1]) & 0xC0) == 0x80) && ((To1252(str[i + 2]) & 0xC0) == 0x80) && ((To1252(str[i + 3]) & 0xC0) == 0x80))
                    return true;
            }
            return false;
        }

        private static Encoding DetectEncoding(string filePath, int autoDetectTestBytesLength)
        {
            using (var reader = new StreamReader(filePath, UTF8NoBom, true))
            {
                reader.Peek();
                if (reader.CurrentEncoding != UTF8NoBom) // is there a BOM?
                    return reader.CurrentEncoding;
            }

            byte[] bytes;
            int read;
            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (autoDetectTestBytesLength > file.Length)
                {
                    autoDetectTestBytesLength = (int)file.Length;
                }

                if ((autoDetectTestBytesLength % 2) == 1)
                {
                    autoDetectTestBytesLength--;
                }

                bytes = new byte[autoDetectTestBytesLength];
                read = file.Read(bytes, 0, bytes.Length);
            }

            var p = Encoding.UTF8.GetString(bytes, 0, read);
            for (var i = 0; i < p.Length; i++)
            {
                if (IsSuspicious(p, i))
                    return Encoding.Default;
            }

            return UTF8NoBom;
        }
    }
}
