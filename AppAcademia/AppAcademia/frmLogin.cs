namespace AppAcademia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnENTRAR_Click(object sender, EventArgs e)
        {
            string usuario = "Nataí";
            string senha = "123";

            if (txtUsuario.Text == usuario && txtSenha.Text == senha)
            {
                MessageBox.Show("Logado com Sucesso!");
                frmMenu FM = new frmMenu();
                FM.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos. Tente Novamente!");
            }
        }

        private void lblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro fc = new frmCadastro();
            fc.ShowDialog();
        }
    }
}
