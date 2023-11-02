using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo();
            //Name();
            //Number();
            //Console.WriteLine(SumTwoNumber(10, 20));

            //Gọi lại nhiều lần:
            //Demo();
            //Demo();
            //Demo();

            Console.ReadKey();
        }
        static void Demo()
        {
            Console.WriteLine("Test");
        }


        //VD1:
        static void Name()
        {
            Console.WriteLine("HQK");
        }

        //VD2:
        static void Number()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        //VD3:
        static int SumTwoNumber(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }
}

//Function: Hàm hay thủ tục là một kiểu dữ liệu cho phép chúng ta thực thi một hay nhiều câu lệnh một cách riêng biệt bằng cách gọi đến và truyền tham số.
/*
 * Cú pháp:
 * [Từ khóa 1] [Từ khóa 2] [Từ khóa n]  <Kiểu dữ liệu trả về> <Tên hàm>([Parameter]){ }
 * [Từ khóa 1], [Từ khóa 2], [Từ khóa n] là các từ khóa như: public, static, readonly … và có thể không điền.
 * Kiểu dữ liệu trả về như: từ khóa void, hay mọi kiểu dữ liệu như int, long, bool, SinhVien…
 * Tên hàm: tên gọi
 * Có thể gọi lại nhiều lần
 * Parameter: tham số truyền vào để sử dụng trong nội bộ hàm
 */