using System;
using System.Windows.Forms;

namespace TrocaDeValores {
    public partial class frmTrocaDeValores : Form {

        public frmTrocaDeValores() {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) {
            string auxiliar;

            auxiliar = valor1.Text;
            valor1.Text = valor2.Text;
            valor2.Text = auxiliar;

            MessageBox.Show("Troca de Valores Concluida", "Informação",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

    }
}
