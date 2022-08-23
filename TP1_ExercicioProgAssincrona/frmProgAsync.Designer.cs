namespace TP1_ExercicioProgAssincrona
{
    partial class frmProgAsync
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
            this.components = new System.ComponentModel.Container();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pgbCalculos = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbResultados
            // 
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 15;
            this.ltbResultados.Location = new System.Drawing.Point(67, 31);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(464, 109);
            this.ltbResultados.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(67, 177);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(209, 48);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(67, 254);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(310, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Clique em calcular para executar programa";
            // 
            // pgbCalculos
            // 
            this.pgbCalculos.Location = new System.Drawing.Point(67, 313);
            this.pgbCalculos.Name = "pgbCalculos";
            this.pgbCalculos.Size = new System.Drawing.Size(464, 23);
            this.pgbCalculos.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTempo.Location = new System.Drawing.Point(72, 348);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 23);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.UseCompatibleTextRendering = true;
            // 
            // frmProgAsync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 389);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.pgbCalculos);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ltbResultados);
            this.Name = "frmProgAsync";
            this.Text = "Exercício Programação Assíncrona";
            this.Load += new System.EventHandler(this.frmProgAsync_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ltbResultados;
        private Button btnCalculate;
        private Label lblStatus;
        private ProgressBar pgbCalculos;
        private System.Windows.Forms.Timer timer1;
        private Label lblTempo;
    }
}