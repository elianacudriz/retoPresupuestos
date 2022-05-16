using System;
using System.IO;
using System.Text;
using Presupuesto.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Presupuesto.LogicaCarpeta
{
    public interface ILogica
    {
       void EscribirCsv(int id, DateTime fecha, string tipo, string categoria, double monto);
       string ActualizacionInformacionEntrada(DatoEntrada dato);

       List<string> leerCsv();

       List<string> GetByCategoria(string categoria);
    }
}