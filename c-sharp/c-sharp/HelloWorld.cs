using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GoSharedDLL
{
    class Program
    {
        [DllImport("..\\go-dll\\shared.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ReturnReversedString(byte[] input);

        static void Main(string[] args)
        {
            var input = Encoding.UTF8.GetBytes("Hello World!");
            var resultbytes = ReturnReversedString(input);
            var output = Marshal.PtrToStringAnsi(resultbytes);
            Console.WriteLine(output);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
