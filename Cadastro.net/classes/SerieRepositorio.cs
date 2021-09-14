using Cadastro.net.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.net
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> ListaSerie = new List<Series>();

        public void Atualiza(int Id, Series objeto)
        {
            ListaSerie[Id] = objeto;
        }

        public void Exclui(int Id)
        {
            ListaSerie[Id].Excluir();
        }

        public void Insere(Series objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Series RetornaPorId(int Id)
        {
            return ListaSerie[Id];
        }
    }
}
