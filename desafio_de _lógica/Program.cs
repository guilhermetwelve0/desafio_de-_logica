using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace desafio_de__lógica
{
    class Program
    {
  
        static void Main(string[] args)
        {
            int Par;
            int Impar;


            for (int i = 0; i < 1000000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("O seu numero é par: " + i );
                }else
                {
                    Console.WriteLine("O seu numero é impar: "+ i );
                }
            }


        }
    }
}
