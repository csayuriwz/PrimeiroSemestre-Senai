using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicioguiado
{
    public interface IContatoComercial
    {
        bool ValidarCnpj(string _cnpj);
    }
}