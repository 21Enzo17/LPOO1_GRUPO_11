using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Disciplina
    {
        public string Dis_ID { get; set; }
        public string Dis_Nombre { get; set; }
        public string Dis_Descripcion { get; set; }


        public Disciplina() { }

        public Disciplina(string dis_ID, string dis_Nombre, string dis_Descripcion)
        {
            Dis_ID = dis_ID;
            Dis_Nombre = dis_Nombre;
            Dis_Descripcion = dis_Descripcion;
        }
    }
}
