using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria_Descanso_Eterno
{
    public class ClsLogin
    {


        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public string ref_Empleado { get; set; }

        public ClsLogin(int id, string usuario, string contraseña, string ref_Empleado)
        {
            Id = id;
            Usuario = usuario;
            Contraseña = contraseña;
            this.ref_Empleado = ref_Empleado;
        }

        public ClsLogin()
        {

        }


    }
}
