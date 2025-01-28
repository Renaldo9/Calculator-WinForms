namespace Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNumbers = new Panel();
            lblAnswer = new Label();
            btnRemove = new Button();
            btnCancel = new Button();
            btnCancelEntry = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btnSquareRoot = new Button();
            btnSquared = new Button();
            btnFraction = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnSignChange = new Button();
            btnZero = new Button();
            btnDecimal = new Button();
            pnlNumbers.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNumbers
            // 
            pnlNumbers.BackColor = SystemColors.ControlLight;
            pnlNumbers.Controls.Add(lblAnswer);
            pnlNumbers.Location = new Point(12, 12);
            pnlNumbers.Name = "pnlNumbers";
            pnlNumbers.Size = new Size(327, 99);
            pnlNumbers.TabIndex = 0;
            // 
            // lblAnswer
            // 
            lblAnswer.Anchor = AnchorStyles.Right;
            lblAnswer.Font = new Font("Segoe UI", 23F);
            lblAnswer.Location = new Point(3, 45);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(321, 42);
            lblAnswer.TabIndex = 0;
            lblAnswer.Text = "0";
            lblAnswer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(264, 117);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 45);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "<---";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(174, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 45);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "C";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCancelEntry
            // 
            btnCancelEntry.Location = new Point(93, 117);
            btnCancelEntry.Name = "btnCancelEntry";
            btnCancelEntry.Size = new Size(75, 45);
            btnCancelEntry.TabIndex = 3;
            btnCancelEntry.Text = "CE";
            btnCancelEntry.UseVisualStyleBackColor = true;
            btnCancelEntry.Click += btnCancelEntry_Click;
            // 
            // btnPercent
            // 
            btnPercent.Location = new Point(12, 117);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(75, 45);
            btnPercent.TabIndex = 4;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(264, 168);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 45);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.Location = new Point(174, 168);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(75, 45);
            btnSquareRoot.TabIndex = 6;
            btnSquareRoot.Text = "√x";
            btnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // btnSquared
            // 
            btnSquared.Location = new Point(93, 168);
            btnSquared.Name = "btnSquared";
            btnSquared.Size = new Size(75, 45);
            btnSquared.TabIndex = 7;
            btnSquared.Text = "x²";
            btnSquared.UseVisualStyleBackColor = true;
            // 
            // btnFraction
            // 
            btnFraction.Location = new Point(12, 168);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(75, 45);
            btnFraction.TabIndex = 8;
            btnFraction.Text = "1/x";
            btnFraction.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(264, 219);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 45);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(174, 219);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(75, 45);
            btnNine.TabIndex = 10;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(93, 219);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(75, 45);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(12, 219);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(75, 45);
            btnSeven.TabIndex = 12;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(264, 270);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 45);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(264, 321);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 45);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(264, 372);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 45);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(12, 270);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(75, 45);
            btnFour.TabIndex = 18;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(93, 270);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(75, 45);
            btnFive.TabIndex = 17;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(174, 270);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(75, 45);
            btnSix.TabIndex = 16;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(12, 321);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(75, 45);
            btnOne.TabIndex = 21;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(93, 321);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(75, 45);
            btnTwo.TabIndex = 20;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(174, 321);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(75, 45);
            btnThree.TabIndex = 19;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnSignChange
            // 
            btnSignChange.Location = new Point(12, 372);
            btnSignChange.Name = "btnSignChange";
            btnSignChange.Size = new Size(75, 45);
            btnSignChange.TabIndex = 24;
            btnSignChange.Text = "+/-";
            btnSignChange.UseVisualStyleBackColor = true;
            btnSignChange.Click += btnSignChange_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(93, 372);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(75, 45);
            btnZero.TabIndex = 23;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(174, 372);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 45);
            btnDecimal.TabIndex = 22;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 433);
            Controls.Add(btnSignChange);
            Controls.Add(btnZero);
            Controls.Add(btnDecimal);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnMultiply);
            Controls.Add(btnFraction);
            Controls.Add(btnSquared);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnDivide);
            Controls.Add(btnPercent);
            Controls.Add(btnCancelEntry);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(pnlNumbers);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "frmCalculator";
            Text = "Calculator";
            KeyDown += frmCalculator_KeyDown;
            pnlNumbers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNumbers;
        private Button btnRemove;
        private Button btnCancel;
        private Button btnCancelEntry;
        private Button btnPercent;
        private Button btnDivide;
        private Button btnSquareRoot;
        private Button btnSquared;
        private Button btnFraction;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEquals;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSignChange;
        private Button btnZero;
        private Button btnDecimal;
        private Label lblAnswer;
    }
}
