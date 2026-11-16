namespace Actividad17
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
            lbltitulo = new Label();
            lblsubtitulo = new Label();
            grpEntradas = new GroupBox();
            btnReiniciar = new Button();
            btmActualizar = new Button();
            numTemperatura = new NumericUpDown();
            numNivel = new NumericUpDown();
            lblTempEntrada = new Label();
            lblNivelEntrada = new Label();
            grplectura = new GroupBox();
            prgNivel = new ProgressBar();
            lblEstado = new Label();
            lblTemperaturaActual = new Label();
            lblNivelActual = new Label();
            grpEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNivel).BeginInit();
            grplectura.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(26, 22);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(463, 60);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Monitoreo de tanque";
            // 
            // lblsubtitulo
            // 
            lblsubtitulo.AutoSize = true;
            lblsubtitulo.BackColor = Color.Transparent;
            lblsubtitulo.ForeColor = Color.Black;
            lblsubtitulo.Location = new Point(34, 82);
            lblsubtitulo.Name = "lblsubtitulo";
            lblsubtitulo.Size = new Size(312, 28);
            lblsubtitulo.TabIndex = 1;
            lblsubtitulo.Text = "Lecturas simuladas para la práctica";
            // 
            // grpEntradas
            // 
            grpEntradas.Controls.Add(btnReiniciar);
            grpEntradas.Controls.Add(btmActualizar);
            grpEntradas.Controls.Add(numTemperatura);
            grpEntradas.Controls.Add(numNivel);
            grpEntradas.Controls.Add(lblTempEntrada);
            grpEntradas.Controls.Add(lblNivelEntrada);
            grpEntradas.Location = new Point(22, 116);
            grpEntradas.Name = "grpEntradas";
            grpEntradas.Size = new Size(339, 307);
            grpEntradas.TabIndex = 2;
            grpEntradas.TabStop = false;
            grpEntradas.Text = "Captura de mediciones";
            grpEntradas.Enter += grpEntradas_Enter;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.White;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnReiniciar.Location = new Point(197, 217);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(125, 45);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btmActualizar
            // 
            btmActualizar.BackColor = Color.Black;
            btmActualizar.FlatAppearance.BorderSize = 0;
            btmActualizar.FlatStyle = FlatStyle.Flat;
            btmActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmActualizar.ForeColor = Color.GhostWhite;
            btmActualizar.Location = new Point(18, 217);
            btmActualizar.Name = "btmActualizar";
            btmActualizar.Size = new Size(158, 45);
            btmActualizar.TabIndex = 2;
            btmActualizar.Tag = "";
            btmActualizar.Text = "Actualizar";
            btmActualizar.UseVisualStyleBackColor = false;
            btmActualizar.Click += btmActualizar_Click;
            // 
            // numTemperatura
            // 
            numTemperatura.Location = new Point(18, 150);
            numTemperatura.Name = "numTemperatura";
            numTemperatura.Size = new Size(295, 34);
            numTemperatura.TabIndex = 1;
            numTemperatura.Value = new decimal(new int[] { 28, 0, 0, 0 });
            // 
            // numNivel
            // 
            numNivel.Location = new Point(18, 69);
            numNivel.Name = "numNivel";
            numNivel.Size = new Size(295, 34);
            numNivel.TabIndex = 0;
            numNivel.Value = new decimal(new int[] { 65, 0, 0, 0 });
            // 
            // lblTempEntrada
            // 
            lblTempEntrada.AutoSize = true;
            lblTempEntrada.Location = new Point(18, 122);
            lblTempEntrada.Name = "lblTempEntrada";
            lblTempEntrada.Size = new Size(158, 28);
            lblTempEntrada.TabIndex = 0;
            lblTempEntrada.Text = "Temperatura (°C)";
            // 
            // lblNivelEntrada
            // 
            lblNivelEntrada.AutoSize = true;
            lblNivelEntrada.Location = new Point(18, 41);
            lblNivelEntrada.Name = "lblNivelEntrada";
            lblNivelEntrada.Size = new Size(189, 28);
            lblNivelEntrada.TabIndex = 0;
            lblNivelEntrada.Text = "Nivel del Tanque (%)";
            // 
            // grplectura
            // 
            grplectura.Controls.Add(prgNivel);
            grplectura.Controls.Add(lblEstado);
            grplectura.Controls.Add(lblTemperaturaActual);
            grplectura.Controls.Add(lblNivelActual);
            grplectura.Location = new Point(387, 116);
            grplectura.Name = "grplectura";
            grplectura.Size = new Size(502, 307);
            grplectura.TabIndex = 3;
            grplectura.TabStop = false;
            grplectura.Text = "Última Lectura";
            // 
            // prgNivel
            // 
            prgNivel.Location = new Point(18, 78);
            prgNivel.Name = "prgNivel";
            prgNivel.Size = new Size(466, 22);
            prgNivel.Style = ProgressBarStyle.Continuous;
            prgNivel.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(18, 195);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(124, 33);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Sin lectura";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTemperaturaActual
            // 
            lblTemperaturaActual.AutoSize = true;
            lblTemperaturaActual.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTemperaturaActual.Location = new Point(18, 147);
            lblTemperaturaActual.Name = "lblTemperaturaActual";
            lblTemperaturaActual.Size = new Size(347, 39);
            lblTemperaturaActual.TabIndex = 1;
            lblTemperaturaActual.Text = "Temperatura sin lectura";
            // 
            // lblNivelActual
            // 
            lblNivelActual.AutoSize = true;
            lblNivelActual.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNivelActual.Location = new Point(18, 39);
            lblNivelActual.Name = "lblNivelActual";
            lblNivelActual.Size = new Size(242, 39);
            lblNivelActual.TabIndex = 0;
            lblNivelActual.Text = "Nivel sin lectura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1073, 812);
            Controls.Add(grplectura);
            Controls.Add(grpEntradas);
            Controls.Add(lblsubtitulo);
            Controls.Add(lbltitulo);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.DarkSlateBlue;
            MinimumSize = new Size(850, 450);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpEntradas.ResumeLayout(false);
            grpEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNivel).EndInit();
            grplectura.ResumeLayout(false);
            grplectura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblsubtitulo;
        private GroupBox grpEntradas;
        private GroupBox grplectura;
        private Label lblNivelEntrada;
        private Button btnReiniciar;
        private Button btmActualizar;
        private NumericUpDown numTemperatura;
        private NumericUpDown numNivel;
        private Label lblTempEntrada;
        private ProgressBar prgNivel;
        private Label lblEstado;
        private Label lblTemperaturaActual;
        private Label lblNivelActual;
    }
}
