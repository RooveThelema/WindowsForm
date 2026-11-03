namespace lesson1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void btnNumberAction_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            bool isWriteComma = false;



            if (btn.Text == "," && txtDisplay.Text.Contains(","))
            {
                return;
            }
            txtDisplay.Text += btn.Text;


        }

        private void btnNumberActionClear(object sender, EventArgs e)
        {
            txtDisplay.Text = String.Empty;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
