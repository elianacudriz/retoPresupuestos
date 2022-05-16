using System;
using System.IO;
using System.Text;
using Presupuesto.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Presupuesto.LogicaCarpeta
{
    public class Logica: ILogica
    {
        public List<string> leerCsv()
       {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\Eliana Cudriz\Documents\PracticaDesarrollo\Presupuesto\presupuesto.csv"));
            List<string> listA = new List<string>();
             while (!reader.EndOfStream)
            {
            var line = reader.ReadLine();
            //var values = line.Split(';');

            listA.Add(line);
            }
            return listA;
       }

       public List<string> GetByCategoria(string parametro)
       {
           var listaLeida = leerCsv();
           var find = listaLeida.Where(x => x.Contains(parametro));
           return find.ToList();
         
       }

       
       public void EscribirCsv( int id, DateTime fecha, string tipo, string categoria, double monto)
       {
                
            string ruta = @"C:\Users\Eliana Cudriz\Documents\PracticaDesarrollo\Presupuesto\presupuesto.csv";
            string separador = ",";

            StringBuilder salida = new StringBuilder();
                         // Agregue los datos que se guardarán en la secuencia de cadena
           string cadena = id + "," +  fecha + "," +  tipo + "," +  categoria + "," +  monto + "," ;
           List<string> lista = new List<string>();
           lista.Add(cadena);

           for(int i=0;i<lista.Count;i++)
           {
               salida.AppendLine(string.Join(separador, lista[i]));
               File.AppendAllText(ruta, salida.ToString());
           }
           System.Console.WriteLine(salida);


       }

       public string ActualizacionInformacionEntrada(DatoEntrada dato)
       {
           EscribirCsv(dato.Id, dato.Fecha, dato.Tipo, dato.Categoria, dato.Monto);
           string respuesta = "Se guardado la informacion ingresada";
           return respuesta;
       } 

      
    }
}