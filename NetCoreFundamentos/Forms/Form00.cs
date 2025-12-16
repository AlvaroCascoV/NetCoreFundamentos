namespace NetCoreFundamentos
{
    public partial class Form00 : Form
    {
        public Form00()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!!";
            this.txtNombre.Width = 220;
            this.txtNombre.BackColor = Color.Fuchsia;
            //NO ES CONVERSION AUTOMATICA 
            //int mayor = 88;
            //short pequeño = mayor;

            //SI ES CONVERSION AUTOMATICA 
            //short pequeño = 88;
            //int mayor = pequeño;

            //STRING A PRIMITIVO
            //string textoNumero = "888";
            //int numero = int.Parse(textoNumero);
            //double otro = double.Parse(textoNumero);

            //CASTING
            int mayor = 88;
            short pequeño = (short)mayor;

            //TOSTRING
            string dato = pequeño.ToString();
            dato = this.btnPulsar.ToString();
        }
    }
}
