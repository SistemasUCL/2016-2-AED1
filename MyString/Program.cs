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
            MyString palavra = new MyString("qwpoer5uq");

            if(palavra.Digito()) {
                Console.WriteLine("{0} - Apenas dígitos!", palavra.GetString());
            }
            else {
                Console.WriteLine("{0} - Não apenas dígitos!", palavra.GetString());
            }

            if (palavra.Letra2()) {
                Console.WriteLine("{0} - Apenas letras!", palavra.GetString());
            }
            else {
                Console.WriteLine("{0} - Não apenas letras!", palavra.GetString());
            }
            Console.ReadKey();
        }
    }
}
