using System.Diagnostics;
using System.Numerics;

namespace EncriptadorGrafico
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void input_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                Encriptacio myObj_encryptacio = new(input_text.Text, (int)rotacion.Value);
                result_tbox.Text = myObj_encryptacio.crypt();

        }

        private void input_text_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rotacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            Encriptacio myObj_encryptacio = new(input_text.Text, (int)rotacion.Value);
            result_tbox.Text = myObj_encryptacio.decripter();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/j0rd1s3rr4n0",
                UseShellExecute = true
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}