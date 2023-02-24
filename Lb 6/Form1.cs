namespace Lb_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            {
                
                if (pct.Left + pct.Width + 20 > this.ClientSize.Width)
                {
                    tmr.Enabled = true;
                    
                }
                else
                {
                    
                    pct.Left += 20;
                    
                    

                }
                

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            tmr.Enabled = !tmr.Enabled;
            btnStart.Text = tmr.Enabled ? "Стоп" : "Старт";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}