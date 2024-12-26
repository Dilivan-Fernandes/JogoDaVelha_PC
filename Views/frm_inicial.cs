using JogoDaVelha_PC.Controls;
using JogoDaVelha_PC.Views;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha_PC
{
    public partial class frm_inicial : Form
    {
        string vez = "0";
        public string vencedor = "";
        public int ponto_X = 0;
        public int ponto_0 = 0;

        public SoundPlayer sound;

        frm_MenuPrincipal menu = new frm_MenuPrincipal();
      
        public frm_inicial()
        {
            InitializeComponent();

            LiumparBotoes();
            menu.ShowDialog();
            //  SON DE FUNDO
            sound = new SoundPlayer(Properties.Resources.FundoJogoDaVelha);
            sound.Load();
            sound.PlayLooping();
            //========================================================================================================

            // SON DO CLICK

           
        }

        private void LiumparBotoes()
        {
            bt_1.Text = "";
            bt_2.Text = "";
            bt_3.Text = "";
            bt_4.Text = "";
            bt_5.Text = "";
            bt_6.Text = "";
            bt_7.Text = "";
            bt_8.Text = "";
            bt_9.Text = "";
        }
        private void frm_inicial_Load(object sender, EventArgs e)
        {

            // Código que associa o evento KeyDown ao manipulador de eventos do formulário 
           
                this.KeyPreview = true;

                this.KeyDown += frm_inicial_KeyDown;
            
           
            
        }


        // Evento KeyDown onde escolho as teclas de atalho que pretendo usar
        private void frm_inicial_KeyDown(object sender, KeyEventArgs e)
        {
          

            if (e.KeyCode == Keys.Escape)
            {
                bt_sair.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                if (bt_1.Text == "")
                {
                    bt_1.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.Q)
            {
                if (bt_1.Text == "")
                {
                    bt_1.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.NumPad8)
            {
                if (bt_2.Text == "")
                {
                    bt_2.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (bt_2.Text == "")
                {
                    bt_2.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                if (bt_3.Text == "")
                {
                    bt_3.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.E)
            {
                if (bt_3.Text == "")
                {
                    bt_3.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                if (bt_4.Text == "")
                {
                    bt_4.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.A)
            {
                if (bt_4.Text == "")
                {
                    bt_4.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                if (bt_5.Text == "")
                {
                    bt_5.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.S)
            {
                if (bt_5.Text == "")
                {
                    bt_5.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                if (bt_6.Text == "")
                {
                    bt_6.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.D)
            {
                if (bt_6.Text == "")
                {
                    bt_6.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                if (bt_7.Text == "")
                {
                    bt_7.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.Z)
            {
                if (bt_7.Text == "")
                {
                    bt_7.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                if (bt_8.Text == "")
                {
                    bt_8.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.X)
            {
                if (bt_8.Text == "")
                {
                    bt_8.PerformClick();
                }
                else
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                if (bt_9.Text == "")
                {
                    bt_9.PerformClick();
                }
                else
                {
                    return;
                }

            }
            if (e.KeyCode == Keys.C)
            {
                if (bt_9.Text == "")
                {
                    bt_9.PerformClick();
                }
                else
                {
                    return;
                }
            }

        
           
        }
        //===============================================================================================
        // Métodos

        public void VerificarEmpate()
        {
            if (bt_1.Text != "" && bt_2.Text != "" && bt_3.Text != "" && bt_4.Text != "" && bt_5.Text != "" && bt_6.Text != "" && bt_7.Text != "" && bt_8.Text != "" && bt_9.Text != "")
            {
                frm_notofocacao_JogoEmpatado frm = new frm_notofocacao_JogoEmpatado(this);
                frm.ShowDialog();
            }
        }
        public void VerificarGanhador()
        {
            //======================================================

            //  linha 1

            if (bt_1.Text=="X" && bt_2.Text=="X" && bt_3.Text=="X")   
            {
                bt_1.BackColor = Color.Gold;
                bt_2.BackColor = Color.Gold;
                bt_3.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
                
            }  
            else
            {
                if (bt_1.Text == "0" && bt_2.Text == "0" && bt_3.Text == "0")
                {
                    bt_1.BackColor = Color.Gold;
                    bt_2.BackColor = Color.Gold;
                    bt_3.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                   
                }
            }
            //  linha 2

            if (bt_4.Text == "X" && bt_5.Text == "X" && bt_6.Text == "X")
            {
                bt_4.BackColor = Color.Gold;
                bt_5.BackColor = Color.Gold;
                bt_6.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
               
            }
            else
            {
                if (bt_4.Text == "0" && bt_5.Text == "0" && bt_6.Text == "0")
                {
                    bt_4.BackColor = Color.Gold;
                    bt_5.BackColor = Color.Gold;
                    bt_6.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                    
                }
            }

            // linha 3

            if (bt_7.Text == "X" && bt_8.Text == "X" && bt_9.Text == "X")
            {
                bt_7.BackColor = Color.Gold;
                bt_8.BackColor = Color.Gold;
                bt_9.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
               
            }
            else
            {
                if (bt_7.Text == "0" && bt_8.Text == "0" && bt_9.Text == "0")
                {
                    bt_7.BackColor = Color.Gold;
                    bt_8.BackColor = Color.Gold;
                    bt_9.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                   
                }
            }

            // coluna 1

            if (bt_1.Text == "X" && bt_4.Text == "X" && bt_7.Text == "X")
            {
                bt_1.BackColor = Color.Gold;
                bt_4.BackColor = Color.Gold;
                bt_7.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
              
            }
            else
            {
                if (bt_1.Text == "0" && bt_4.Text == "0" && bt_7.Text == "0")
                {
                    bt_1.BackColor = Color.Gold;
                    bt_4.BackColor = Color.Gold;
                    bt_7.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                   
                }
            }

            // coluna 2

            if (bt_2.Text == "X" && bt_5.Text == "X" && bt_8.Text == "X")
            {
                bt_2.BackColor = Color.Gold;
                bt_5.BackColor = Color.Gold;
                bt_8.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
               
            }
            else
            {
                if (bt_2.Text == "0" && bt_5.Text == "0" && bt_8.Text == "0")
                {
                    bt_2.BackColor = Color.Gold;
                    bt_5.BackColor = Color.Gold;
                    bt_8.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                   
                }
            }

            // coluna 3

            if (bt_3.Text == "X" && bt_6.Text == "X" && bt_9.Text == "X")
            {
                bt_3.BackColor = Color.Gold;
                bt_6.BackColor = Color.Gold;
                bt_9.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
              
            }
            else
            {
                if (bt_3.Text == "0" && bt_6.Text == "0" && bt_9.Text == "0")
                {
                    bt_3.BackColor = Color.Gold;
                    bt_6.BackColor = Color.Gold;
                    bt_9.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                    
                }
            }

            // diagonal 1

            if (bt_1.Text == "X" && bt_5.Text == "X" && bt_9.Text == "X")
            {
                bt_1.BackColor = Color.Gold;
                bt_5.BackColor = Color.Gold;
                bt_9.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
               
            }
            else
            {
                if (bt_1.Text == "0" && bt_5.Text == "0" && bt_9.Text == "0")
                {
                    bt_1.BackColor = Color.Gold;
                    bt_5.BackColor = Color.Gold;
                    bt_9.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                    
                }
            }

            // diagonal 2

            if (bt_7.Text == "X" && bt_5.Text == "X" && bt_3.Text == "X")
            {
                bt_7.BackColor = Color.Gold;
                bt_5.BackColor = Color.Gold;
                bt_3.BackColor = Color.Gold;

                vencedor = "X";
                frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                frm.ShowDialog();
                ponto_X += 1;
                lb_pontosX.Text = ponto_X.ToString();
               
            }
            else
            {
                if (bt_7.Text == "0" && bt_5.Text == "0" && bt_3.Text == "0")
                {
                    bt_7.BackColor = Color.Gold;
                    bt_5.BackColor = Color.Gold;
                    bt_3.BackColor = Color.Gold;

                    vencedor = "0";
                    frm_notificacao_Vencedor frm = new frm_notificacao_Vencedor(this);
                    frm.ShowDialog();
                    ponto_0 += 1;
                    lb_pontos0.Text = ponto_0.ToString();
                    
                }
            }
        }

        //===============================================================================================
        private void lb_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
           
            if (vez == "0")
            {
                bt_1.Text = "X";
                vez = "X";
                if (bt_1.Text=="X")
                {
                    bt_1.ForeColor = Color.Salmon;
                    
                }
               
            }
            else
            {
                if (vez == "X")
                {
                    bt_1.Text = "0";
                    vez = "0";
                    if (bt_1.Text == "0")
                    {
                        bt_1.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_2.Text = "X";
                vez = "X";
                if (bt_2.Text == "X")
                {
                    bt_2.ForeColor = Color.Salmon;
                   
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_2.Text = "0";
                    vez = "0";
                    if (bt_2.Text == "0")
                    {
                        bt_2.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_3.Text = "X";
                vez = "X";
                if (bt_3.Text == "X")
                {
                    bt_3.ForeColor = Color.Salmon;
                   
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_3.Text = "0";
                    vez = "0";
                    if (bt_3.Text == "0")
                    {
                        bt_3.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_4.Text = "X";
                vez = "X";
                if (bt_4.Text == "X")
                {
                    bt_4.ForeColor = Color.Salmon;
                    
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_4.Text = "0";
                    vez = "0";
                    if (bt_4.Text == "0")
                    {
                        bt_4.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_5.Text = "X";
                vez = "X";
                if (bt_5.Text == "X")
                {
                    bt_5.ForeColor = Color.Salmon;
                    
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_5.Text = "0";
                    vez = "0";
                    if (bt_5.Text == "0")
                    {
                        bt_5.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_6.Text = "X";
                vez = "X";
                if (bt_6.Text == "X")
                {
                    bt_6.ForeColor = Color.Salmon;
                    
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_6.Text = "0";
                    vez = "0";
                    if (bt_6.Text == "0")
                    {
                        bt_6.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_7.Text = "X";
                vez = "X";
                if (bt_7.Text == "X")
                {
                    bt_7.ForeColor = Color.Salmon;
                   
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_7.Text = "0";
                    vez = "0";
                    if (bt_7.Text == "0")
                    {
                        bt_7.ForeColor = Color.DeepPink;
                        
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_8.Text = "X";
                vez = "X";
                if (bt_8.Text == "X")
                {
                    bt_8.ForeColor = Color.Salmon;
                    
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_8.Text = "0";
                    vez = "0";
                    if (bt_8.Text == "0")
                    {
                        bt_8.ForeColor = Color.DeepPink;
                       
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (vez == "0")
            {
                bt_9.Text = "X";
                vez = "X";
                if (bt_9.Text == "X")
                {
                    bt_9.ForeColor = Color.Salmon;
                    
                }

            }
            else
            {
                if (vez == "X")
                {
                    bt_9.Text = "0";
                    vez = "0";
                    if (bt_9.Text == "0")
                    {
                        bt_9.ForeColor = Color.DeepPink;
                       
                    }
                }
            }
            VerificarGanhador();
            VerificarEmpate();
        }

       

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_teclado_Click(object sender, EventArgs e)
        {
            frm_teclado teclado = new frm_teclado();
            teclado.ShowDialog();
        }
    }
    
}
