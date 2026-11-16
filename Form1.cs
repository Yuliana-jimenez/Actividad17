namespace Actividad17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btmActualizar_Click(object sender, EventArgs e)
        {
            var tanque = new Tanque(
                (int)numNivel.Value,
                (int)numTemperatura.Value);

            lblNivelActual.Text = $"Nivel: {tanque.Nivel} %";
            lblTemperaturaActual.Text = $"Temperatura: {tanque.Temperatura} °C";
            prgNivel.Value = tanque.Nivel;
            lblEstado.Text = tanque.ObtenerEstado();
            lblEstado.BackColor = tanque.TieneAlerta
                ? Color.FromArgb(254, 243, 199)
                : Color.FromArgb(220, 252, 231);
        }

        private void grpEntradas_Enter(object sender, EventArgs e)
        {
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            numNivel.Value = 65;
            numTemperatura.Value = 28;
            lblNivelActual.Text = "Nivel: sin lectura";
            lblTemperaturaActual.Text = "Temperatura: sin lectura";
            prgNivel.Value = 0;
            lblEstado.Text = "SIN LECTURA";
            lblEstado.BackColor = Color.FromArgb(233, 238, 245);
            numNivel.Focus();
        }
    }
}