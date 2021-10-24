using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Pamoka_Task_1_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite asmens amziu");
            int asmens_amzius = int.Parse(Console.ReadLine());

            AmziausNuskaitymas objektas = new AmziausNuskaitymas();

            var pateikimas = objektas.AmziausIvertinimas(asmens_amzius);

            switch(pateikimas)
            {
                case Galimybes.nieko:
                    Console.WriteLine("Asmuo yra nepilnametis, jis nei gerti, nei vairuoti negali");
                    break;
                case Galimybes.vairuoti:
                    Console.WriteLine("Asmuo gali vairuoti tik automobili, alkoholio vartoti negali");
                    break;
                case Galimybes.vairuotiGerti:
                    Console.WriteLine("Asmuo gali vartoti alkoholi, bei vairuoti transporto priemone");
                    break;
            }

            Console.ReadKey();
        }
    }
}
