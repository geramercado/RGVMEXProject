using System;
using System.Windows.Forms;

namespace RGVMEXProyect
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }
        public void abrirFormHijo(object frmHijo)
        {
            if (Contenedor.Controls.Count >= 0)
            {
                Contenedor.Controls.Clear();
                Form frm = frmHijo as Form;
                frm.TopLevel = false;
                frm.Dock= DockStyle.Fill;
                Contenedor.Controls.Add(frm);
                Contenedor.Tag = frm;
                frm.Show();
            }
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Form2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Form3());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
