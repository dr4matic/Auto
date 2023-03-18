namespace AutoParts
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void PushButton_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(LoginBox.Text) 
                || string.IsNullOrWhiteSpace(PasswordBox.Text)) 
            {
                MessageBox.Show("че нить напиши");
                return;
            }

            List<string> log = new() { "a", "b", "c" };
            List<string> pass = new() { "a", "b", "c" };

            if (log.Contains(LoginBox.Text) && pass.Contains(PasswordBox.Text))
            {
                LoginBox.Text = string.Empty;
                PasswordBox.Text = string.Empty;
            }

            
            
        }

        private void PushToRegistrtion_Click(object sender, EventArgs e)
        {
            Program.context.MainForm = new RegistrationForm();
            Program.context.MainForm.Show();
            this.Close();
        }
    }
}