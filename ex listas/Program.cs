using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista
            List<string>
            list = new List<string>();
            //elementos na lista
            list.Add("Midoria");
            list.Add("Bakugo");
            list.Add("Kirishima");
            list.Add("Asui");
            list.Add("Uraraka");

            //elemento sugerido
            list.Insert(2, "Kaminari");

            //faz a leitura em loop dos elementos
            Console.WriteLine("Quantidade de elementos na Lista: " + list.Count);
            //encontra o primeiro elemento que começa com a letra A com uma função
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
            //encontra o ultimo elemento que começa com a letra  A com uma função
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa coma letra A: " + s2);

            //procura elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de 'A': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de 'A': " + pos2);

            //procura todos os elementos com tamanho igual
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);

                //retira elemento da lista

                list.Remove("Uraraka");
                Console.WriteLine("===================");

            }

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //retira determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //retira elementos de determinada posição da lista

            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //retira elementos da lista a partir da posição e quantos elementos 
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }

    }
}
