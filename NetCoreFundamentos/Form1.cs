namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!!";
            this.txtNombre.Width = 220;
            this.txtNombre.BackColor = Color.Fuchsia;
        }
    }
}
