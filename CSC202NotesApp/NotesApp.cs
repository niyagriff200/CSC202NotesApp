using System.Net.Http.Headers;

namespace CSC202NotesApp
{
    public partial class NotesApp : Form
    {
        public NotesApp()
        {
            InitializeComponent();
        }

        private void lb_Week1_Click(object sender, EventArgs e)
        {

        }

        private void rtb_PictureBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Combine_Click(object sender, EventArgs e)
        {
            //Creating variables word1 and word2
            string word1 = txt_word1.Text;
            string word2 = txt_word2.Text;

            //Adding word 1 to word 2
            string wordResult = word1 + word2; //Another way: string result = txt_word1 + txt_word2;

            //Displaying the results
            lb_wordResult.Text = wordResult;

            //TODO: In the future add a way to prevent numbers from working
            
        }
    }
}
