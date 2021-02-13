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

namespace MeuBlocoDeNotas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarOk(object sender, CancelEventArgs e)
        {
            string Caminho = saveFileDialog1.FileName;
            File.WriteAllText(Caminho, txbJanela.Text);
        }

        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
