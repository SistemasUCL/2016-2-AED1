using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    public class MyString
    {
        private string minha_string;

        public MyString() {
            minha_string = string.Empty;
        }

        public MyString(string s) {
            minha_string = s;
        }

        public string GetString() {
            return minha_string;
        }

        public void SetString(string s) {
            minha_string = s;
        }

        public bool Letra() {
            string letras = "abcdefghijklmnopqrstuvxwyz";
            letras += letras.ToUpper();

            for(int p=0; p<minha_string.Length; p++) {
                bool e_letra = false;
                for(int l=0; l<letras.Length; l++) {
                    if(minha_string[p] == letras[l]) {
                        e_letra = true;
                    }
                }
                if(e_letra == false) {
                    return false;
                }
            }
            return true;
        }

        public bool Letra2() {
            string letras = "abcdefghijklmnopqrstuvxwyz";
            letras += letras.ToUpper();

            for (int p = 0; p < minha_string.Length; p++) {
                if(letras.IndexOf(minha_string[p]) < 0) {
                    return false;
                }
            }
            return true;
        }



        public bool Digito() {
            for(int p=0; p<minha_string.Length; p++) {
                char c = minha_string[p];
                if (c != '0' && c != '1' && c != '2' && c != '3' &&
                    c != '4' && c != '5' && c != '6' && c != '7' &&
                    c != '8' && c != '9') {
                    return false;
                }
            }
            return true;
        }

    }
}
