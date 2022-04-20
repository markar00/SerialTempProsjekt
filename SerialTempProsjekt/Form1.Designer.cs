namespace SerialTempProsjekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopp = new System.Windows.Forms.Button();
            this.cbSeriellePorter = new System.Windows.Forms.ComboBox();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.btnRydd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtEnMelding = new System.Windows.Forms.TextBox();
            this.lbHistorikk = new System.Windows.Forms.ListBox();
            this.txtTMin = new System.Windows.Forms.TextBox();
            this.txtTMaks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tDeltaT = new System.Windows.Forms.Timer(this.components);
            this.txtTSnitt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(754, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Laveste temp. :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(754, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Høyeste temp. :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStopp
            // 
            this.btnStopp.Location = new System.Drawing.Point(371, 33);
            this.btnStopp.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopp.Name = "btnStopp";
            this.btnStopp.Size = new System.Drawing.Size(108, 28);
            this.btnStopp.TabIndex = 19;
            this.btnStopp.Text = "Stopp";
            this.btnStopp.UseVisualStyleBackColor = true;
            this.btnStopp.Click += new System.EventHandler(this.btnStopp_Click);
            // 
            // cbSeriellePorter
            // 
            this.cbSeriellePorter.FormattingEnabled = true;
            this.cbSeriellePorter.Location = new System.Drawing.Point(181, 35);
            this.cbSeriellePorter.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeriellePorter.Name = "cbSeriellePorter";
            this.cbSeriellePorter.Size = new System.Drawing.Size(160, 24);
            this.cbSeriellePorter.TabIndex = 18;
            this.cbSeriellePorter.SelectedIndexChanged += new System.EventHandler(this.cbSeriellePorter_SelectedIndexChanged);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(621, 33);
            this.btnAvslutt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(127, 28);
            this.btnAvslutt.TabIndex = 17;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // btnRydd
            // 
            this.btnRydd.Location = new System.Drawing.Point(499, 33);
            this.btnRydd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRydd.Name = "btnRydd";
            this.btnRydd.Size = new System.Drawing.Size(112, 28);
            this.btnRydd.TabIndex = 16;
            this.btnRydd.Text = "Fjern Tekst";
            this.btnRydd.UseVisualStyleBackColor = true;
            this.btnRydd.Click += new System.EventHandler(this.btnRydd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(53, 33);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 28);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtEnMelding
            // 
            this.txtEnMelding.Location = new System.Drawing.Point(53, 77);
            this.txtEnMelding.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnMelding.Name = "txtEnMelding";
            this.txtEnMelding.Size = new System.Drawing.Size(693, 22);
            this.txtEnMelding.TabIndex = 14;
            this.txtEnMelding.TextChanged += new System.EventHandler(this.txtEnMelding_TextChanged);
            // 
            // lbHistorikk
            // 
            this.lbHistorikk.FormattingEnabled = true;
            this.lbHistorikk.ItemHeight = 16;
            this.lbHistorikk.Location = new System.Drawing.Point(53, 118);
            this.lbHistorikk.Margin = new System.Windows.Forms.Padding(4);
            this.lbHistorikk.Name = "lbHistorikk";
            this.lbHistorikk.Size = new System.Drawing.Size(693, 260);
            this.lbHistorikk.TabIndex = 13;
            this.lbHistorikk.SelectedIndexChanged += new System.EventHandler(this.lbHistorikk_SelectedIndexChanged);
            // 
            // txtTMin
            // 
            this.txtTMin.Location = new System.Drawing.Point(862, 148);
            this.txtTMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTMin.Name = "txtTMin";
            this.txtTMin.Size = new System.Drawing.Size(79, 22);
            this.txtTMin.TabIndex = 12;
            this.txtTMin.TextChanged += new System.EventHandler(this.txtTMin_TextChanged);
            // 
            // txtTMaks
            // 
            this.txtTMaks.Location = new System.Drawing.Point(862, 115);
            this.txtTMaks.Margin = new System.Windows.Forms.Padding(4);
            this.txtTMaks.Name = "txtTMaks";
            this.txtTMaks.Size = new System.Drawing.Size(79, 22);
            this.txtTMaks.TabIndex = 11;
            this.txtTMaks.TextChanged += new System.EventHandler(this.txtTMaks_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(754, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Snitt temp. :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tDeltaT
            // 
            this.tDeltaT.Interval = 1000;
            this.tDeltaT.Tick += new System.EventHandler(this.tDeltaT_Tick);
            // 
            // txtTSnitt
            // 
            this.txtTSnitt.Location = new System.Drawing.Point(862, 220);
            this.txtTSnitt.Name = "txtTSnitt";
            this.txtTSnitt.Size = new System.Drawing.Size(79, 22);
            this.txtTSnitt.TabIndex = 23;
            this.txtTSnitt.TextChanged += new System.EventHandler(this.txtTSnitt_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(754, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Temp nå. :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTSnitt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopp);
            this.Controls.Add(this.cbSeriellePorter);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnRydd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtEnMelding);
            this.Controls.Add(this.lbHistorikk);
            this.Controls.Add(this.txtTMin);
            this.Controls.Add(this.txtTMaks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopp;
        private System.Windows.Forms.ComboBox cbSeriellePorter;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.Button btnRydd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtEnMelding;
        private System.Windows.Forms.ListBox lbHistorikk;
        private System.Windows.Forms.TextBox txtTMin;
        private System.Windows.Forms.TextBox txtTMaks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tDeltaT;
        private System.Windows.Forms.TextBox txtTSnitt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

