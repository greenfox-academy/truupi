﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var UnorderedList = InitializeDominoes();
            var OrderedList = new List<Domino>();

            OrderedList.Add(UnorderedList[0]);

            int k = 0;

            for (int i = 0; i < UnorderedList.Count; i++)
            {
                if (OrderedList[k].GetValues()[1] == UnorderedList[i].GetValues()[0])
                {
                    OrderedList.Add(UnorderedList[i]);
                    k++;
                    i = 0;
                }
                if (k == 5)
                {
                    break;
                }
            }

            foreach (var item in OrderedList)
            {
                foreach (var item2 in item.GetValues())
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes() // function that creates domino list
        {
            var dominoes = new List<Domino>();

            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}
