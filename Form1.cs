using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Gma.System.MouseKeyHook;
using System.IO;

/* MODELO LISTA DE INSTRUCOES: 
 
- Click L - X: 280 - Y: 430
- Click L - X: 1000 - Y: 430
- Click L - X: 1000 - Y: 1000
- Click L - X: 280 - Y: 1000
 
 */

/*  TO DO 
 *
 * - Carregar corretamente a Lista de Instrucoes 
 * 
 * - Executar corretamente os clicks
 *      - Conforme Cordenadas - OK
 *      - Conforme intervalo escolhido - OK
 *      - Repeticoes - OK
 *      
 * - Validacao por pixel
 *      - Incluir na Lista de Instrucoes as cordenadas do pixel ser avaliado
 *      - Rodar clicks com validacao de pixel e com intervalo pós click estipulado pelo usuario 
 * 
 * - Gerar log na lista de instrucao a cada acao
 * 
 * - Add textBox "Repeticoes" desejadas pelo usuario
 *      - Add label "OS encerradas"
 *      - Add label "Tempo estimado"
 *      
 *  /======== BUG FIX ========/
 *  
 *  - Ao tentar carregar uma IL, se o usuario noa selecionar um arquivo e pressioanr "ESC" ocorre erro: "Empty path name is not legal"
 *  
 *  /======== IMPROVEMENTS ========/
 *  Validacao de array vazio (lista de intrucoes vazia) ocorrendo a cada click, deve ocorrer apenas no primerio click do array
 */

namespace Auto_click_atlas_2
{

    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */

        /*      GLOBAL VARIABLES       */

        // STATES FLAGS
        bool f_btn_record = false;
        bool f_stop = false;
        byte stopState = 0;
        byte startState = 0;

        // MOUSE
        short x, y;

        // GENERAL PURPOUSE
        short interval = 0;
        short repeticoes = 0;

        // INSTRUCTIONS
        byte instructionNumber = 0;
        Instrucoes[] Instrucoes = new Instrucoes[80];

        /*      GLOBAL VARIABLES       */

        public Form1()
        {
            InitializeComponent();

        }

        /* ========== Get Pixel Color END ========== */

        Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return bmp.GetPixel(0, 0);
        }

        public void CorPixel()
        {
            Color corteste;

            if (cb_enable_btns.Checked == true)
            {
                corteste = GetColorAt(1200, 550);
                tb_instrucoes.Text = corteste.ToString();
            }
        }

        /* ========== Get Pixel Color END ========== */

        /* ========== KeyMouseHook ========== */

        private IKeyboardMouseEvents m_Events;

        private void Subscribe(IKeyboardMouseEvents events)
        {
            m_Events = events;

            m_Events.MouseMove += M_Events_MouseMove;
            m_Events.MouseClick += M_Events_MouseClick;
            m_Events.KeyPress += M_Events_KeyPress;
        }

        private void Unsubscribe()
        {
            if (m_Events == null) return;
            m_Events.MouseMove -= M_Events_MouseMove;
            m_Events.MouseClick -= M_Events_MouseClick;
            m_Events.KeyPress -= M_Events_KeyPress;

            m_Events.Dispose();
            m_Events = null;
        }

        /* ========== KeyMouseHook END ========== */

        public void PerformClick(int X, int Y, char Key)
        {
            if (!f_stop)
            {
                SetCursorPos(X, Y);

                if (Key == '¬')
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

                    System.Threading.Thread.Sleep(interval);
                }
                else if (Key == '¨')
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 2, 0);
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 2, 0);

                    System.Threading.Thread.Sleep(interval);
                }
            }
        }

        private void Stop_Execution()
        {
            stopState++;

            if (stopState == 1)
            {
                f_stop = true;
                btn_Stop.BackColor = Color.DarkRed;
                btn_Stop.ForeColor = Color.White;
                btn_Stop.Text = "LOCKED!";
                repeticoes = 0;
            }
            else if (stopState == 2)
            {
                f_stop = false;
                stopState = 0;
                btn_Stop.BackColor = Color.Gold;
                btn_Stop.ForeColor = Color.Black;
                btn_Stop.Text = "Stop (Space)";
            }
        }

        private void setInstructionList(short x, short y, char key)
        {
            Instrucoes[instructionNumber] = new Instrucoes(x, y, key);
        }

        private void M_Events_MouseMove(object sender, MouseEventArgs e)
        {

            if (cb_enable_btns.Checked == true)
            {
                tb_X.Text = e.X.ToString();
                tb_Y.Text = e.Y.ToString();

                x = ((short)e.X);
                y = ((short)e.Y);
            }

        }



        private void M_Events_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void M_Events_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_enable_btns.Checked)
            {
                //START
                if (f_btn_record == false && f_stop == false && (e.KeyChar == 's' || e.KeyChar == 'S'))
                {
                    //tb_instrucoes.Text = "START!";
                    btn_Start.PerformClick();
                }

                //STOP
                if (e.KeyChar == ' ')
                {
                    //tb_instrucoes.Text = "SPACE HITED!";
                    Stop_Execution();
                }
            }
        }





        //      ========== KeyMouseHook - END - functions ==========



        /* ---- FUNCOES END ----*/

        /* --- BUTTONS --- */

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            if (cb_enable_btns.Checked && f_btn_record)
            {
                tb_instrucoes.Text += "- # # PAUSA # #\r\n";
                setInstructionList(x, y, '$');
            }
        }

        //private void btn_Select_Click(object sender, EventArgs e)
        //{
        //    if (cb_enable_btns.Checked && f_btn_record)
        //    {
        //        setInstructionList(x, y, 's');
        //        tb_instrucoes.Text += "### SELECT ###\r\n";


        //    }
        //}


        //      ======= Botoes END =======


        //      ======= User Functions =======


        private void btn_Start_Click(object sender, EventArgs e)
        {
            startState++;

            Thread thread1 = new Thread(t =>
                {
                    if (startState == 1 && !f_stop && cb_enable_btns.Checked)
                    {
                        Int16.TryParse(tb_repete.Text, out short repeticaoes_);
                        repeticoes = repeticaoes_;

                        tb_instrucoes.Text = "START!";

                        btn_Start.Text = "RUNNING!";
                        btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
                        btn_Start.Refresh();

                        lb_OS_restante.Text = repeticoes.ToString();

                        bool vazio = false;
                        bool nonexecution = false;
                        if (repeticoes < 1)
                            nonexecution = true;

                        do
                        {
                            if (repeticoes < 1)
                            {
                                MessageBox.Show(new Form { TopMost = true }, "Numero de execuções igual a 0", "Auto Clicker - ATLAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            repeticoes--;
                            lb_OS_restante.Text = repeticoes.ToString();

                            for (byte i = 0; i < Instrucoes.Length; i++)
                            {
                                if (Instrucoes[0] == null)
                                {
                                    MessageBox.Show(new Form { TopMost = true }, "Nao há instrucoes para executar!", "Auto Clicker - ATLAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    vazio = true;
                                    break;
                                }

                                if (Instrucoes[i] == null || f_stop)
                                {
                                    break;
                                }

                                PerformClick(Instrucoes[i].X, Instrucoes[i].Y, Instrucoes[i].Key);
                            }
                        } while (repeticoes > 0 && !f_stop && !vazio);
                    }

                    btn_Start.Text = "START (S)";
                    btn_Start.BackColor = System.Drawing.Color.DodgerBlue;
                    btn_Start.ForeColor = Color.Black;
                    btn_Start.Refresh();

                    startState = 0;

                    //if (indicesVazios == Instrucoes.Length)
                    //  MessageBox.Show(new Form { TopMost = true }, "Não há Instrucoes para executar!!");

                }
    )
            { IsBackground = true };
            thread1.Start();



        }
        /* --- BUTTONS END --- */

        /* ---- CHECK BOX ---- */

        private void cb_enable_btns_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //Para tirar o foco do cb e nao ser checado pela tecla SPACE
        }

        /* ---- CHECK BOX END ---- */


        /* ---- TEXT BOX ---- */

        private void tb_interval_TextChanged_1(object sender, EventArgs e)
        {
            string digitsOnly = String.Empty;
            foreach (char c in tb_interval.Text) //Formatacao para permitir somente numeros no TextBox evitando letras
            {
                if (c >= '0' && c <= '9') digitsOnly += c;
            }

            Int16.TryParse(digitsOnly, out short intervalo);
            interval = intervalo;

            tb_interval.Text = digitsOnly;
        }

        private void tb_repete_TextChanged_1(object sender, EventArgs e)
        {
            string digitsOnly = String.Empty;
            foreach (char c in tb_repete.Text)//Formatacao para permitir somente numeros no TextBox evitando letras
            {
                if (c >= '0' && c <= '9') digitsOnly += c;
            }

            Int16.TryParse(digitsOnly, out short repeticaoes_);
            repeticoes = repeticaoes_;

            tb_repete.Text = digitsOnly;
        }

        /* ---- TEXT BOX END---- */

        private void Form1_Load(object sender, EventArgs e)
        {
            Unsubscribe();
            Subscribe(Hook.GlobalEvents());
        }

        private void creditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new form2 { TopMost = true };
            form.Show();
        }
            
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }


    }
}



