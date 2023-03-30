namespace Tibia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string nomeChar = txtNomeChar.Text;

            string nomeDir = selecionarDir.SelectedPath;

            DirectoryInfo dir = new DirectoryInfo(nomeDir);

            foreach (FileInfo file in dir.GetFiles("*.dat", SearchOption.AllDirectories))
            {
                string content = File.ReadAllText(file.FullName);

                if (content.Contains(nomeChar))
                {
                    MessageBox.Show($@"Conteudo do arquivo: {content}");
                }
            }

            MessageBox.Show("FIM!!");


        }

        private void btnSelecionaDir_Click(object sender, EventArgs e)
        {
            selecionarDir.ShowDialog();
            string nomeDir = selecionarDir.SelectedPath;
            txtDirSelecionado.Text = nomeDir;
        }
    }
}