
namespace Auto_click_atlas_2
{
    partial class Form1
    {
        /// <summary> 
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.cb_enable_btns = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_instrucoes = new System.Windows.Forms.TextBox();
            this.lb_StepCounter = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.lb_interval = new System.Windows.Forms.Label();
            this.tb_repete = new System.Windows.Forms.TextBox();
            this.lb_CurrentStep = new System.Windows.Forms.Label();
            this.lb_repete = new System.Windows.Forms.Label();
            this.lb_TimeRestante = new System.Windows.Forms.Label();
            this.lb_TimeRestante_num = new System.Windows.Forms.Label();
            this.lb_Console = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(13, 301);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(440, 67);
            this.btn_Start.TabIndex = 15;
            this.btn_Start.Text = "START (S)";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Gold;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Stop.FlatAppearance.BorderSize = 44;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(13, 374);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(441, 99);
            this.btn_Stop.TabIndex = 16;
            this.btn_Stop.Text = "STOP (SPACE)";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // cb_enable_btns
            // 
            this.cb_enable_btns.AutoSize = true;
            this.cb_enable_btns.BackColor = System.Drawing.Color.Black;
            this.cb_enable_btns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cb_enable_btns.ForeColor = System.Drawing.Color.White;
            this.cb_enable_btns.Location = new System.Drawing.Point(140, 257);
            this.cb_enable_btns.Name = "cb_enable_btns";
            this.cb_enable_btns.Size = new System.Drawing.Size(183, 24);
            this.cb_enable_btns.TabIndex = 27;
            this.cb_enable_btns.Text = "HABILITAR CONTROLES";
            this.cb_enable_btns.UseVisualStyleBackColor = false;
            this.cb_enable_btns.CheckedChanged += new System.EventHandler(this.cb_enable_btns_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarListaToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // carregarListaToolStripMenuItem
            // 
            this.carregarListaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.carregarListaToolStripMenuItem.Name = "carregarListaToolStripMenuItem";
            this.carregarListaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.carregarListaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.carregarListaToolStripMenuItem.Text = "Carregar lista";
            this.carregarListaToolStripMenuItem.Click += new System.EventHandler(this.carregarListaToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem1});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.creditosToolStripMenuItem.Text = "&Sobre";
            // 
            // creditosToolStripMenuItem1
            // 
            this.creditosToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.creditosToolStripMenuItem1.Name = "creditosToolStripMenuItem1";
            this.creditosToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem1.Text = "&Creditos";
            this.creditosToolStripMenuItem1.Click += new System.EventHandler(this.creditosToolStripMenuItem1_Click);
            // 
            // tb_instrucoes
            // 
            this.tb_instrucoes.BackColor = System.Drawing.Color.Black;
            this.tb_instrucoes.ForeColor = System.Drawing.Color.White;
            this.tb_instrucoes.Location = new System.Drawing.Point(12, 68);
            this.tb_instrucoes.Multiline = true;
            this.tb_instrucoes.Name = "tb_instrucoes";
            this.tb_instrucoes.ReadOnly = true;
            this.tb_instrucoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_instrucoes.Size = new System.Drawing.Size(431, 144);
            this.tb_instrucoes.TabIndex = 55;
            // 
            // lb_StepCounter
            // 
            this.lb_StepCounter.AutoSize = true;
            this.lb_StepCounter.BackColor = System.Drawing.Color.Black;
            this.lb_StepCounter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_StepCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_StepCounter.Location = new System.Drawing.Point(287, 33);
            this.lb_StepCounter.Name = "lb_StepCounter";
            this.lb_StepCounter.Size = new System.Drawing.Size(109, 21);
            this.lb_StepCounter.TabIndex = 56;
            this.lb_StepCounter.Text = "Step Counter";
            // 
            // tb_X
            // 
            this.tb_X.BackColor = System.Drawing.Color.Black;
            this.tb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_X.ForeColor = System.Drawing.Color.White;
            this.tb_X.Location = new System.Drawing.Point(163, 218);
            this.tb_X.Name = "tb_X";
            this.tb_X.ReadOnly = true;
            this.tb_X.Size = new System.Drawing.Size(51, 23);
            this.tb_X.TabIndex = 58;
            this.tb_X.Text = "0";
            this.tb_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Y
            // 
            this.tb_Y.BackColor = System.Drawing.Color.Black;
            this.tb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Y.ForeColor = System.Drawing.Color.White;
            this.tb_Y.Location = new System.Drawing.Point(261, 218);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.ReadOnly = true;
            this.tb_Y.Size = new System.Drawing.Size(51, 23);
            this.tb_Y.TabIndex = 59;
            this.tb_Y.Text = "0";
            this.tb_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_X
            // 
            this.lb_X.AutoSize = true;
            this.lb_X.BackColor = System.Drawing.Color.Black;
            this.lb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_X.ForeColor = System.Drawing.Color.White;
            this.lb_X.Location = new System.Drawing.Point(140, 221);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(18, 15);
            this.lb_X.TabIndex = 60;
            this.lb_X.Text = "X:";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.BackColor = System.Drawing.Color.Black;
            this.lb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Y.ForeColor = System.Drawing.Color.White;
            this.lb_Y.Location = new System.Drawing.Point(238, 222);
            this.lb_Y.Name = "lb_Y";
            this.lb_Y.Size = new System.Drawing.Size(17, 15);
            this.lb_Y.TabIndex = 61;
            this.lb_Y.Text = "Y:";
            // 
            // tb_interval
            // 
            this.tb_interval.BackColor = System.Drawing.Color.Black;
            this.tb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_interval.ForeColor = System.Drawing.Color.White;
            this.tb_interval.Location = new System.Drawing.Point(272, 499);
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(51, 23);
            this.tb_interval.TabIndex = 62;
            this.tb_interval.Text = "0";
            this.tb_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_interval
            // 
            this.lb_interval.AutoSize = true;
            this.lb_interval.BackColor = System.Drawing.Color.Black;
            this.lb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_interval.ForeColor = System.Drawing.Color.White;
            this.lb_interval.Location = new System.Drawing.Point(270, 525);
            this.lb_interval.Name = "lb_interval";
            this.lb_interval.Size = new System.Drawing.Size(53, 15);
            this.lb_interval.TabIndex = 63;
            this.lb_interval.Text = "Intervalo";
            // 
            // tb_repete
            // 
            this.tb_repete.BackColor = System.Drawing.Color.Black;
            this.tb_repete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_repete.ForeColor = System.Drawing.Color.White;
            this.tb_repete.Location = new System.Drawing.Point(374, 499);
            this.tb_repete.Name = "tb_repete";
            this.tb_repete.Size = new System.Drawing.Size(51, 23);
            this.tb_repete.TabIndex = 57;
            this.tb_repete.Text = "0";
            this.tb_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_CurrentStep
            // 
            this.lb_CurrentStep.AutoSize = true;
            this.lb_CurrentStep.BackColor = System.Drawing.Color.Black;
            this.lb_CurrentStep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CurrentStep.ForeColor = System.Drawing.Color.White;
            this.lb_CurrentStep.Location = new System.Drawing.Point(402, 33);
            this.lb_CurrentStep.Name = "lb_CurrentStep";
            this.lb_CurrentStep.Size = new System.Drawing.Size(19, 21);
            this.lb_CurrentStep.TabIndex = 64;
            this.lb_CurrentStep.Text = "0";
            // 
            // lb_repete
            // 
            this.lb_repete.AutoSize = true;
            this.lb_repete.BackColor = System.Drawing.Color.Black;
            this.lb_repete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_repete.ForeColor = System.Drawing.Color.White;
            this.lb_repete.Location = new System.Drawing.Point(374, 525);
            this.lb_repete.Name = "lb_repete";
            this.lb_repete.Size = new System.Drawing.Size(53, 15);
            this.lb_repete.TabIndex = 65;
            this.lb_repete.Text = "Intervalo";
            // 
            // lb_TimeRestante
            // 
            this.lb_TimeRestante.AutoSize = true;
            this.lb_TimeRestante.BackColor = System.Drawing.Color.Black;
            this.lb_TimeRestante.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_TimeRestante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_TimeRestante.Location = new System.Drawing.Point(252, 559);
            this.lb_TimeRestante.Name = "lb_TimeRestante";
            this.lb_TimeRestante.Size = new System.Drawing.Size(169, 30);
            this.lb_TimeRestante.TabIndex = 67;
            this.lb_TimeRestante.Text = "Tempo restante:";
            // 
            // lb_TimeRestante_num
            // 
            this.lb_TimeRestante_num.AutoSize = true;
            this.lb_TimeRestante_num.BackColor = System.Drawing.Color.Black;
            this.lb_TimeRestante_num.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TimeRestante_num.ForeColor = System.Drawing.Color.White;
            this.lb_TimeRestante_num.Location = new System.Drawing.Point(315, 589);
            this.lb_TimeRestante_num.Name = "lb_TimeRestante_num";
            this.lb_TimeRestante_num.Size = new System.Drawing.Size(47, 21);
            this.lb_TimeRestante_num.TabIndex = 68;
            this.lb_TimeRestante_num.Text = "1h30";
            // 
            // lb_Console
            // 
            this.lb_Console.AutoSize = true;
            this.lb_Console.BackColor = System.Drawing.Color.Black;
            this.lb_Console.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Console.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Console.Location = new System.Drawing.Point(12, 44);
            this.lb_Console.Name = "lb_Console";
            this.lb_Console.Size = new System.Drawing.Size(66, 21);
            this.lb_Console.TabIndex = 69;
            this.lb_Console.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AutoClick_ATL.Properties.Resources.Template_Atlas_Black_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 643);
            this.Controls.Add(this.lb_Console);
            this.Controls.Add(this.lb_TimeRestante_num);
            this.Controls.Add(this.lb_TimeRestante);
            this.Controls.Add(this.lb_repete);
            this.Controls.Add(this.lb_CurrentStep);
            this.Controls.Add(this.tb_instrucoes);
            this.Controls.Add(this.lb_StepCounter);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.lb_X);
            this.Controls.Add(this.lb_Y);
            this.Controls.Add(this.tb_interval);
            this.Controls.Add(this.lb_interval);
            this.Controls.Add(this.tb_repete);
            this.Controls.Add(this.cb_enable_btns);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(860, 393);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lb_acoes;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.CheckBox cb_fixo;
        private System.Windows.Forms.CheckBox cb_enable_btns;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.TextBox tb_clicks;
        private System.Windows.Forms.Label lb_prazo;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.CheckBox cb_multi_Instructions;
        private System.Windows.Forms.Label lb_Duplo;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label lb_multiInstrucoes_2;
        private System.Windows.Forms.Button btn_modo_1;
        private System.Windows.Forms.Button btn_modo_2;
        private System.Windows.Forms.Button btn_modo_3;
        private System.Windows.Forms.Button btn_modo_4;
        private System.Windows.Forms.Button btn_modo_5;
        private System.Windows.Forms.CheckBox cb_consulta;
        private System.Windows.Forms.Label lb_consulta2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem1;
        private System.Windows.Forms.TextBox tb_Previsao;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_modo;
        private System.Windows.Forms.Label lb_currentMode;
        private System.Windows.Forms.Label lb_instructions_quantity;
        private System.Windows.Forms.Label lb_Consulta;
        private System.Windows.Forms.TextBox tb_Consulta;
        private System.Windows.Forms.Label lb_compareResult;
        private System.Windows.Forms.Button btn_compare_equal;
        private System.Windows.Forms.Label lb_Arquivo_IL;
        private System.Windows.Forms.Label lb_Arquivo_IL_util;
        private System.Windows.Forms.Button btn_compare_greater;
        private System.Windows.Forms.Button btn_compare_less;
        private System.Windows.Forms.Label lb_CurrentStep;
        private System.Windows.Forms.TextBox tb_restante;
        private System.Windows.Forms.TextBox tb_instrucoes;
        private System.Windows.Forms.Label lb_StepCounter;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Label lb_X;
        private System.Windows.Forms.Label lb_Y;
        private System.Windows.Forms.TextBox tb_interval;
        private System.Windows.Forms.Label lb_interval;
        private System.Windows.Forms.TextBox tb_repete;
        private System.Windows.Forms.Label lb_repete;
        private System.Windows.Forms.Label lb_TimeRestante;
        private System.Windows.Forms.Label lb_TimeRestante_num;
        private System.Windows.Forms.Label lb_Console;
    }
}

