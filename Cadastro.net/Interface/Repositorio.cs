using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.net.Interface
{
    public interface IRepositorio <t>
    {
        List<t> Lista();

        t RetornaPorId(int Id);

        void Insere(t entidade);

        void Exclui(int Id);

        void Atualiza(int Id, t entidade);

        int ProximoId();

    }
}
