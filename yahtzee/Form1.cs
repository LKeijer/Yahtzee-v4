using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yahtzee
{
    public partial class Form1 : Form
    {
        #region Declarations
        Image[] diceImages;
        int[] dice;
        int[] diceResults;
        Random rngeesus;
        int counter;
        bool changeable;
        bool havePair;
        bool haveThree;
        bool twoPair ;
        bool fullHouse ;
        bool lowStraight ;
        bool highStraight;
        bool fourOfKind;
        bool fiveOfKind;
        #endregion

        public Form1()
        {
            #region initialization.
            InitializeComponent();
            diceImages = new Image[8];
            diceImages[0] = Properties.Resources.dice1_6;
            diceImages[1] = Properties.Resources.dice1;
            diceImages[2] = Properties.Resources.dice2;
            diceImages[3] = Properties.Resources.dice3;
            diceImages[4] = Properties.Resources.dice4;
            diceImages[5] = Properties.Resources.dice5;
            diceImages[6] = Properties.Resources.dice6;
            diceImages[7] = Properties.Resources.rollDice;
            rngeesus = new Random();
            dice = new int[5] { 0, 0, 0, 0, 0 };
            diceResults = new int[6] { 0, 0, 0, 0, 0, 0 };
            bool havePair = false;
            bool haveThree = false;
            bool twoPair = false;
            bool fullHouse = false;
            bool lowStraight = false;
            bool highStraight = false;
            bool fourOfKind = false;
            bool fiveOfKind = false;

            #endregion
        }

        private void rollDiceBtn_Click(object sender, EventArgs e)
        {

            RollDice();
            if (counter == 3)
            {
                InsertResults();
                GetResults();
                UpdateLabel();
                
            }
        }

        private void UpdateLabel()
        {
            #region Contains the code that sets the label of the outcome
            if (fiveOfKind == true)
                label1.Text = "Five of a kind!";
            else if (fourOfKind == true)
                label1.Text = "Four of a kind!";

            else if (highStraight == true)
                label1.Text = "High Straight!";
            else if (lowStraight == true)
                label1.Text = "Low Straight!";
            else if (fullHouse == true)
                label1.Text = "Full House!";

            else if (haveThree == true)
                label1.Text = "Three of a kind!";
            else if (twoPair == true)
                label1.Text = "Two pair!";
            else if (havePair == true)
                label1.Text = "Pair!";
#endregion
        }


        #region Method for inserting the dice into the final result array
        private void InsertResults()
        {
            if (counter == 3 && pictureBox6.Image != null && pictureBox7.Image != null && pictureBox8.Image != null && pictureBox9.Image != null && pictureBox10.Image != null)
            {
                if (pictureBox6.Image == diceImages[1])
                    diceResults[0]++;
                if (pictureBox6.Image == diceImages[2])
                    diceResults[1]++;
                if (pictureBox6.Image == diceImages[3])
                    diceResults[2]++;
                if (pictureBox6.Image == diceImages[4])
                    diceResults[3]++;
                if (pictureBox6.Image == diceImages[5])
                    diceResults[4]++;
                if (pictureBox6.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox7.Image == diceImages[1])
                    diceResults[0]++;
                if (pictureBox7.Image == diceImages[2])
                    diceResults[1]++;
                if (pictureBox7.Image == diceImages[3])
                    diceResults[2]++;
                if (pictureBox7.Image == diceImages[4])
                    diceResults[3]++;
                if (pictureBox7.Image == diceImages[5])
                    diceResults[4]++;
                if (pictureBox7.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox8.Image == diceImages[1])
                    diceResults[0]++;
                if (pictureBox8.Image == diceImages[2])
                    diceResults[1]++;
                if (pictureBox8.Image == diceImages[3])
                    diceResults[2]++;
                if (pictureBox8.Image == diceImages[4])
                    diceResults[3]++;
                if (pictureBox8.Image == diceImages[5])
                    diceResults[4]++;
                if (pictureBox8.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox9.Image == diceImages[1])
                    diceResults[0]++;
                if (pictureBox9.Image == diceImages[2])
                    diceResults[1]++;
                if (pictureBox9.Image == diceImages[3])
                    diceResults[2]++;
                if (pictureBox9.Image == diceImages[4])
                    diceResults[3]++;
                if (pictureBox9.Image == diceImages[5])
                    diceResults[4]++;
                if (pictureBox9.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox10.Image == diceImages[1])
                    diceResults[0]++;
                if (pictureBox10.Image == diceImages[2])
                    diceResults[1]++;
                if (pictureBox10.Image == diceImages[3])
                    diceResults[2]++;
                if (pictureBox10.Image == diceImages[4])
                    diceResults[3]++;
                if (pictureBox10.Image == diceImages[5])
                    diceResults[4]++;
                if (pictureBox10.Image == diceImages[6])
                    diceResults[5]++;
            }
            else
            {
                MessageBox.Show("Please select all the dice.");
            }
#endregion
        }

        private void GetResults()
        {

            #region if-else statements that saves the dice (that are not to be rerolled) in the diceResults array
            if (pictureBox6.Image == diceImages[1])
                diceResults[0]++;
            else if (pictureBox6.Image == diceImages[2])
                diceResults[1]++;
            else if (pictureBox6.Image == diceImages[3])
                diceResults[2]++;
            else if (pictureBox6.Image == diceImages[4])
                diceResults[3]++;
            else if (pictureBox6.Image == diceImages[5])
                diceResults[4]++;

            if (pictureBox7.Image == diceImages[1])
                diceResults[0]++;
            else if (pictureBox7.Image == diceImages[2])
                diceResults[1]++;
            else if (pictureBox7.Image == diceImages[3])
                diceResults[2]++;
            else if (pictureBox7.Image == diceImages[4])
                diceResults[3]++;
            else if (pictureBox7.Image == diceImages[5])
                diceResults[4]++;

            if (pictureBox8.Image == diceImages[1])
                diceResults[0]++;
            else if (pictureBox8.Image == diceImages[2])
                diceResults[1]++;
            else if (pictureBox8.Image == diceImages[3])
                diceResults[2]++;
            else if (pictureBox8.Image == diceImages[4])
                diceResults[3]++;
            else if (pictureBox8.Image == diceImages[5])
                diceResults[4]++;

            if (pictureBox9.Image == diceImages[1])
                diceResults[0]++;
            else if (pictureBox9.Image == diceImages[2])
                diceResults[1]++;
            else if (pictureBox9.Image == diceImages[3])
                diceResults[2]++;
            else if (pictureBox9.Image == diceImages[4])
                diceResults[3]++;
            else if (pictureBox9.Image == diceImages[5])
                diceResults[4]++;

            if (pictureBox10.Image == diceImages[1])
                diceResults[0]++;
            else if (pictureBox10.Image == diceImages[2])
                diceResults[1]++;
            else if (pictureBox10.Image == diceImages[3])
                diceResults[2]++;
            else if (pictureBox10.Image == diceImages[4])
                diceResults[3]++;
            else if (pictureBox10.Image == diceImages[5])
                diceResults[4]++;
            #endregion

            #region logic for getting results
            for (int i = 0; i < diceResults.Length; i++)
            {
                if (diceResults[i] == 5)
                    fiveOfKind = true;
                if (diceResults[i] == 4)
                    fourOfKind = true;
                if(diceResults[i] == 3)
                {
                    haveThree = true;
                    if (diceResults[i] == 2)
                        fullHouse = true;
                    if(diceResults[i] == 2)
                    {
                        havePair = true;
                        for(int j = i+1; j < diceResults.Length; i++)
                        {
                            if (diceResults[j] == 2)
                                twoPair = true;
                        }
                    }
                    if (diceResults[0] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1)
                        lowStraight = true;
                    if (diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1 && diceResults[5] == 1)
                        highStraight = true;
                }

            }   


#endregion
        }
        // contains the RollDice method.
            #region RollDice method
        private void RollDice()
        {
            if (counter < 3)
            {
                counter++;
                for (int i = 0; i < dice.Length; i++)
                {
                    dice[i] = rngeesus.Next(1, 7);
                }
                if (pictureBox6.Image == null)
                    pictureBox1.Image = diceImages[dice[0]];
                if (pictureBox7.Image == null)
                    pictureBox2.Image = diceImages[dice[1]];
                if (pictureBox8.Image == null)
                    pictureBox3.Image = diceImages[dice[2]];
                if (pictureBox9.Image == null)
                    pictureBox4.Image = diceImages[dice[3]];
                if (pictureBox10.Image == null)
                    pictureBox5.Image = diceImages[dice[4]];
            }
            else
            {

                changeable = false;
                MessageBox.Show("Max. rolled");
                rollDiceBtn.Text = "You can only roll 3 times";
            }
        }
#endregion

        // contains the dice that are not to be rerolled.
            #region SavedRolls
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (changeable == true)
            {
                pictureBox1.Image = pictureBox6.Image;
                pictureBox6.Image = null;
            }
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (changeable == true)
            {
                pictureBox2.Image = pictureBox7.Image;
                pictureBox7.Image = null;
            }
        }

       
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (changeable == true)
            {
                pictureBox3.Image = pictureBox8.Image;
                pictureBox8.Image = null;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (changeable == true)
            {
                pictureBox4.Image = pictureBox9.Image;
                pictureBox9.Image = null;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (changeable == true)
            {
                pictureBox5.Image = pictureBox10.Image;
                pictureBox10.Image = null;
            }
        }
        #endregion //contains the dice that are not to be re-rolled.

        // contains the dice that are to be rolled.
            #region RollableRolls
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox1.Image;
            pictureBox1.Image = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = pictureBox2.Image;
            pictureBox2.Image = null;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox3.Image;
            pictureBox3.Image = null;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox4.Image;
            pictureBox4.Image = null;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = pictureBox5.Image;
            pictureBox5.Image = null;
        }
        #endregion //contains the dice that are to be rolled.

        private void resetBtn_Click(object sender, EventArgs e)
        {
            #region Resets all the pictureboxes to null && all array indexes to 0 && sets counter to 0
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            diceResults[0] = 0;
            diceResults[1] = 0;
            diceResults[2] = 0;
            diceResults[3] = 0;
            diceResults[4] = 0;
            diceResults[5] = 0;
            dice[0] = 0;
            dice[1] = 0;
            dice[2] = 0;
            dice[3] = 0;
            dice[4] = 0;
            counter = 0;
            #endregion
        }
    }
}
