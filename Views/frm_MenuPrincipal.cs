using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha_PC.Views
{
    public partial class frm_MenuPrincipal : Form
    {
       

       
        public frm_MenuPrincipal()
        {
            InitializeComponent();
         
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
           
           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
