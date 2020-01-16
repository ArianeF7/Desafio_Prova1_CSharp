using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_da_prova1
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string _nome, int _idade)
        {
            this.Nome = _nome;
            this.Idade = _idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }




    }
}
