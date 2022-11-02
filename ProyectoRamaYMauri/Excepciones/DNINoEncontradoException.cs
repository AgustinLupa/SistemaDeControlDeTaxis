using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRamaYMauri.Excepciones
{
    internal class DNINoEncontradoException : Exception
    {
        public DNINoEncontradoException(string message) : base(message)
        {

        }
    }
}
