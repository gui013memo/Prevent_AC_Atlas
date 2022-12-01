
namespace Auto_click_atlas_2
{
    partial class Form1
    {
        /* testeee  */
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
            this.lb_instrucoes = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.tb_interval = new System.Windows.Forms.TextBox();
            this.lb_interval = new System.Windows.Forms.Label();
            this.tb_repete = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.FlatAppearance.BorderSize = 10;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(12, 336);
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
            this.btn_Stop.FlatAppearance.BorderSize = 20;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(11, 409);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(441, 106);
            this.btn_Stop.TabIndex = 16;
            this.btn_Stop.Text = "Stop (Space)";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // cb_enable_btns
            // 
            this.cb_enable_btns.AutoSize = true;
            this.cb_enable_btns.BackColor = System.Drawing.Color.Gold;
            this.cb_enable_btns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cb_enable_btns.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_enable_btns.Location = new System.Drawing.Point(91, 271);
            this.cb_enable_btns.Name = "cb_enable_btns";
            this.cb_enable_btns.Size = new System.Drawing.Size(271, 34);
            this.cb_enable_btns.TabIndex = 27;
            this.cb_enable_btns.Text = "HABILITAR CONTROLES";
            this.cb_enable_btns.UseVisualStyleBackColor = false;
            this.cb_enable_btns.CheckedChanged += new System.EventHandler(this.cb_enable_btns_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.creditosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 33);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarListaToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // carregarListaToolStripMenuItem
            // 
            this.carregarListaToolStripMenuItem.Name = "carregarListaToolStripMenuItem";
            this.carregarListaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.carregarListaToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.carregarListaToolStripMenuItem.Text = "Carregar lista";
            this.carregarListaToolStripMenuItem.Click += new System.EventHandler(this.carregarListaToolStripMenuItem_Click);
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem1});
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.creditosToolStripMenuItem.Text = "&Sobre";
            // 
            // creditosToolStripMenuItem1
            // 
            this.creditosToolStripMenuItem1.Name = "creditosToolStripMenuItem1";
            this.creditosToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.creditosToolStripMenuItem1.Text = "&Creditos";
            this.creditosToolStripMenuItem1.Click += new System.EventHandler(this.creditosToolStripMenuItem1_Click);
            // 
            // tb_instrucoes
            // 
            this.tb_instrucoes.Location = new System.Drawing.Point(74, 85);
            this.tb_instrucoes.Multiline = true;
            this.tb_instrucoes.Name = "tb_instrucoes";
            this.tb_instrucoes.ReadOnly = true;
            this.tb_instrucoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_instrucoes.Size = new System.Drawing.Size(169, 99);
            this.tb_instrucoes.TabIndex = 55;
            // 
            // lb_instrucoes
            // 
            this.lb_instrucoes.AutoSize = true;
            this.lb_instrucoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_instrucoes.Location = new System.Drawing.Point(73, 59);
            this.lb_instrucoes.Name = "lb_instrucoes";
            this.lb_instrucoes.Size = new System.Drawing.Size(133, 32);
            this.lb_instrucoes.TabIndex = 56;
            this.lb_instrucoes.Text = "Instruções";
            // 
            // tb_X
            // 
            this.tb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_X.Location = new System.Drawing.Point(180, 190);
            this.tb_X.Name = "tb_X";
            this.tb_X.ReadOnly = true;
            this.tb_X.Size = new System.Drawing.Size(51, 31);
            this.tb_X.TabIndex = 58;
            this.tb_X.Text = "0";
            this.tb_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Y
            // 
            this.tb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Y.Location = new System.Drawing.Point(100, 190);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.ReadOnly = true;
            this.tb_Y.Size = new System.Drawing.Size(51, 31);
            this.tb_Y.TabIndex = 59;
            this.tb_Y.Text = "0";
            this.tb_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_X
            // 
            this.lb_X.AutoSize = true;
            this.lb_X.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_X.Location = new System.Drawing.Point(157, 197);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(27, 25);
            this.lb_X.TabIndex = 60;
            this.lb_X.Text = "X:";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Y.Location = new System.Drawing.Point(77, 197);
            this.lb_Y.Name = "lb_Y";
            this.lb_Y.Size = new System.Drawing.Size(26, 25);
            this.lb_Y.TabIndex = 61;
            this.lb_Y.Text = "Y:";
            // 
            // tb_interval
            // 
            this.tb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_interval.Location = new System.Drawing.Point(26, 561);
            this.tb_interval.Name = "tb_interval";
            this.tb_interval.Size = new System.Drawing.Size(51, 31);
            this.tb_interval.TabIndex = 62;
            this.tb_interval.Text = "0";
            this.tb_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_interval
            // 
            this.lb_interval.AutoSize = true;
            this.lb_interval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_interval.Location = new System.Drawing.Point(362, 567);
            this.lb_interval.Name = "lb_interval";
            this.lb_interval.Size = new System.Drawing.Size(81, 25);
            this.lb_interval.TabIndex = 63;
            this.lb_interval.Text = "Intervalo";
            // 
            // tb_repete
            // 
            this.tb_repete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_repete.Location = new System.Drawing.Point(374, 527);
            this.tb_repete.Name = "tb_repete";
            this.tb_repete.Size = new System.Drawing.Size(51, 31);
            this.tb_repete.TabIndex = 57;
            this.tb_repete.Text = "0";
            this.tb_repete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 643);
            this.Controls.Add(this.tb_instrucoes);
            this.Controls.Add(this.lb_instrucoes);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(860, 393);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Auto Clicker ATLAS v4";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_restante;
        private System.Windows.Forms.TextBox tb_instrucoes;
        private System.Windows.Forms.Label lb_instrucoes;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Label lb_X;
        private System.Windows.Forms.Label lb_Y;
        private System.Windows.Forms.TextBox tb_interval;
        private System.Windows.Forms.Label lb_interval;
        private System.Windows.Forms.TextBox tb_repete;
    }
}

