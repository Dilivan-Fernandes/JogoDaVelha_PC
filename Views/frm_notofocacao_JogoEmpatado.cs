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
    public partial class frm_notofocacao_JogoEmpatado : Form
    {
        frm_inicial f;
        SoundPlayer player;
        public frm_notofocacao_JogoEmpatado(frm_inicial j)
        {
            InitializeComponent();
            f = j;

            player = new SoundPlayer(Properties.Resources.Pato);

             
        }

        public void FormatarFormularioPrincipal()
        {
            f.bt_1.Text = "";
            f.bt_2.Text = "";
            f.bt_3.Text = "";
            f.bt_4.Text = "";
            f.bt_5.Text = "";
            f.bt_6.Text = "";
            f.bt_7.Text = "";
            f.bt_8.Text = "";
            f.bt_9.Text = "";

            f.bt_1.BackColor = Color.SteelBlue;
            f.bt_2.BackColor = Color.SteelBlue;
            f.bt_3.BackColor = Color.SteelBlue;
            f.bt_4.BackColor = Color.SteelBlue;
            f.bt_5.BackColor = Color.SteelBlue;
            f.bt_6.BackColor = Color.SteelBlue;
            f.bt_7.BackColor = Color.SteelBlue;
            f.bt_8.BackColor = Color.SteelBlue;
            f.bt_9.BackColor = Color.SteelBlue;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Close();
            FormatarFormularioPrincipal();
            f.sound.Play();
        }

        private void frm_notofocacao_JogoEmpatado_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            this.KeyDown += frm_notofocacao_JogoEmpatado_KeyDown;
            player.Play();
        }

        private void frm_notofocacao_JogoEmpatado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
