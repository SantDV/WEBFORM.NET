using NET2U4_3_BLL;

namespace NET2U4_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHolaMundo_Click(object sender, EventArgs e)
        {
            txtHolaMundo.Text = BHolaMundo.HolaMundo(); 
        }
    }
}