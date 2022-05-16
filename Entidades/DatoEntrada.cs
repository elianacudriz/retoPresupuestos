using System;

namespace Presupuesto.Entidades
{
    public class DatoEntrada
    {
        public int Id { get; set; }  
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public double Monto { get; set; }
    }
}
