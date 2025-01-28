namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        float num1 = 0;
        float num2 = 0;
        float finalAnswer = 0;
        List<float> answerList = new List<float>();
        List<string> signs = new List<string>();
        string inputNum = "";

        public void showInput()
        {

            //change so that it loops from the end of the string to the front to resolve issues
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
                inputNum = "0,";
                showInput();
            }
            else if (!inputNum.Contains(',') && inputNum.Length < 12)
            {
                inputNum += ",";
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


        //Calculations
        private void AddSign(string sign)
        {
            // Save the current number to the list
            if (!string.IsNullOrEmpty(inputNum))
            {
                float number = float.Parse(inputNum);
                answerList.Add(number);
            }

            // Save the operator to the list
            signs.Add(sign);

            // Clear the inputNum for the next number
            inputNum = "";

            // Display the operator temporarily in lblAnswer
            lblAnswer.Text = sign;
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            AddSign("+");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Add the last number to the list
            if (!string.IsNullOrEmpty(inputNum))
            {
                float number = float.Parse(inputNum);
                answerList.Add(number);
            }

            // Perform the calculation
            if (answerList.Count > 0 && signs.Count > 0)
            {
                finalAnswer = answerList[0]; // Start with the first number

                for (int i = 0; i < signs.Count; i++)
                {
                    // Get the next number and the operator
                    float nextNumber = answerList[i + 1];
                    string sign = signs[i];

                    // Perform the operation
                    switch (sign)
                    {
                        case "+":
                            finalAnswer += nextNumber;
                            break;
                        case "-":
                            finalAnswer -= nextNumber;
                            break;
                        case "*":
                            finalAnswer *= nextNumber;
                            break;
                        case "/":
                            if (nextNumber != 0)
                            {
                                finalAnswer /= nextNumber;
                            }
                            else
                            {
                                // Handle division by zero gracefully
                                lblAnswer.Text = "Error: Division by 0";

                                // Reset the calculator state
                                answerList.Clear();
                                signs.Clear();
                                inputNum = "";

                                return; // Exit the equals function
                            }
                            break;
                    }
                }

                // Display the result
                lblAnswer.Text = finalAnswer.ToString();

                // Clear lists for next calculation
                answerList.Clear();
                signs.Clear();
                inputNum = finalAnswer.ToString(); // Allow chaining calculations
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AddSign("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AddSign("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AddSign("/");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            inputNum = "";
            lblAnswer.Text = "0";
            signs.Clear();
            answerList.Clear();
        }

        private void btnCancelEntry_Click(object sender, EventArgs e)
        {
            inputNum = "";
            lblAnswer.Text = "0";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            float num = float.Parse(inputNum);
            num = num / 100;
            inputNum = num.ToString();
            lblAnswer.Text = inputNum;
        }

        private void btnFraction_Click(object sender, EventArgs e)
        {
            float num = float.Parse(inputNum);
            num = 1 / num;
            inputNum = num.ToString();
            lblAnswer.Text = inputNum;
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            float num = float.Parse(inputNum);
            num = num * num;
            inputNum = num.ToString();
            lblAnswer.Text = inputNum;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            float num = float.Parse(inputNum);
            num = (float)Math.Sqrt(num);
            inputNum = num.ToString();
            lblAnswer.Text = inputNum;
        }
    }
}
