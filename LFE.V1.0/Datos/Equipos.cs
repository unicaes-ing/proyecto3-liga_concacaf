using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LFE.V1._0.Datos
{
    public class Equipos
    {
        public bool LeerDatos(string Nombre)
        {
            string dato;
            bool permitir = false;
            StreamReader Leer = new StreamReader(@"BinFiles\Equipos.txt", false);
            do
            {
                dato = Console.ReadLine();
                if (Nombre.Equals(dato)){
                    permitir = false;
                    break;
                }
                else
                {
                    permitir = true;
                }
                
            } while (dato != null);

            Leer.Close();
            return permitir;
        }
    public void EscribirDato(string Nombre)
    {
        StreamWriter Escribir = new StreamWriter(@"BinFiles\Equipos.txt", true);

        Escribir.WriteLine(Nombre);



        Escribir.Close();
    }
}
}
