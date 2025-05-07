using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funeraria_Descanso_Eterno
{
    public class ClsEmpleado
    {
        public int ID_Empleado { get; set; }
        public string REF_Rol { get; set; }
        public string Tdoc_E { get; set; }
        public string Nombre_E { get; set; }
        public string ApellidoP_E { get; set; }
        public string ApellidoM_E { get; set; }
        public string Cedula_E { get; set; }
        public string Sexo_E { get; set; }
        public string F_Nacimiento_E { get; set; }
        public string Depto_E { get; set; }
        public string Ciudad_E { get; set; }
        public string Direccion_E { get; set; }
        public string Mail_E { get; set; }
        public string Celular_E { get; set; }

        public ClsEmpleado() { }

        public ClsEmpleado(int id, string rol, string Tdoc, string nombre, string apellidoP, string apellidoM, string Cedula,
                           string sexo, string nacimiento, string depto, string ciudad,
                           string direccion, string mail, string celular)
        {
            ID_Empleado = id;
            REF_Rol = rol;
            Nombre_E = nombre;
            ApellidoP_E = apellidoP;
            ApellidoM_E = apellidoM;
            Cedula_E = Cedula;
            Sexo_E = sexo;
            F_Nacimiento_E = nacimiento;
            Depto_E = depto;
            Ciudad_E = ciudad;
            Direccion_E = direccion;
            Mail_E = mail;
            Celular_E = celular;
            Tdoc_E = Tdoc;

        }
    }

}