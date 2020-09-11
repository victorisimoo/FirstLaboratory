using System;
using ConsoleTest.Elements;
using ConsoleTest.Services;
using CustomGenerics.Structure;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;

            do
            {
                
                Console.WriteLine("Árbol multicamino");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Insertar" + "\n" + "2. Recorrer" + "\n" + "3. Salir");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        int insert;
                        Console.Clear();
                        Console.WriteLine("Ingrese el grado del árbol");
                        int orden = Convert.ToInt32(Console.ReadLine());
                        Storage.Instance.rangeTree = new RangeTree<Number>(orden);

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese el valor a insertar");
                            var number = new Number
                            {
                                value = Convert.ToInt32(Console.ReadLine())
                            };
                            Storage.Instance.rangeTree.InsertElement(number, Number.CompareByValue);
                            Console.WriteLine("¿Desea ingresar otro valor? 1 - Si / 2 - No");
                            insert = Convert.ToInt32(Console.ReadLine());
                            
                        } while (insert == 1);

                        Console.WriteLine("¿Desea volver al menú? 1 - Si / 2 - No");
                        if (Console.ReadLine() == "No") {
                            answer = false;
                        }

                        break;

                    case 2:
                        Console.Clear();
                        //PONER EL RECORRIDO
                        Console.WriteLine("¿Desea volver al menú? 1 - Si / 2 - No");
                        if (Console.ReadLine() == "No"){
                            answer = false;
                        }
                        break;

                    case 3:
                        Console.ReadLine();
                        break;
                    default:
                        break;

                }

            } while (true);
        }
    }
}
