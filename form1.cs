using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

　
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //textBox1.Text = "c:\\teste\\appoio.exe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arqB64 = textBox2.Text;
            string arqOri = textBox1.Text;

            if (arqB64 == "" || arqOri == "")
            {
                MessageBox.Show("Preencher nomes dos arquivos!");
                return;
            }

            if (System.IO.File.Exists(arqOri))
            {

                byte[] objByte = File.ReadAllBytes(arqOri);

                string arquivo = Convert.ToBase64String(objByte);

                File.WriteAllText(arqB64, arquivo);
                    
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string arqB64 = textBox2.Text;
            string arqOri = textBox1.Text;

            if (arqB64 == "" || arqOri == "")
            {
                MessageBox.Show("Preencher nomes dos arquivos!");
                return;
            }

            if (System.IO.File.Exists(arqB64))
            {

　
                string arquivo = File.ReadAllText(arqB64);

                byte[] objByte = Convert.FromBase64String(arquivo);

                File.WriteAllBytes(arqOri, objByte);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
