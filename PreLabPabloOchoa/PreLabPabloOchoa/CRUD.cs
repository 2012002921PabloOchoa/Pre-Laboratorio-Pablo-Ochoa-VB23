namespace PreLabPabloOchoa
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "123456789")
            {
                Form1 v1 = new Form1();
                v1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
        }
    }
}
