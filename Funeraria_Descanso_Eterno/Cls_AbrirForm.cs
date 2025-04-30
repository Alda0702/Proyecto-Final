using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public class Cls_AbrirForm
    {
       public void abrirForm(object formH, Panel pnl_Contenedor)
        {
            //Clase para que un Form pueda ejecutarse en un Panel
            //Si ya existe informacion en el panel no se abrira un form uno encima de otro 
            if (pnl_Contenedor.Controls.Count > 0)
                pnl_Contenedor.Controls.RemoveAt(0);

            Form fh = formH as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnl_Contenedor.Controls.Add(fh);
            pnl_Contenedor.Tag = fh;
            fh.Show();
        }
    }
}
