using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Flashcard
{
    public partial class MainForm : Form
    {
        Pack pack;
        int activeCard;

        public MainForm()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// All of the below is the code that wraps everything together, like the renderer, saver etc.. below that is the methods for button presses etc.
        /// </summary>

        private void uiEnabled(bool stat)
        {
            holdingFrame.Enabled = stat;
        }

        private void QuestionCardRender()
        {
            if(pack.cards[activeCard].isQuestion == true)
            {
                backCard.BackColor = Color.Black;
            }
            else
            {
                backCard.BackColor = Color.White;
            }    
        }

        private void createCard()
        {
            pack.cards[pack.length+1] = new Card();
            pack.length++;
            pack.cards[pack.length].frontCard = "This is the front card! \n Card " + (pack.length+1).ToString();
            pack.cards[pack.length].backCard = "This is the back card!";
        }

        private void renderWindow(int card)
        {
            frontCard.Text = pack.cards[card].frontCard;
            backCard.Text = pack.cards[card].backCard;
            isQuestioncardCheckBox.Checked = pack.cards[card].isQuestion;

            messageLabel.Text = "Card " + (card+1) + " of " + (pack.length+1);
        }

        private void saveCard()
        {
            pack.cards[activeCard].frontCard = frontCard.Text;
            pack.cards[activeCard].backCard = backCard.Text;
        }

        /// <summary>
        /// from here, everything is event methods. Above is the methods that strap everything together.
        /// </summary> 

        private void aboutBttn_Click(object sender, EventArgs e)
        {
            about abt = new about();
            abt.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //start a new pack
            pack = new Pack();
            pack.cards = new Card[10000];
            //add first card
            pack.length = 0;
            pack.cards[0] = new Card();
            uiEnabled(true);
            pack.cards[0].frontCard = "This is the front card!";
            pack.cards[0].backCard = "This is the back card!";

            //Display the card!
            renderWindow(0);

            //set active
            activeCard = 0;
        }

        private void prevCard_Click(object sender, EventArgs e)
        {
            if (activeCard > 0)
            {
                saveCard();
                activeCard--;
                renderWindow(activeCard);
                QuestionCardRender();

            }
        }

        private void nextCard_Click(object sender, EventArgs e)
        {
            if(activeCard < pack.length)
            {
                saveCard();
                activeCard++;
                renderWindow(activeCard);
                QuestionCardRender();
            }
            else
            {
                saveCard();
                createCard();
                activeCard++;
                renderWindow(activeCard);
                QuestionCardRender();
            }
        }

        private void isQuestioncardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pack.cards[activeCard].isQuestion = isQuestioncardCheckBox.Checked;
        }

        private void showCard_Click(object sender, EventArgs e)
        {
            backCard.BackColor = Color.White;
        }

        private void hideCard_Click(object sender, EventArgs e)
        {
            backCard.BackColor = Color.Black;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDiag.Filter = "Flashcard Files (*.fc)|*.fc";
            saveDiag.Title = "Select a location to save your file to";
            if(saveDiag.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(saveDiag.FileName);
                string json = JsonConvert.SerializeObject(pack);
                if (File.Exists(saveDiag.FileName))
                {
                    File.Delete(saveDiag.FileName);
                }
                File.WriteAllText(saveDiag.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDiag.Filter = "Flashcard Files (*.fc)|*.fc";
            openDiag.Title = "Select a location to open from";

            if (openDiag.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openDiag.FileName);
                pack = JsonConvert.DeserializeObject<Pack>(json);
                renderWindow(0);
                uiEnabled(true);
            }
        }
    }
}
