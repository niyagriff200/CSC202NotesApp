namespace CSC202NotesApp
{
    public partial class NotesApp : Form
    {
        public NotesApp()
        {
            InitializeComponent();
        }

        private void btn_Combine_Click(object sender, EventArgs e)
        {
            //Creating string variables sWord1 and sWord2
            string sWord1 = txt_word1.Text;
            string sWord2 = txt_word2.Text;

            //Adding word 1 to word 2
            string wordResult = sWord1 + sWord2; //Another way: string result = txt_word1 + txt_word2;

            //Displaying the results
            lb_wordResult.Text = wordResult;

            //TODO: In the future add a way to prevent numbers from working

        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {

            //Creating integer variables iNum1 and iNum2
            int iNum1 = int.Parse(txt_num1.Text);
            int iNum2 = int.Parse(txt_num2.Text);


            //If the 2nd number is 0, output, cannot divide by 0; Else, divide and output the result 
            if (iNum2 == 0)
            {
                lb_numResult.Text = "Cannot divide by 0";
            }
            else
            {
                int quotientResult = iNum1 / iNum2;
                //If quotientResult divide by 2 and the remainder is 0, the number is even; Else, the number is odd
                if (quotientResult % 2 == 0)
                {
                    lb_evenOdd.Text = "The number is even";
                }
                else
                {
                    lb_evenOdd.Text = "The number is odd";
                }

                lb_numResult.Text = $"{quotientResult}";
            }

        }

        private void btn_Divide2_Click(object sender, EventArgs e)
        {
            //Creating integer variables iNum1 and iNum2
            double iNum3 = double.Parse(txt_num3.Text);
            double iNum4 = double.Parse(txt_num4.Text);


            //If the 2nd number is 0, output, cannot divide by 0; Else, divide and output the result 
            if (iNum4 == 0)
            {
                lb_numResult2.Text = "Cannot divide by 0";
            }
            else
            {
                double quotientResult = iNum3 / iNum4;
                //If quotientResult divide by 2 and the remainder is 0, the number is even; Else, the number is odd
                if (quotientResult % 2 == 0)
                {
                    lb_evenOdd2.Text = "The number is even";
                }
                else
                {
                    lb_evenOdd2.Text = "The number is odd";
                }

                lb_numResult2.Text = $"{quotientResult}";
            }
        }
    }
}
