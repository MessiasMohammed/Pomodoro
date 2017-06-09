using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Tarefas : Form
    {
        int contUM = 0, contDois = 0;
        int min, seg, mil;
        public Tarefas()
        {
            InitializeComponent();
        }

        private void temp(object sender, EventArgs e)
        {
            contUM++;
            min = (contUM / 3600);
            if (min >= 1)
            {
                tempo.Stop();
                contUM = 0;
                contDois = 0;
                lbltempo.Text = contUM.ToString() + "0:00:00";
                btniniciar.Text = "iniciar";

            }
            seg = (contUM % 3600) / 60;
            mil = (contUM % 3600) % 60;
            lbltempo.Text = string.Format("{0:#,0#}:{1:#,0#}:{2:#,0#}:", min, seg, mil);


        }

        private void iniciar(object sender, EventArgs e)
        {

            contDois++;
            if (contDois % 2 == 1)
            {

                tempo.Start();
                btniniciar.Text = "Pausar";
               
            }
            

            else

            {

                tempo.Dispose();
                btniniciar.Text = "iniciar";
            }
                
            }

        

        private void button1_Click(object sender, EventArgs e)
        {
            tempo.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
