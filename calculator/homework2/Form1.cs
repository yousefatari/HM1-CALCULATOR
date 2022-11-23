namespace homework2


	
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationperformed = "";
        bool issoperationperformed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txbDisplayResult.Text = "0";

        }

        private void button_click(object sender, EventArgs e)
        {
            if (txbDisplayResult.Text == "0" || (issoperationperformed))
            
                txbDisplayResult.Clear();

            issoperationperformed = false;
            
            Button button = (Button)sender;
         
            if(button.Text == ".")
            {
                if (!txbDisplayResult.Text.Contains("."))
                    txbDisplayResult.Text += button.Text;

            }
            else
            {
                txbDisplayResult.Text += button.Text;

            }


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultvalue=double.Parse(txbDisplayResult.Text);
            lblcurrentop.Text = resultvalue +"" + operationperformed;
            issoperationperformed= true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txbDisplayResult.Text = "0";
            resultvalue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (operationperformed == "+")
            {
                txbDisplayResult.Text =( resultvalue + double.Parse(txbDisplayResult.Text)).ToString();
            }
            else if (operationperformed =="-")
            {
                txbDisplayResult.Text = (resultvalue - double.Parse(txbDisplayResult.Text)).ToString();

            }
            else if (operationperformed =="X")
            {
                txbDisplayResult.Text = (resultvalue * double.Parse(txbDisplayResult.Text)).ToString();

            }

            else 
            {
                txbDisplayResult.Text =( resultvalue / double.Parse(txbDisplayResult.Text)).ToString();

            }





        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txbDisplayResult.Text.Length > 0)
                txbDisplayResult.Text = txbDisplayResult.Text.Remove(txbDisplayResult.Text.Length - 1, 1);

            if (txbDisplayResult.Text == " ") 
                txbDisplayResult.Text = "0";
        }
    }
}