using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    class Program
    {
        static void Main(string[] args) {
            MyString palavra = new MyString("12341234");

            if(palavra.Digito()) {
                Console.WriteLine("{0} - Apenas dígitos!", palavra.GetString());
            }
            else {
                Console.WriteLine("{0} - Não apenas dígitos!", palavra.GetString());
            }


            Console.ReadKey();
        }
    }
}
