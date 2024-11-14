namespace SimuladorGravitacional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continuar alguma simulação!");

            //criar uma instancia do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //definir o filtro para aceitar apenas arquivos .txt
            openFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";

            //abrir a janela de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //obter o caminho
                string caminhoArquivo = openFileDialog.FileName;

                //exibir o caminho do arquivo selecionado
                MessageBox.Show("Arquivo selecionado: " + caminhoArquivo);

                //adicionar logica aqui para abrir o arquivo
                Parametros NewPar = new Parametros(caminhoArquivo);
                SimForm ContinueSim = new SimForm();
                ContinueSim.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum arquivo selecionado.");
            }
        }

        private void btnNewSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciar nova simulação!");
            //cria uma nova instancia do NewSimForm(tela contem os input pra aplicacao)
            NewSimForm novaSimulacao = new NewSimForm();

            //exibe o novo formulario
            novaSimulacao.Show();

            //Oculta a tela inicial para focar na nova tela
            this.Hide();
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            //ao clicar fecha aplicacao
            Application.Exit();
        }
    }
}
