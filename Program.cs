using System;
using System.Collections.Generic;

namespace Desafio_da_prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoa = new List<Pessoa>();
            pessoa.Add(p1);
            pessoa.Add(p2);
            pessoa.Add(p3);
            pessoa.Add(p4);


            int tamLista = 0, maior = 0;
            string maisVelha = "";

            tamLista = pessoa.Count;

         
            for (int i = 0; i < pessoa.Count; i++)
            {
                if (maior < pessoa[i].Idade)
                {
                    maior = pessoa[i].Idade;
                    maisVelha = pessoa[i].Nome;
                }

            }
            Console.WriteLine("A pessoa de maior idade é: " + maisVelha);
            Console.WriteLine("Antes da exclusão de pessoas menores de 18 anos, a lista tem: " + tamLista + " itens");

            for (int i = 0; i < pessoa.Count; i++)
            {
                if (pessoa[i].Idade < 18)
                {
                    pessoa.RemoveAt(i);
                }
            }
            Console.WriteLine("Depois da exclusão de pessoas menores de 18 anos, a lista tem: " + pessoa.Count + " itens");
            
            for (int i = 0; i < pessoa.Count; i++)
            {
                if (pessoa[i].Nome == "Jessica")
                {
                    Console.WriteLine("A " + pessoa[i].Nome + " Existe na lista");
                }
                
            }





            
            

        }
    }
}
