using System;
using System.IO;

namespace IDM_Manager
{
    class GetSize
    {
        public static string FromFile(string _file)
        {
            if (File.Exists(_file))
            {
                FileInfo f = new FileInfo(_file);
                double value = f.Length;
                string[] suffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
                for (int i = 0; i < suffixes.Length; i++)
                {
                    if (value <= (Math.Pow(1024, i + 1)))
                    {
                        return ThreeNonZeroDigits(value / Math.Pow(1024, i)) + " " + suffixes[i];
                    }
                }
                return ThreeNonZeroDigits(value / Math.Pow(1024, suffixes.Length - 1)) + " " + suffixes[suffixes.Length - 1];
            }
            else
            {
                return "-";
            }
        }

        private static string ThreeNonZeroDigits(double value)
        {
            if (value >= 100)
            {
                // No digits after the decimal.
                return value.ToString("0,0");
            }
            else if (value >= 10)
            {
                // One digit after the decimal.
                return value.ToString("0.0");
            }
            else
            {
                // Two digits after the decimal.
                return value.ToString("0.00");
            }
        }
    }
}
