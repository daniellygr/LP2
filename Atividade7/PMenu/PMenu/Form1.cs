using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou ctrl+c");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou ctrl+v");
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this; //PARA APARECER NO "PAI"
            objFrm2.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objFrm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this; //PARA APARECER NO "PAI"
            objFrm3.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objFrm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this; //PARA APARECER NO "PAI"
            objFrm4.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objFrm4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 objFrm5 = new frmExercicio5();
            objFrm5.MdiParent = this; //PARA APARECER NO "PAI"
            objFrm5.WindowState = FormWindowState.Maximized; //PARA MAXIMIZAR
            objFrm5.Show();
        }
    }
}
