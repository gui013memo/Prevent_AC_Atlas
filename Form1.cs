using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Gma.System.MouseKeyHook;
using System.IO;



/*Instruções MouseKeyHook:
 *      
 *  
 *          1 - Para utilizar função Chamar no metodo "Subscribe" com "+=" e tambem no "Unsibscribe" com "-=" 
 *          
 *          2 - deve conter no codigo:
 *              
 *              private void Form1_Load(object sender, EventArgs e)
 *              
                {
                   Unsubscribe();
                   Subscribe(Hook.GlobalEvents());
                }
 *         
 *  
 * 
 * 
 * 
 * 
 * */

/*TODO
 *   !Resolver 
 *      - thread usando comando criado em outra thread impedindo o debug de funcionar (debugar e startar
 *      programa com instrucoes para observar este erro)! **DELEGATE**
 *      
 *      - arquivo salvo quando usado replica clicks em lugares errados
 *    
 * Current:
 *      
 *      Modificar "limpa" para limpar All e limpar ultima instrucao 
 *     
 * Next:
 * 
 * Criar função wait com caixa de dialogo para delay especifico em momentos da lista
 *      
 *      Manipular diretamenta area de transf. para ganhar tempo sem precisar usar Ctrl+V ou demais 
 *      1 - Criar modo de gravação de teclas direto do teclado fisico, ausentando o virtual (foco nas combinações)
 *      Alocaçao de memoria, mudar para dinamica conforme solicitação do user, nao estatico.
 *      auto rolagem da lista de instrucoes
 *           
 *           
 *      *     DONE - Comparação, == / > / <      
 */


namespace Auto_click_atlas_2
{

    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);


        //private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        //private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        //private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        //private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        //private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        //private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        //private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        //private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */


        /*      GLOBAL VARIABLES       */


        // MEMORIAS

        bool f_btn_record = false;
        byte recordState = 0;

        bool f_stop = false;
        byte stopState = 0;

        byte startState = 0;
        bool f_Start = false;

        bool f_pause = false;


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
                    btn_Start.PerformClick();
                }

                //STOP
                if (e.KeyChar == ' ')
                {
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

            if (startState == 1 && !f_stop && !f_btn_record && cb_enable_btns.Checked)
            {
                Thread thread1 = new Thread(t =>
                {
                    {
                        f_Start = true;

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
                                    //MessageBox.Show("Nao há instrucoes a executar!", "Auto Clicker - ATLAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                            repeticoes--;
                            // tb_restante.Text = repeticoes.ToString();

                            // if (f_stop)
                            //      tb_restante.Text = "0";

                            // tb_restante.Refresh();

                        } while (repeticoes > 0 && !f_stop && !vazio);
                    }

                    btn_Start.Text = "START (S)";
                    //btn_Start.BackColor = Color.ForestGreen; btn_Start.ForeColor = Color.White;
                    btn_Start.Refresh();

                    startState = 0;
                    f_Start = false;
                    //if (indicesVazios == Instrucoes_Global.Length)
                    //  MessageBox.Show(new Form { TopMost = true }, "Não há Instrucoes para executar!!");

                }
)
                { IsBackground = true };
                thread1.Start();

            }

        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (f_Start)
            {
                f_pause = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_instrucoes.Text = tb_instrucoes.Text.LastIndexOf("\n").ToString();
            Array.Clear(Instrucoes_Global, instructionNumber - 1, 1);

            instructionQuantity--;
            lb_instructions_quantity.Text = instructionQuantity.ToString();

            //short lastLine_tb_instr = 0;

            //input = input.Substring(0, input.LastIndexOf("/") + 1);
            tb_instrucoes.Text = tb_instrucoes.Text.Substring(0, tb_instrucoes.Text.LastIndexOf("\n") + 1);


            //tb_instrucoes.Text = tb_instrucoes.Text.Remove(3);


            if (false)
            {
                tb_instrucoes.Text = "";  //tb_instrucoes.Text.Remove((instructionNumber - 1) * 26, (instructionNumber - 1) * 30);

                Array.Clear(Instrucoes_Global, 0, Instrucoes_Global.Length);
                Array.Clear(Instrucoes_1, 0, Instrucoes_1.Length);
                Array.Clear(Instrucoes_2, 0, Instrucoes_2.Length);
                Array.Clear(Instrucoes_3, 0, Instrucoes_3.Length);
                Array.Clear(Instrucoes_4, 0, Instrucoes_4.Length);
                Array.Clear(Instrucoes_5, 0, Instrucoes_5.Length);

                instructionNumber = 0;
                f_mode = 0;
                instructionQuantity = 0;
                lb_instructions_quantity.Text = "0";
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
        private void tb_Consulta_TextChanged(object sender, EventArgs e)
        {


        }


        private void tb_interval_TextChanged(object sender, EventArgs e)
        {
            string digitsOnly = String.Empty;
            foreach (char c in tb_interval.Text)
            {
                // Do not use IsDigit as it will include more than the characters 0 through to 9
                if (c >= '0' && c <= '9') digitsOnly += c;
            }


            Int16.TryParse(digitsOnly, out short intervalo);
            interval = intervalo;

            tb_interval.Text = digitsOnly;


        }

        private void tb_repete_TextChanged(object sender, EventArgs e)
        {


            string digitsOnly = String.Empty;
            foreach (char c in tb_repete.Text)
            {
                // Do not use IsDigit as it will include more than the characters 0 through to 9
                if (c >= '0' && c <= '9') digitsOnly += c;
            }


            Int16.TryParse(digitsOnly, out short repeticaoes_);
            repeticoes = repeticaoes_;

            tb_repete.Text = digitsOnly;
        }

        /* ---- TEXT BOX END---- */


        private void Form1_Load(object sender, EventArgs e)
        {
            //if(cb_multi_Instructions.Checked)
            //{
            //    Instrucoes_Global ins
            //}

            Unsubscribe();
            Subscribe(Hook.GlobalEvents());

        }

        private void creditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new form2 { TopMost = true };
            form.Show();

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Lista de instrucoes | *.txt";
            sfd.ShowDialog();

            if (String.IsNullOrWhiteSpace(sfd.FileName) == false)
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                {
                    writer.Write(tb_instrucoes.Text);
                    writer.Flush();
                }
            }

        }

        private void carregarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Lista de instrucoes | *.txt";
            ofd.ShowDialog();



            using (StreamReader reader = new StreamReader(ofd.FileName))
            {
                string line = "testee";

                do
                {
                    line = reader.ReadLine();

                    if (line != null)
                    {
                        if (line.Contains("Click L"))
                        {
                            tb_instrucoes.Text += line + "\r\n";
                            //tb_instrucoes.Text += line.Substring(15, 4) + "\r\n";
                            Int16.TryParse(line.Substring(15, 4), out short xParsed);
                            tb_instrucoes.Text += "xParsed: " + xParsed.ToString() + "\r\n";

                            Int16.TryParse(line.Substring(22, (line.Length - 22)), out short yParsed);
                            tb_instrucoes.Text += "yParsed: " + yParsed.ToString() + "\r\n";

                            setInstructionList(xParsed, yParsed, '¬');
                        }
                        else if (line.Contains("Click R"))
                        {
                            //tb_instrucoes.Text += line + "\r\n";

                            Int16.TryParse(line.Substring(13, 4), out short xParsed);
                            Int16.TryParse(line.Substring(22, (line.Length - 22)), out short yParsed);

                            setInstructionList(xParsed, yParsed, '¨');
                        }
                    }
                } while (line != null);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unsubscribe();
        }


    }


}
