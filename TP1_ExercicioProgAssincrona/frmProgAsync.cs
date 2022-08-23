using System.Diagnostics;

namespace TP1_ExercicioProgAssincrona
{
    public partial class frmProgAsync : Form
    {
        private decimal salario;
        public frmProgAsync()
        {
            InitializeComponent();
        }

        private void frmProgAsync_Load(object sender, EventArgs e)
        {


        }

        private async Task FolhaPagameto()
        {
            ltbResultados.Items.Add("Calculando Folha de Pagamentos...");
            Random rnd = new Random();
            salario = rnd.Next(1500, 10000);
            await Task.Delay(2000);
            ltbResultados.Items[0] = $"Folha de pagamento: R$ {salario.ToString("0.00")}";
        }
        private async Task Impostos()
        {
            ltbResultados.Items.Add("Calculando Impostos...");
            decimal imposto = salario * 0.15m;
            await Task.Delay(5000);
            ltbResultados.Items[1] = $"Imposto: R$ {imposto.ToString("0.00")}";
        }
        private async Task Receitas()
        {
            ltbResultados.Items.Add("Calculando Receitas...");
            decimal plr = salario * 0.2m;
            decimal receitas = salario + plr;
            await Task.Delay(3000);
            ltbResultados.Items[2] = $"Receitas: R$ {receitas.ToString("0.00")}";
        }
        private async Task Despesas()
        {
            ltbResultados.Items.Add("Calculando Despesas...");
            Random rnd = new Random();
            decimal despesas = rnd.Next(800, 3000);
            await Task.Delay(2500);
            ltbResultados.Items[3] = $"Despesas: R$ {despesas.ToString("0.00")}";
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            pgbCalculos.Maximum = 5000;
            pgbCalculos.Value = 0;
            timer1.Enabled = true;
            timer1.Start();
            ltbResultados.Items.Clear();
            btnCalculate.Enabled = false;
            lblStatus.Text = "Realizando cálculos. Aguarde os cálculos finalizarem...";
            lblStatus.ForeColor = Color.Red;
            lblTempo.Hide();

            var task1 = FolhaPagameto();
            var task2 = Impostos();
            var task3 = Receitas();
            var task4 = Despesas();

            await task1;
            await task2;
            await task3;
            await task4;

            stopwatch.Stop();

            btnCalculate.Enabled = true;
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = @"Cálculo finalizado.
Clique em calcular para executar novo cálculo.";
            pgbCalculos.Value = 0;
            timer1.Stop();
            lblTempo.Text = $"Todo o processo durou: {stopwatch.ElapsedMilliseconds} ms";
            lblTempo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbCalculos.Value += 1000;
        }
    }

}