using System;

namespace CSC202NotesApp
{
    public partial class NotesApp : Form
    {

        private enum ResourceType
        {
            //TODO: Maybe add more resource types in the future
            Stone,
            Wood
        }
        private enum ItemType
        {
            //TODO: Maybe add more item types in the future
            Sticks,
            Rock,
            Planks,
            Furnace,
            Spear,
            Hammer,
            Pickaxe,
            Sword

        }

        //This 2 dimesnsional array stores all the character's names and their info - there are only 5 items in this array
        string[,] characterInfo = new string[5, 2]
        {
            { "Lemon", "Lemon and his twin Lime are very sour." },
            { "Lime", "Lime and his twin Lemon are very sour." },
            { "Orange", "Orange, enough said." },
            { "Berry", "Berry is from a long line of fruit, you might recognize his parents, blue and straw." },
            { "Banana", "Peel Banana's layer and he becomes bananas." }
        };

        //This array stores all the character's levels - there are only 5 items in this array
        int[] characterLevels = new int[5] { 12, 10, 5, 8, 7 };

        // This variable keeps track of which character is currently being displayed.
        // When the user clicks Next or Previous, this number changes so the program knows 
        // which character's name, description, and level to show.
        int characterIndex = 0;

        public NotesApp()
        {
            InitializeComponent();
            DisplayCharacter();

        }

        private void btn_Combine_Click(object sender, EventArgs e)
        {
            //Creating string variables sWord1 and sWord2
            string sWord1 = txt_word1.Text;
            string sWord2 = txt_word2.Text;

            //Adding word 1 to word 2
            string wordResult = sWord1 + sWord2; //Another way: string result = txt_word1.Text + txt_word2.Text;

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

        private void btn_AddWood_Click(object sender, EventArgs e)
        {
            //Reads the current amount from label (currently at 0)
            string labelText = lb_WoodAmount.Text.Replace("Amount: ", "");
            int currentWood = int.Parse(labelText);

            //Updates the amount using the AddResources function
            int newWood = AddResources(currentWood, 1, ResourceType.Wood);

            //Shows the updated amount using ShowAmount function
            ShowAmount(newWood, ResourceType.Wood);
        }

        private void btn_AddStone_Click(object sender, EventArgs e)
        {
            //Reads the current amount from label (currently at 0)
            string labelText = lb_StoneAmount.Text.Replace("Amount: ", "");
            int currentStone = int.Parse(labelText);

            //Updates the amount using the AddResources function
            int newStone = AddResources(currentStone, 1, ResourceType.Stone);

            //Shows the updated amount using ShowAmount function
            ShowAmount(newStone, ResourceType.Stone);
        }

        private void btn_Craft_Click(object sender, EventArgs e)
        {
            //Check if nothing is selected in the ComboBox (we can't craft anything if not)
            if (cb_ItemType.SelectedItem != null)
            {
                //Read current amounts from the labels (lb_WoodAmount and lb_StoneAmount) and set up the integers currentWood and currentStone
                int currentWood = int.Parse(lb_WoodAmount.Text.Replace("Amount: ", ""));
                int currentStone = int.Parse(lb_StoneAmount.Text.Replace("Amount: ", ""));

                //Convert ComboBox string to enumarator, to check ItemType (TODO: potentially set up a way to read the enumurator and place it in the ComboBox?, Warnings: CS8602(ln 147), CS8600(ln 147), CS8604(ln 148))
                string selectedText = cb_ItemType.SelectedItem.ToString();
                ItemType selectedItem = (ItemType)Enum.Parse(typeof(ItemType), selectedText); //find the enum value that matches the string in the ComboBox


                //Set up integers requiredWood and requiredStone; Get the required resources using the function RequiredResources set up integers requiredWood and requiredStone
                int requiredWood;
                int requiredStone;
                RequiredResources(selectedItem, out requiredWood, out requiredStone);

                //Check to see if crafting is possible using CanBeCrafted (it's going to be either true or false)
                bool canCraft = CanBeCrafted(currentWood, currentStone, requiredWood, requiredStone);

                if (canCraft) //true
                {
                    currentWood -= requiredWood; //subtract the amount used (the amount of the requiredWood from the currentWood)
                    currentStone -= requiredStone; //same thing, but for stone ^

                    ShowAmount(currentWood, ResourceType.Wood); //Show the new amount in the labels for both wood and stone
                    ShowAmount(currentStone, ResourceType.Stone);

                    lb_CraftedItem.Text = $"{selectedItem} has been added to your inventory."; //Show the selected item had been added to inventory
                }
                else //false
                {
                    lb_CraftedItem.Text = $"You need {requiredWood} wood and {requiredStone} stone to craft this item."; //Else show the required amount of wood and stone needed to craft selected item
                }
            }
            else
            {
                lb_CraftedItem.Text = "Please select an item first.";
            }
        }


        //Will be used to check to add resources (wood and stone) when button is clicked
        private int AddResources(int currentAmount, int amountToAdd, ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Wood:
                    currentAmount += amountToAdd; // or curentAmount = amountToAdd + currentAmount
                    break;
                case ResourceType.Stone:
                    currentAmount += amountToAdd;
                    break;
            }

            return currentAmount;
        }

        //Sets up the required resources needed for each ItemType
        private void RequiredResources(ItemType itemType, out int requiredWood, out int requiredStone) //out needed so it returns 2 values (requiredWood, requiredStone)
        {
            //Setting up default values
            requiredWood = 0;
            requiredStone = 0;

            //Each items required amount of wood and stone
            //TODO: Potentially change to dictionary later
            switch (itemType)
            {
                case ItemType.Sticks:
                    requiredWood = 1;
                    requiredStone = 0;
                    break;

                case ItemType.Rock:
                    requiredWood = 0;
                    requiredStone = 1;
                    break;

                case ItemType.Planks:
                    requiredWood = 4;
                    requiredStone = 0;
                    break;

                case ItemType.Furnace:
                    requiredWood = 0;
                    requiredStone = 8;
                    break;

                case ItemType.Spear:
                    requiredWood = 2;
                    requiredStone = 1;
                    break;

                case ItemType.Sword:
                    requiredWood = 2;
                    requiredStone = 2;
                    break;

                case ItemType.Hammer:
                    requiredWood = 2;
                    requiredStone = 3;
                    break;

                case ItemType.Pickaxe:
                    requiredWood = 2;
                    requiredStone = 3;
                    break;
            }
        }

        private void ShowAmount(int resourceAmount, ResourceType resourceType)
        {
            //Changes the label depending on if it's wood or stone
            switch (resourceType)
            {
                case ResourceType.Wood:
                    lb_WoodAmount.Text = $"Amount: {resourceAmount}";
                    break;
                case ResourceType.Stone:
                    lb_StoneAmount.Text = $"Amount: {resourceAmount}";
                    break;
            }
        }

        //Returns whether an item can be crafted or not (true or false)
        private bool CanBeCrafted(int currentWood, int currentStone, int requiredWood, int requiredStone)
        {
            if (currentWood >= requiredWood && currentStone >= requiredStone)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnWeek4Form_Click(object sender, EventArgs e)
        {
            //create an object of the form to open
            Week4 week4 = new Week4(this);

            //Open the week 4 form
            week4.Show();

            this.Hide();
        }

        private void DisplayCharacter()
        {
            try
            {
                // display the character name and info
                lbCharacterName.Text = $"Name: {characterInfo[characterIndex, 0]}";
                rtbCharacterInfo.Text = characterInfo[characterIndex, 1];

                //display the character level
                lbCharacterLevel.Text = $"Level: {characterLevels[characterIndex]}";
            }
            catch (IndexOutOfRangeException)
            {
                //reset character index to 0 if index is out of range
                characterIndex = 0;
                DisplayCharacter();
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            // Move to the next character
            characterIndex++; //Add 1 to the characterIndex

            // If we go past the last character, wrap back to 0
            if (characterIndex >= characterInfo.GetLength(0))
            {
                characterIndex = 0;
            }

            DisplayCharacter();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Move to the previous character
            characterIndex--; //Subtract 1 from the characterIndex

            // If we go before the first character, wrap to the last one
            if (characterIndex < 0)
            {
                characterIndex = characterInfo.GetLength(0) - 1;
            }

            DisplayCharacter();
        }

    }
}
