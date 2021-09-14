using Cadastro.net.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.net
{
    public class Series : EntidadeBase
    {
        public Genero genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private string Criador { get; set; }

        private bool Excluido { get; set; }
        


        //metodos usando construtor

        public Series(int Id, Genero genero, string titulo, string descricao, int ano, string criador)
        {
            this.Id = Id;
            this.genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Criador = criador;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + this.genero + Environment.NewLine;
            retorno += "Título" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Criador do filme" + this.Criador + Environment.NewLine;
            retorno += "Ano de inicio" + this.Ano;
            retorno += "Excluido: " + this.Excluido;

            return retorno;
        }



        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}
