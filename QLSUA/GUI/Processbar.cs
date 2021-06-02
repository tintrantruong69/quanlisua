using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmProcessbar : Form
    {
        public frmProcessbar()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProcessbar_Load(object sender, EventArgs e)
        {
            pnlProcess.Width = 0;
            lblLoading.Visible = false;
           
        }

        private async void btnPower_Click(object sender, EventArgs e)
        {
            if (btnPower.Text == "Done")
            {
                frmMain m = new frmMain();
                m.ShowDialog();
                this.Close();

            }
            lblLoading.Visible = true;
            lblPercent.Visible = false;
            tmPercent.Enabled = !tmPercent.Enabled;
            btnPower.Text = btnPower.Text == "Stop" ? "Start" : "Stop";
            if(btnPower.Text =="Start")
            {
                pnlProcess.Width = 0;
                lblLoading.Visible = false;
                lblPercent.Visible = false;
                pnlProcess.Visible = false;

            }    
            else if(btnPower.Text =="Stop")
            {
                lblLoading.Visible = true;
                lblPercent.Visible = true;
                pnlProcess.Visible = true;
                for (int i = 0; i < 509; i++)
                {
                    if (lblLoading.Text != "Loading...")
                    {
                        lblLoading.Text += ".";
                    }
                    else
                    {
                        lblLoading.Text = "Loading";
                    }
                    pnlProcess.Width += 1;
                    await Task.Delay(10);
                }
            } 
         
        }
        int i = 0;
        private void tmPercent_Tick(object sender, EventArgs e)
        {
            if(i<100)
            {
                i++;
                lblPercent.Text = i.ToString() + "%";

            }  
            else
            {
                lblPercent.Text = "100%";
                lblLoading.Text = "Completed";
                btnPower.Text = "Done";
            }    
        }
    }
}
