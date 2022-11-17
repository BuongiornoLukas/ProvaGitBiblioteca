using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGitBiblioteca
{
    internal class Libro
    {

        string autore;
        string titolo;
        string annoPubblicazione;
        string editore;
        int numeroPagine;

        public string toString()
        {
            string tuttiDati = autore + titolo + annoPubblicazione + editore + numeroPagine.ToString();

            return tuttiDati;
        }

        public string readingTime()
        {
            string tempoLettura;

            if (numeroPagine<100)
            {
                tempoLettura = "1h";
            }
            else
            {
                if(numeroPagine>200)
                {
                    tempoLettura = ">2h";
                }
                else
                {
                    tempoLettura = "2h";
                }

            }

            return tempoLettura;
        }


    }
}
