using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.BEG2BaiTapNhom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Buoi4Bai3Nhom kqB4BaiNhom = new Buoi4Bai3Nhom();
            kqB4BaiNhom.B4Bai3();


            Console.ReadKey();
        }
    }
}
