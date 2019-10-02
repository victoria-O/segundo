using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL_AHORCADO
{
    class Program
    {
        public void menu()
        {
            Console.WriteLine("\tMENU ");
            Console.WriteLine("1.-Compartida");
            Console.WriteLine("2.-Compartida por palabra");
            Console.WriteLine("3.-SALIR");
        }
        static void Main(string[] args)
        {
            String[] palabra = new String[100];
            int i = 0, TamañoLetra = 0, op, J1=0, J2=0, intento = 0; ;
            String palabra2 = "", palabra3 = "", le = "", lp = "";
            Program p = new Program();
         
            Console.WriteLine("escriba una palabra");
            palabra[50] = Console.ReadLine();
            Console.Clear();
            palabra2 = palabra[50];
            TamañoLetra = palabra2.Length;
            Console.WriteLine(" tiene " + TamañoLetra + " letras");
            //este ciclo for es para poner los espacios
            for (i = 1; i <= TamañoLetra; i++)
            {
                if (palabra2.Substring(i, 0) != " ")
                    palabra3 = palabra3 + "_";
                else
                    palabra3 = palabra3 + " ";
            }
            Console.WriteLine(palabra3);

            do
            {
                p.menu();
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                       
                        do
                        {
                            //adivina la palabra presionando teclas
                            Boolean exito = false;
                            Console.Write("Presione una letra ");
                            lp = Console.ReadLine();
                            for (i = 0; i <= TamañoLetra - 1; i++)
                            {
                                le = palabra2.Substring(i, 1);
                                if (le.Equals(lp))
                                {
                                    palabra3 = palabra3.Remove(i, 1);
                                    palabra3 = palabra3.Insert(i, lp);
                                    exito = true;
                                }
                               

                            }
                            if (exito) //las variables booleanas solo van solar
                            {
                                Console.WriteLine("Palabra oculta = " + palabra3);
                            }
                            else
                            {
                                intento++;
                                Console.WriteLine("Letra no existe lleva " + intento + " intentos perdidos");
                                Console.WriteLine(" turno del otro jugador");
                                if(intento==1)
                                {
                                    J1++;
                                }
                              
                            }

                            if (intento == 7)
                            {
                                Console.WriteLine("Intentos agotados, !!!!! PERDISTE !!!! ");
                                Console.WriteLine("La palabra correcta era " + palabra2);
                            }
                            if (palabra2 == palabra3)
                            {
                                Console.WriteLine("Felicidades, !!!! GANASTE !!!!!!!!! ");
                                break;
                            }
                        }
                        while (intento < 7);


                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Error opcion");
                        break;
                }
            } while (op != 3);
            
            Console.ReadKey();

        }
    }
}
