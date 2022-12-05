using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Gma.System.MouseKeyHook;
using System.IO;

/*  TO DO 
 *
 * - Carregar corretamente a Lista de Instrucoes 
 * 
 * - Executar corretamente os clicks
 *      - Conforme Cordenadas
 *      - Conforme intervalo escolhido
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
 *  /============ BUG FIX ============/
 *  
 *  - Ao tentar carregar uma IL, se o usuario noa selecionar um arquivo e pressioanr "ESC" ocorre erro: "Empty path name is not legal"
 *  
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

        // MEMORIAS

        bool f_btn_record = false;

        bool f_stop = false;
        byte stopState = 0;

        byte startState = 0;

        // MOUSE

        short x, y;


        //GENERAL PURPOUSE
        short interval = 0;
        short repeticoes = 0;
        byte f_mode = 0;
        byte modeSelected = 0;

        // Instructions

        byte instructionQuantity = 0;
        byte instructionNumber = 0;
        Instrucoes[] Instrucoes_Global = new Instrucoes[90];
        Instrucoes[] Instrucoes_1 = new Instrucoes[10];
        Instrucoes[] Instrucoes_2 = new Instrucoes[10];
        Instrucoes[] Instrucoes_3 = new Instrucoes[10];
        Instrucoes[] Instrucoes_4 = new Instrucoes[10];
        Instrucoes[] Instrucoes_5 = new Instrucoes[10];


        /*      GLOBAL VARIABLES       */

        public Form1()
        {
            InitializeComponent();

        }

        /*      ========== Get Pixel Color ==========     */
        Color GetColorAt(int x, int y)
        {
            Bitmap bmp = new Bitmap(1, 1);
            Rectangle bounds = new Rectangle(x, y, 1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            return bmp.GetPixel(0, 0);
        }
        /*      ========== Get Pixel Color ==========     */

        public void CorPixel()
        {
            Color corteste;

            if (cb_enable_btns.Checked == true)
            {
                corteste = GetColorAt(1200, 550);
                tb_instrucoes.Text = corteste.ToString();
            }


        }


        /*      ========== KeyMouseHook - functions ==========     */

        private IKeyboardMouseEvents m_Events;
        //private IMouseEvents m_MouseEvents;



        private void Subscribe(IKeyboardMouseEvents events)
        {

            m_Events = events;

            m_Events.MouseMove += M_Events_MouseMove;
            m_Events.MouseClick += M_Events_MouseClick;
            //m_Events.MouseUpExt += M_Events_MouseClickExt;

            m_Events.KeyPress += M_Events_KeyPress;
            m_Events.MouseDownExt += M_Events_MouseDownExt;
        }

        //private void Subscribe2(IMouseEvents events)
        //{

        //}

        //private void Unsubscribe2()
        //{
        //    m_MouseEvents.Dispose();
        //    m_MouseEvents = null;
        //}

        private void Unsubscribe()
        {
            if (m_Events == null) return;
            m_Events.MouseMove -= M_Events_MouseMove;
            m_Events.MouseClick -= M_Events_MouseClick;
            //m_Events.MouseUpExt -= M_Events_MouseClickExt;
            m_Events.KeyPress -= M_Events_KeyPress;
            m_Events.MouseDownExt -= M_Events_MouseDownExt;

            m_Events.Dispose();
            m_Events = null;
        }

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
                else if (Key == '$')
                {


                }

                //gb_pause.BackColor = Color.Red;
                //f_pause = true;

                //while (f_pause)
                //{
                //    gb_pause.BackColor = Color.Red;
                //    System.Threading.Thread.Sleep(100);
                //    gb_pause.BackColor = Color.White;
                //    System.Threading.Thread.Sleep(100);
                //}



                //while(btn_Continue.Focused != true)
                //{
                //    gb_pause.BackColor = Color.Red;
                //}

                //gb_pause.BackColor = Color.White;
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
                //gb_pause.BackColor = Color.Red;
                repeticoes = 0;
                // tb_restante.Text = "0";
            }
            else if (stopState == 2)
            {
                f_stop = false;
                stopState = 0;
                btn_Stop.BackColor = Color.Gold;
                btn_Stop.ForeColor = Color.Black;
                btn_Stop.Text = "Stop (Space)";
                //gb_pause.BackColor = Color.Transparent;
            }
        }

        private void setInstructionList(short x, short y, char key)
        {
            //OverfloW
            //if (instructionnumber > 10)
            //{
            //   btn_record.performclick();
            // instructionnumber = 0;
            //btn_clear.performclick();
            //messagebox.show(new form { topmost = true }, "o maximo de 50 instrucoes foi atingido, a lista foi redefinida!");
            //}

            switch (f_mode)
            {
                case 0:
                    Instrucoes_Global[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 1:
                    Instrucoes_1[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 2:
                    Instrucoes_2[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 3:
                    Instrucoes_3[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 4:
                    Instrucoes_4[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
                case 5:
                    Instrucoes_5[instructionNumber] = new Instrucoes(x, y, key);
                    instructionNumber++;
                    break;
            }

        }


        // 

        private void InstructionQuantityIncrease()
        {
            instructionQuantity++;
            lb_instructions_quantity.Text = instructionQuantity.ToString();
            tb_instrucoes.SelectionStart = tb_instrucoes.TextLength;
            tb_instrucoes.ScrollToCaret();
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
            if (f_btn_record == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    tb_instrucoes.Text += string.Format("- Click L - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    setInstructionList(x, y, '¬');
                    InstructionQuantityIncrease();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    tb_instrucoes.Text += string.Format("- Click R - X: {0} - Y: {1}\r\n", tb_X.Text, tb_Y.Text);
                    setInstructionList(x, y, '¨');
                    InstructionQuantityIncrease();
                }

            }
        }

        //private void M_Events_MouseClickExt(object sender, MouseEventExtArgs e)
        //{
        //if (!e.IsMouseButtonDown)
        //{
        //    tb_instrucoes.Text = string.Format("X = {0} - Y = {1} \r\n", e.X, e.Y);
        //    tb_instrucoes.Text += "APERTADO!";
        //    //System.Threading.Thread.Sleep(400);
        //}

        //if (e.IsMouseButtonUp)
        //{
        //    tb_instrucoes.Text += "SOLTO!!";
        //    //System.Threading.Thread.Sleep(400);
        //}


        //}


        private void M_Events_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* -  Fechar programa com ESC  - */
            //if (e.KeyChar == 27 )                              <-- ***Fecha app com "ESC"***
            //  System.Windows.Forms.Application.ExitThread();

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

            }   /* -----------END------------ */
        }



        private void M_Events_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            /*if (cb_repete.Checked == true)
            {
                tb_acoes.Text += "Verificacao iniciada!";

                Thread thread2 = new Thread(t =>
                {
                    //if (e.IsMouseButtonDown == true)
                    //{
                    //    tb_instrucoes.Text += "APERTANDO!!";
                    //    System.Threading.Thread.Sleep(100);

                    //    M_Events_MouseDownExt(sender, e);
                    //}

                    if (e.IsMouseButtonUp == true)
                    {
                        tb_instrucoes.Text += "SOLTO!";
                        System.Threading.Thread.Sleep(100);

                        M_Events_MouseDownExt(sender, e);
                    }
                })
                { IsBackground = true };
                thread2.Start();

            }*/
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

            if (startState == 1 && !f_stop && cb_enable_btns.Checked)
            {
                Thread thread1 = new Thread(t =>
                {
                    {
                        tb_instrucoes.Text = "START!";

                        btn_Start.Text = "RUNNING!";
                        btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
                        btn_Start.Refresh();

                        repeticoes++;


                        bool vazio = false;
                        do
                        {
                            //Instruction list global
                            for (byte i = 0; i < Instrucoes_Global.Length; i++)
                            {
                                if (Instrucoes_Global[0] == null)
                                {
                                    Form frm = new Form { TopMost = true };

                                    MessageBox.Show(new Form { TopMost = true }, "Nao há instrucoes para executar!", "Auto Clicker - ATLAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    vazio = true;
                                    break;
                                }

                                if (Instrucoes_Global[i] == null || f_stop)
                                {
                                    break;
                                }

                                PerformClick(Instrucoes_Global[i].X, Instrucoes_Global[i].Y, Instrucoes_Global[i].Key);
                            }
                        } while (repeticoes > 0 && !f_stop && !vazio);
                    }

                    btn_Start.Text = "START (S)";
                    btn_Start.BackColor = System.Drawing.Color.DodgerBlue;
                    btn_Start.ForeColor = Color.Black;
                    btn_Start.Refresh();

                    startState = 0;

                    //if (indicesVazios == Instrucoes_Global.Length)
                    //  MessageBox.Show(new Form { TopMost = true }, "Não há Instrucoes para executar!!");

                }
)
                { IsBackground = true };
                thread1.Start();

            }

        }
        /* --- BUTTONS END --- */

        /* ---- CHECK BOX ---- */

        private void cb_enable_btns_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;  //Para tirar o foco do cb e nao ser checado pela tecla SPACE
        }

        /* ---- CHECK BOX END ---- */


        /* ---- TEXT BOX ---- */

        private void tb_interval_TextChanged(object sender, EventArgs e)
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

        private void tb_repete_TextChanged(object sender, EventArgs e)
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

        private void carregarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (cb_enable_btns.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Lista de instrucoes | *.txt";
                ofd.ShowDialog();

                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    string line;
                    short empty = 0;

                    do
                    {
                        line = reader.ReadLine();

                        if (line != null)
                        {
                            empty++;

                            if (line.Contains("Click L"))
                            {
                                Int16.TryParse(line.Substring(15, 4), out short xParsed);

                                Int16.TryParse(line.Substring(24, (line.Length - 24)), out short yParsed);

                                setInstructionList(xParsed, yParsed, '¬');
                            }
                            else if (line.Contains("Click R"))
                            {
                                Int16.TryParse(line.Substring(15, 4), out short xParsed);
                                Int16.TryParse(line.Substring(24, (line.Length - 24)), out short yParsed);

                                setInstructionList(xParsed, yParsed, '¨');
                            }
                        }
                        else if (empty == 0)
                        {
                            MessageBox.Show(new Form { TopMost = true }, "Nao há instrucoes no Arquivo", "Prevent AC Atlas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;   
                        }
                        else
                        {
                            tb_instrucoes.Text = "Lista carregada!";
                        }

                    } while (line != null);
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }


    }


}
