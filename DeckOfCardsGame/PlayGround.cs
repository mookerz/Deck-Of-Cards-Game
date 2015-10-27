using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCardsGame
{
    public partial class PlayGround : Form
    {
        Decks Table = new Decks();
        Card currentCard;
        Player Player1 = new Player();


        public PlayGround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReDrawData();
        }



        private void ReDrawData()
        {
            lblTotalCardsInTheDeck.Text = Table.getNumOfCardsInDeck().ToString();
            lblNumOfCardsInDeck.Text = Table.getNumOfCardsInDeck().ToString();
            lblDealedCards.Text = Table.getNumOfCardsUsed().ToString();
            lblNumOfDeckOnTheTable.Text = Table.getNumOfDecks().ToString();
            lblTotalCardsOnTheTable.Text = (Table.getNumOfCardsInDeck() + Table.getNumOfCardsUsed()).ToString();

            if (currentCard != null)
            {
                lblCardValueName.Text = currentCard.ToString();
            }
            else
            {
                lblCardValueName.Text = "Please deal a card";
            }

            listBox1.Items.Clear();
            for(int i = 0; i < Player1.getCardCount(); i++)
            {
                listBox1.Items.Add(Player1.getCard(i).ToString());
            }

        }

        private void btnAddDeckCardsWithJocker_Click(object sender, EventArgs e)
        {
            if (Table.getNumOfDecks() >= 10)
            {
                MessageBox.Show("The Maximum numebr of decks on the table cannot exceed 10");
            }
            else
            {
                Table.AddADeckOfCards(true);
            }
            Table.shuffleCard();
            ReDrawData();
        }

        private void btnaddDeckCardNoJocker_Click(object sender, EventArgs e)
        {
            if (Table.getNumOfDecks()>= 10)
            {
                MessageBox.Show("The Maximum numebr of decks on the table cannot exceed 10");
            }
            else
            {
                Table.AddADeckOfCards(false);
            }
            Table.shuffleCard();
            ReDrawData();
        }

        private void btnShuffleTable_Click(object sender, EventArgs e)
        {
            Table.shuffleCard();
            Player1.dropAll();
            currentCard = null;
            ReDrawData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table.CleanTable();
            Player1.dropAll();
            currentCard = null;
            ReDrawData();
        }

        private void btnDealCard_Click(object sender, EventArgs e)
        {
            if (Table.getNumOfCardsInDeck() <= 0)
            {
                MessageBox.Show("There is no more cards in the deck!");
            }
            else
            {
                currentCard = Table.dealCard();
                Player1.addCard(currentCard);
            }
            ReDrawData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player1.sortByValue();
            ReDrawData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Player1.sortBySuit();
            ReDrawData();
        }

    }
}
