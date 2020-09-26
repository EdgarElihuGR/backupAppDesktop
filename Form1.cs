using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backupAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Abrir dialogo para abrir archivo
        private void sync_Click(object sender, EventArgs e)
        {
            
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            //Muestra dialogo
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var folderName = folderBrowserDialog1.SelectedPath;
                MessageBox.Show(folderName);
            }
        }
    }
}
