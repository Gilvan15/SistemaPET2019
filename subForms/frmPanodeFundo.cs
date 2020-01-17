using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmPanodeFundo : Form
    {
        public frmPanodeFundo()
        {
            InitializeComponent();

        }

        public static void AbrirPanodeFundo()
        {
            frmPanodeFundo frm1 = new frmPanodeFundo();
            frm1.Show();
        }
        public static void FecharPanodeFundo() 
        {
            Form.ActiveForm.Close();
            
        }

    }
}
