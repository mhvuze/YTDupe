using System;
using System.IO;

namespace YTDupe
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) { Console.WriteLine("No input provided, aborting."); return; }
            string input = args[0];

            if (!File.Exists(input)) { Console.WriteLine("Input doesn't exist, aborting."); return; }

            FileInfo info = new FileInfo(input);
            int size = Convert.ToInt32(info.Length);

            byte[] input_array = File.ReadAllBytes(input);
            byte[] output_array = new byte[size + 1];

            Buffer.BlockCopy(input_array, 0, output_array, 0, size);

            File.WriteAllBytes(input, output_array);
        }
    }
}
