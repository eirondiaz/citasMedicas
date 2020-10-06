using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace citasMedicas
{
    public partial class Form1 : Form
    {
        Mantenimientos mant = new Mantenimientos();
        Procesos procs = new Procesos();
        Consultas cons = new Consultas();
        Utilitarios utl = new Utilitarios();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picSalir_MouseMove(object sender, MouseEventArgs e)
        {
            picSalir.BackColor = Color.FromArgb(45, 142, 146);
        }

        private void picSalir_MouseLeave(object sender, EventArgs e)
        {
            picSalir.BackColor = Color.FromArgb(0, 169, 176);
        }

        private void picMin_MouseMove(object sender, MouseEventArgs e)
        {
            picMin.BackColor = Color.FromArgb(45, 142, 146);
        }

        private void picMin_MouseLeave(object sender, EventArgs e)
        {
            picMin.BackColor = Color.FromArgb(0, 169, 176);
        }

        private void btnManten_Click(object sender, EventArgs e)
        {
            plCons.Visible = false;
            plProc.Visible = false;
            plUtl.Visible = false;
            plMan.Visible = true;

            mant.MdiParent = this;
            procs.Hide();
            cons.Hide();
            utl.Hide();
            mant.Show();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            plCons.Visible = false;
            plUtl.Visible = false;
            plMan.Visible = false;
            plProc.Visible = true;

            procs.MdiParent = this;
            cons.Hide();
            utl.Hide();
            mant.Hide();
            procs.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            plUtl.Visible = false;
            plMan.Visible = false;
            plProc.Visible = false;
            plCons.Visible = true;

            cons.MdiParent = this;
            procs.Hide();
            utl.Hide();
            mant.Hide();
            cons.Show();
        }

        private void btnUtilitarios_Click(object sender, EventArgs e)
        {
            plCons.Visible = false;
            plMan.Visible = false;
            plProc.Visible = false;
            plUtl.Visible = true;

            utl.MdiParent = this;
            procs.Hide();
            cons.Hide();
            mant.Hide();
            utl.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
