using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSC202NotesApp
{
    public partial class Week4 : Form
    {
        //This is the original form to go back to
        private NotesApp frmOriginal;

        //This is to hold the generate random card string
        private string cardGenerated = "";

        public Week4()
        {
            InitializeComponent();
        }

        public Week4(NotesApp notesAppObj)
        {
            InitializeComponent();
            frmOriginal = notesAppObj;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Show original form (NotesApp)
            frmOriginal.Show();

            //Close this form (Week4)
            this.Close();
        }

        private void Week4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show original form (NotesApp)
            frmOriginal.Show();
        }

        private void btnGenerateCard_Click(object sender, EventArgs e)
        {
            //Generate card, then tell the user the card has been generated and what to do next
            cardGenerated = GenerateRandomCard();
            lbMessages.Items.Add("A card has been generated! Click the button to guess the card!");

            //Disable the generate card button
            btnGenerateCard.Enabled = false;

            //Enable the card buttons
            btnKing.Enabled = true;
            btnQueen.Enabled = true;
            btnJack.Enabled = true;
            btnAce.Enabled = true;
        }

        private void btnKing_Click(object sender, EventArgs e)
        {
            CheckGuess("King");
        }

        private void btnQueen_Click(object sender, EventArgs e)
        {
            CheckGuess("Queen");
        }

        private void btnJack_Click(object sender, EventArgs e)
        {
            CheckGuess("Jack");
        }

        private void btnAce_Click(object sender, EventArgs e)
        {
            CheckGuess("Ace");
        }

        //Needs to return "string" name of card
        private string GenerateRandomCard()
        {
            //String array to generate cards from
            string[] cards = { "King", "Queen", "Jack", "Ace" };

            //Grab a random card from the cards array
            Random rng = new Random();
            return cards[rng.Next(cards.Length)];
        }

        //Check the guess of the user to the random card generated
        private void CheckGuess(string guess)
        {
            try
            {   //Check if the string is null/empty, if so throw the NullRefEx and let the user know
                if (string.IsNullOrEmpty(cardGenerated))
                {
                    throw new NullReferenceException("Card has not been generated yet.");
                }

                if (guess == cardGenerated)
                {
                    lbMessages.Items.Add("Correct! You guessed the card!");

                    //Reenable the generate card button
                    btnGenerateCard.Enabled = true;

                    //Disable the guess card buttons
                    btnKing.Enabled = false;
                    btnQueen.Enabled = false;
                    btnJack.Enabled = false;
                    btnAce.Enabled = false;
                }
                else
                {
                    lbMessages.Items.Add($"Wrong! The card was {cardGenerated}.");

                    //Re-enable the generate card button
                    btnGenerateCard.Enabled = true;

                    //Disable the guess card buttons
                    btnKing.Enabled = false;
                    btnQueen.Enabled = false;
                    btnJack.Enabled = false;
                    btnAce.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                lbMessages.Items.Add($"{DateTime.Now}: {ex.Message}");
            }
        }

        private void btnGenerateErrors_Click(object sender, EventArgs e)
        {
            //Disable the button so the user cannot click it during the loop
            btnGenerateErrors.Enabled = false;

            //Counter for the while loop
            int counter = 0;
            //Run the loop 5 times
            while (counter < 5)
            {
                try
                {
                    //Call the function that will throw an exception
                    SimulateError();
                }
                catch (DivideByZeroException ex)
                {
                    //Add the exception message to the ListBox
                    lbErrorLogs.Items.Add(DateTime.Now + ": DivideByZeroException - " + ex.Message);
                }
                catch (FormatException ex)
                {
                    //Add the exception message to the ListBox
                    lbErrorLogs.Items.Add(DateTime.Now + ": FormatException - " + ex.Message);
                }

                //Increase the counter so the loop eventually ends
                counter++;
            }
            //Re-enable the button after the loop finishes
            btnGenerateErrors.Enabled = true;
        }
        //This function randomly throws one of two exceptions
        private void SimulateError()
        {
            //Create a Random object
            Random rng = new Random();

            //Pick a number 0 or 1
            int choice = rng.Next(0, 2);

            //If choice is 0, throw DivideByZeroException
            if (choice == 0)
            {
                int x = 10;
                int y = 0;
                int result = x / y; //This will throw DivideByZeroException
            }
            else
            {
                //If choice is 1, throw FormatException
                int number = int.Parse("hello"); //This will throw FormatException
            }
        }

        private void btnClearErrors_Click(object sender, EventArgs e)
        {
            //Clear all items from the ListBox
            lbErrorLogs.Items.Clear();
        }
    }
}
