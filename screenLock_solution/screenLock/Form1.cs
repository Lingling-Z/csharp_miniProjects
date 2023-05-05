namespace screenLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deltX = 10;
        int deltY = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Left += deltX;
            this.label1.Top += deltY;
            if(this.label1.Top > this.Height || this.label1.Bottom < 0)
            {
                deltY = -deltY;
            }
            if(this.label1.Left < 0 || this.label1.Right > this.Width) 
            { 
                deltX= -deltX;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}