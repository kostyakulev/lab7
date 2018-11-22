using System;
using System.Windows.Forms;

namespace _6ProgressBar {
    public partial class Form1 : Form {
        public Form1() => InitializeComponent();

        private void btnEnter_Click(object sender, EventArgs e) {
            try {
                var value = Convert.ToInt32(textBox1.Text);
                progressBar1.Value = value > progressBar1.Maximum ? progressBar1.Maximum : value;
            } catch (Exception) {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            for (var i = 0; i < 30000; i++)
                progressBar1.Value = i;
        }
    }
}
