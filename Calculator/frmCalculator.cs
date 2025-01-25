namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        float num1;
        float num2;
        string inputNum = "";

        public void showInput()
        {
            string displayInput = "";
            bool decimalFound = false;
            for (int i = 0; i < inputNum.Length; i++)
            {
                displayInput += inputNum[i];

                if (inputNum[i] == '.')
                {
                    decimalFound = true;
                }
                if ((i + 1) % 3 == 0 && i != inputNum.Length - 1 && decimalFound == false)
                {
                    displayInput += " ";
                }
            }

            lblAnswer.Text = displayInput;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if ((inputNum.Length < 12) && (inputNum.Length >= 1))
            {
                inputNum += "0";
                showInput();
            }

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "1";
                showInput();
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "2";
                showInput();
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "3";
                showInput();
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "4";
                showInput();
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "5";
                showInput();
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "6";
                showInput();
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "7";
                showInput();
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "8";
                showInput();
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (inputNum.Length < 12)
            {
                inputNum += "9";
                showInput();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int length = inputNum.Length;
            try
            {
                if (length > 0)
                {
                    inputNum = inputNum.Substring(0, length - 1);
                    if (inputNum == "-0")
                    {
                        inputNum = "0";
                    }
                    showInput();
                }
                else
                {
                    lblAnswer.Text = "0";
                }


            }
            catch (Exception)
            {


            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (inputNum.Length == 0 || inputNum == "0")
            {
                inputNum = "0.";
                showInput();
            }
            else if (!inputNum.Contains('.') && inputNum.Length < 12)
            {
                inputNum += ".";
                showInput();
            }

        }

        private void btnSignChange_Click(object sender, EventArgs e)
        {
            int length = inputNum.Length;
            if (inputNum.Contains("-"))
            {
                inputNum = inputNum.Substring(1, length - 1);
                showInput();
            }
            else
            {
                if (inputNum == "0" || inputNum == "")
                {
                    inputNum = "0";
                }
                else
                {
                    inputNum = inputNum.Insert(0, "-");
                }

                showInput();
            }
        }


        //Keyboard buttons
        private void frmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessKeyPress(e.KeyCode);
        }

        void ProcessKeyPress(Keys keyPressed)
        {
            switch (keyPressed)
            {
                case Keys.D0:
                   
                    break;
                case Keys.D1:
                    
                    break;
                case Keys.D2:
                    
                    break;
                case Keys.D3:
                    
                    break;
                case Keys.D4:
                    
                    break;
                case Keys.D5:
                    
                    break;
                case Keys.D6:
                    
                    break;
                case Keys.D7:
                    
                    break;
                case Keys.D8:
                    
                    break;
                case Keys.D9:
                    
                    break;
                default:
                    Console.WriteLine("Not a number key");
                    break;
            }
        }
    }
}
