using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6_buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kiemtra= false;    
            string matKhau;
            do
            {
                Console.Write("Nhap mat khau: ");
                matKhau = Console.ReadLine();

                if (matKhau.Length < 6 || matKhau.Length > 12)
                {
                    Console.WriteLine("Mat khau phai co tu 6 den 12 khi tu!");
                    kiemtra=false;
                    continue;
                }
                if (!matKhau.Contains("@"))
                {
                    Console.WriteLine("Mat khau phai co ki tu @!");
                    kiemtra=false;
                    continue;
                }
                Console.WriteLine("Mat khau hop le!");
                break;  

            } while (kiemtra!=true);
            Console.ReadKey();  
        }
    }
}
