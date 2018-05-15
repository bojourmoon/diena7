using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diena7
{
    class Program
    //reizrekina tabula 1uzdevums
    {
        /* static void Main(string[] args)
         {
             reiztabula();
             Console.ReadLine();
         }
             static void reiztabula()
         {
             Console.WriteLine("Ievadi kādu skaitli");
             string ievade = Console.ReadLine();
             int skaitlis = Convert.ToInt16(ievade);

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
             }
             Console.ReadLine();

         }
         */
         //2uzd
        static void Main(string[] args)
        {
             //atpakalsk();  //seit es izsaucu ciklus..
           // zvaigzne();
          // saskaita();
            int izvele = 1;//pieskiram vertibu 1 lai vins vispar iet ieksa while cikla
            while (izvele != 0)
            {
                Console.WriteLine("1-skaitit atpakal skailus");
                Console.WriteLine("2-aplukot varda banans pavairosanu");
                Console.WriteLine("3-faktorialis");
                Console.WriteLine("0-iziet");

                string input = Console.ReadLine();
                izvele = Convert.ToInt16(input);

                switch (izvele)
                  {
                    case 1:
                        atpakalsk();
                        break;
                    case 2:
                        zvaigzne();
                        break;
                    case 3:
                        saskaita();
                        break;
                    case 0:
                        izvele = 0;
                        break;
                    default:
                        Console.WriteLine("sada funkcija nepastav..megini citu skaitli");
                        break;


                }
            }




            Console.ReadLine();
        }
            static void atpakalsk()
           {



            for (int i = 20; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            }
        //3uzd
        static void zvaigzne()
        {

            string zvaigzne = "";
            for (int i = 1; i <20; i++)
            {
                zvaigzne = zvaigzne + "burkans";
                Console.WriteLine(zvaigzne);
            }
            Console.ReadLine();

        }
        //4 uzdevums
        static void saskaita()
        {
            Console.WriteLine("Ievadi kādu skaitli");
            string ievada = Console.ReadLine();
            int saskaita = Convert.ToInt16(ievada);//lidz 

            int pieskaita = 0;
           
            for (int i = 1; i < saskaita; i++)
            {
                pieskaita = pieskaita + i;
                Console.WriteLine( pieskaita);
            }
            Console.ReadLine();

        }

    }
}

