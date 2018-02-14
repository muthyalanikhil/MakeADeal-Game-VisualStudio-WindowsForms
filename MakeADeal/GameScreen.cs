using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeADeal
{
    public partial class GameScreen : Form
    {
        Random random = new Random();
        int carPosition;
        int myDoor;
        int montysDoorChoice;
        int doorToSwitch;
        int totalGamesCount = 0, totalWinsCount = 0, totalLostCount = 0;
        public GameScreen()
        {
            InitializeComponent();
            GameStart();
            totalGames.Text = "0";
            gamesLost.Text = "0";
            gamesWon.Text = "0";
        }

        private void GameStart()
        {
            switchDoorButton.Visible = false;
            RevealButton.Visible = false;
            resetToReplay.Visible = false;
            selectDoorLabel.Visible = true;
            youWonOrLostLabel.Visible = false;
            EnablePanelClicks();
            door_1.BackgroundImage = Properties.Resources.door;
            door_2.BackgroundImage = Properties.Resources.door;
            door_3.BackgroundImage = Properties.Resources.door;
        }

        private void ResetGame()
        {
            door_1.BackgroundImage = Properties.Resources.door;
            door_2.BackgroundImage = Properties.Resources.door;
            door_3.BackgroundImage = Properties.Resources.door;
            carPosition = 0;
            myDoor = 0;
            montysDoorChoice = 0;
            doorToSwitch = 0;
            GameStart();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void door_1_Click(object sender, EventArgs e)
        {
            door_1.BackgroundImage = Properties.Resources.selectedDoor;
            switchDoorButton.Visible = true;
            RevealButton.Visible = true;
            selectDoorLabel.Visible = false;
            DisablePanelClicks();
            MakeADeal(1);
        }

        private void door_2_Click(object sender, EventArgs e)
        {
            door_2.BackgroundImage = Properties.Resources.selectedDoor;
            switchDoorButton.Visible = true;
            RevealButton.Visible = true;
            selectDoorLabel.Visible = false;
            DisablePanelClicks();
            MakeADeal(2);
        }

        private void door_3_Click(object sender, EventArgs e)
        {
            door_3.BackgroundImage = Properties.Resources.selectedDoor;
            switchDoorButton.Visible = true;
            RevealButton.Visible = true;
            selectDoorLabel.Visible = false;
            DisablePanelClicks();
            MakeADeal(3);
        }

        private void MakeADeal(int myDoorNumber)
        {
            carPosition = random.Next(1 , 4);
            myDoor = myDoorNumber;
            switch (myDoorNumber)
            {
                case 1:
                    door_2.BackgroundImage = Properties.Resources.door;
                    door_3.BackgroundImage = Properties.Resources.door;
                    break;
                case 2:
                    door_1.BackgroundImage = Properties.Resources.door;
                    door_3.BackgroundImage = Properties.Resources.door;
                    break;
                case 3:
                    door_1.BackgroundImage = Properties.Resources.door;
                    door_2.BackgroundImage = Properties.Resources.door;
                    break;
            }

            montysDoorChoice = generateMontysDoorChoice(carPosition, myDoor);
            switch (montysDoorChoice)
            {
                case 1:
                    door_1.BackgroundImage = Properties.Resources.goat;
                    break;
                case 2:
                    door_2.BackgroundImage = Properties.Resources.goat;
                    break;
                case 3:
                    door_3.BackgroundImage = Properties.Resources.goat;
                    break;
            }
        }

        private int generateMontysDoorChoice(int carPosition, int doorChoice)
        {
            int i = 0;
            int montyDoor = 0;
            for (i = 1; i <= 3; i++)
            {
                if (i == carPosition || i == doorChoice)
                { continue; }
                montyDoor = i;
            }
            return montyDoor;
        }

        private int SwitchDoor(int myDoorChoice, int montyDoorChoice)
        {
            int switchedDoorNum = 0;
            for (switchedDoorNum = 1; switchedDoorNum <= 3; switchedDoorNum++)
            {
                if (switchedDoorNum == myDoorChoice || switchedDoorNum == montyDoorChoice)
                { continue; }
                myDoor = switchedDoorNum;
            }
            return myDoor;
        }

        private void switchDoorButton_Click(object sender, EventArgs e)
        {
            int myOldSelectedDoor = myDoor;
            doorToSwitch = SwitchDoor(myDoor, montysDoorChoice);
            switch (doorToSwitch)
            {
                case 1:
                    door_1.BackgroundImage = Properties.Resources.selectedDoor;
                    break;
                case 2:
                    door_2.BackgroundImage = Properties.Resources.selectedDoor;
                    break;
                case 3:
                    door_3.BackgroundImage = Properties.Resources.selectedDoor;
                    break;
            }
            switch (myOldSelectedDoor)
            {
                case 1:
                    door_1.BackgroundImage = Properties.Resources.door;
                    break;
                case 2:
                    door_2.BackgroundImage = Properties.Resources.door;
                    break;
                case 3:
                    door_3.BackgroundImage = Properties.Resources.door;
                    break;
            }
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {
            switch (carPosition)
            {
                case 1:
                    door_1.BackgroundImage = Properties.Resources.car;
                    door_2.BackgroundImage = Properties.Resources.goat;
                    door_3.BackgroundImage = Properties.Resources.goat;
                    resetToReplay.Visible = true;
                    switchDoorButton.Visible = false;
                    RevealButton.Visible = false;
                    ScoreCount();
                    break;
                case 2:
                    door_1.BackgroundImage = Properties.Resources.goat;
                    door_2.BackgroundImage = Properties.Resources.car;
                    door_3.BackgroundImage = Properties.Resources.goat;
                    resetToReplay.Visible = true;
                    switchDoorButton.Visible = false;
                    RevealButton.Visible = false;
                    ScoreCount();
                    break;
                case 3:
                    door_1.BackgroundImage = Properties.Resources.goat;
                    door_2.BackgroundImage = Properties.Resources.goat;
                    door_3.BackgroundImage = Properties.Resources.car;
                    resetToReplay.Visible = true;
                    switchDoorButton.Visible = false;
                    RevealButton.Visible = false;
                    ScoreCount();
                    break;
            }
        }

        private void ScoreCount()
        {
            if (myDoor == carPosition)
            {
                totalWinsCount++;
                totalGamesCount++;
                totalGames.Text = totalGamesCount.ToString();
                gamesWon.Text = totalWinsCount.ToString();
                youWonOrLostLabel.Visible = true;
                youWonOrLostLabel.Text = "Hurray..!! You Won...!!!";
            }
            else
            {
                totalLostCount++;
                totalGamesCount++;
                totalGames.Text = totalGamesCount.ToString();
                gamesLost.Text = totalLostCount.ToString();
                youWonOrLostLabel.Visible = true;
                youWonOrLostLabel.Text = "OOPS..!! You Lost..!!!";
            }

        }

        private void DisablePanelClicks()
        {
            door_1.Click -= door_1_Click;
            door_2.Click -= door_2_Click;
            door_3.Click -= door_3_Click;
        }

        private void EnablePanelClicks()
        {
            door_1.Click += door_1_Click;
            door_2.Click += door_2_Click;
            door_3.Click += door_3_Click;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
