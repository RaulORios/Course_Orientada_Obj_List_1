using System;
using System.Collections.Generic;

namespace Course_Orientada_Obj_List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //Contagem da List
            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine();

            // Find através de uma Função (Encontra o primeiro elemento conforme parâmetro)
            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);

            // Find através de uma expressão Lambda (Encontra o primeiro elemento conforme parâmetro)
            s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            // FindLast através de uma expressão Lambda (Encontra o último elemento conforme parâmetro)
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // FindIndex - informa a posição na lista conforme Parâmetro
            Console.WriteLine();
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Posicion 'A' " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Posicion 'A' " + pos2);

            //FindAll - Filtrar informações na lista
            Console.WriteLine();
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos = Remove/RemoveAll/RemoveAt/RemoveRanger

            Console.WriteLine();
            list.Remove("Alex");
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //list.RemoveAt(2) >>> indicar o número da posição da lista

            //listRemoveRange(2, 2) a partir da posição escolhhida, e quantos elementos serão excluídos


            Console.ReadKey();
        }

        //Função
        static bool Test(string s)
        {
            return s[0] == 'A';
        }

    }
}
