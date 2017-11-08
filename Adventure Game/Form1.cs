using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game
{
    public partial class adventureTextGame : Form
    {
        int scene = 1;

        // random number generator
        Random randGen = new Random();

        public adventureTextGame()
        {
            InitializeComponent();

            //display initial message and options
            picturesLabel.Image = Properties.Resources._25549;
            outputLabel.Text = "You wake up in a mysterious place with lots of old trees, dark sky weird shadows and you can hear whispers. You see a light and an old car. The last you remember was drinking a lot in Mario's party \nWould you go to the light or investigate the car?";
            redLabel.Text = "Go to the light";
            blueLabel.Text = "Go to the car";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            double dice1Value = randGen.Next(1, 101);

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 2)
                {
                    if (dice1Value <= 70)
                    {
                        scene = 6;
                    }
                    else { scene = 5; }
                }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 15; }
                else if (scene == 16) { scene = 15; }
                else if (scene == 6) { scene = 11; }
                else if (scene == 8) { scene = 14; }
                else if (scene == 10) { scene = 12; }
                else if (scene == 17) { scene = 18; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 5) { scene = 1; }
                else if (scene == 9) { scene = 1; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 15) { scene = 1; }
                else if (scene == 18) { scene = 1; }
                else if (scene == 19) { scene = 1; }
                else if (scene == 20) { scene = 1; }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2)
                {
                    if (dice1Value <= 50)
                    {
                        scene = 7;
                    }

                    else { scene = 5; }
                }
                else if (scene == 3) { scene = 20; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 13; }
                else if (scene == 10) { scene = 13; }
                else if (scene == 3) { scene = 20; }
                else if (scene == 4) { scene = 16; }
                else if (scene == 5) { scene = 21; }
                else if (scene == 9) { scene = 21; }
                else if (scene == 12) { scene = 21; }
                else if (scene == 13) { scene = 21; }
                else if (scene == 15) { scene = 21; }
                else if (scene == 18) { scene = 21; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 14) { scene = 19; }
                else if (scene == 6) { scene = 8; }
                else if (scene == 19) { scene = 21; }
                else if (scene == 16) { scene = 17; }
                else if (scene == 17) { scene = 14; }

            }
            else if (e.KeyCode == Keys.N)  //yellow button press
            {
                if (scene == 6)
                {
                    if (dice1Value <= 70)
                    {
                        scene = 10;
                    }

                    else { scene = 9; }
                }

                else if (scene == 7)
                {
                    if (dice1Value <= 70)
                    {
                        scene = 10;
                    }

                    else { scene = 9; }
                }
                else if (scene == 14) { scene = 19; }

                
            }
            switch (scene)
            {

                case 1: //start scene 
                    picturesLabel.Image = Properties.Resources._25549;
                    outputLabel.Text = "You wake up in a mysterious place with lots of old trees, dark sky weird shadows and you can hear some whispers. You see a light and an old car. The last you remember was drinking a lot in Mario's party." + "\nWould you go to the light or investigate the car?";
                    redLabel.Text = "Go to the light";
                    blueLabel.Text = "Go to the car";
                    yellowLabel.Text = "";
                    break;
                case 2:
                    picturesLabel.Image = Properties.Resources.chatillon_car_graveyard_abandoned_cars_cemetery_belgium_31;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Footsteps_Walking_SoundBible_com_522653436);
                    player.Play();
                    outputLabel.Text = "There is a lantern and a screwdriver, but you hear some steps behind you. \nWould you take the lantern or the screwdriver ? ";
                    redLabel.Text = "Pick the lantern";
                    blueLabel.Text = "Pick the screwdriver";
                    yellowLabel.Text = "";
                    break;
                case 3:
                    picturesLabel.Image = Properties.Resources._09c9b295f8ff686b7e8674f9c0151555__lost_river_creepy_pictures;
                    outputLabel.Text = "As you get closer you hear shouts, people crying. You see a river and a big tree with a branch that almost cross over the river. \nWhat would you do? ";
                    redLabel.Text = "Try to cross the river";
                    blueLabel.Text = "Cross it through the branch";
                    yellowLabel.Text = "";
                    break;
                case 4:
                    picturesLabel.Image = Properties.Resources._1dae12354aea3992aa7e90478ac81a51;
                    outputLabel.Text = "Nothing happened in the river, you are closer to the noise and the light. " + "\nWould you continue to the light or go where the noise come from? ";
                    redLabel.Text = "Go to the light";
                    blueLabel.Text = "Go to the noise";
                    yellowLabel.Text = "";
                    break;
                case 5:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "The black shadow jump to you and bite your neck before you can even react \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 6:
                    picturesLabel.Image = Properties.Resources.bdacea4eb922cfae8ebf56dde1c2c12e__creepy_things_bridges;
                    outputLabel.Text = "You turn around with the lantern and the beast runs away scared of the light. You see an old path between the grass and a old wooden bridge that cross over a gorge, but there are some shiny eyes looking at you \nWould you walk trought the path or still searching in the car? ";
                    redLabel.Text = "Path";
                    blueLabel.Text = "Still searching";
                    yellowLabel.Text = "Bridge";
                    break;
                case 7:
                    picturesLabel.Image = Properties.Resources.bdacea4eb922cfae8ebf56dde1c2c12e__creepy_things_bridges;
                    outputLabel.Text = "You stick the screwdriver in the beast and it disappear.You see an old path between the grass and a old wooden bridge that cross over a gorge, but there are some shiny eyes looking at you \nWould you walk trought  the path or still searching in the car? ";
                    redLabel.Text = "Path";
                    blueLabel.Text = "Still searching";
                    yellowLabel.Text = "Bridge";
                    break;
                case 8:
                    picturesLabel.Image = Properties.Resources.Acadia_Spooky_Woods_II;
                    outputLabel.Text = "You found a key and you decided to keep it and start walking through a path. You get to the end of the path and there's a hole but can't see anything inside \nWould you jump or look around? ";
                    redLabel.Text = "Jump";
                    blueLabel.Text = "Look around";
                    yellowLabel.Text = "";
                    break;
                case 9:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "You fall off the bridge and sleep forever \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 10:
                    picturesLabel.Image = Properties.Resources.tmpnull;
                    outputLabel.Text = "You get to the end of the bridge and there's a hole but can't see anything inside\nWould you jump or look around? ";
                    redLabel.Text = "Jump";
                    blueLabel.Text = "Look around";
                    yellowLabel.Text = "";
                    break;
                case 11:
                    picturesLabel.Image = Properties.Resources.tmpnull;
                    outputLabel.Text = "After avoiding the big gorge, You get to the end of the path and there's another hole but can't see anything inside \nWould you jump or look around ? ";
                    redLabel.Text = "Jump";
                    blueLabel.Text = "Look around";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    picturesLabel.Image = Properties.Resources.white_room_closed_door_empty_35545491;
                    outputLabel.Text = "You get to a white room with a locked door but you don't have anything to open it... you starve to death \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 13:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "You start looking around but a big soul bites you and let you in the floor bleeding badly where you bleed out \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 14:
                    picturesLabel.Image = Properties.Resources.white_room_closed_door_empty_35545491;
                    Thread.Sleep(3000);
                    player = new SoundPlayer(Properties.Resources.Applause_SoundBible_com_151138312);
                    player.Play();
                    outputLabel.Text = "You appear in a white room with a locked door, and you open it with the key you picked before. Suddenly every thing is black but you open your eyes and you find yourself lay in the hospital bed with all your family around you... Well done! You woke from the coma \nYou can cry, say hello or ask to sleep 5 more minutes because you are tired, what would you do? ";
                    redLabel.Text = "Cry";
                    blueLabel.Text = "Hello";
                    yellowLabel.Text = "Sleep";
                    break;
                case 15:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "You died after two days in coma by alcohol poisoning \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 16:
                    picturesLabel.Image = Properties.Resources.download;
                    outputLabel.Text = "A strong wind start blocking you to continue while the screams sound closer \nWould you give up or still trying to continue?";
                    redLabel.Text = "Give up";
                    blueLabel.Text = "Continue";
                    yellowLabel.Text = "";
                    break;
                case 17:
                    picturesLabel.Image = Properties.Resources.download;
                    outputLabel.Text = "You get to a room with two doors, one is red and the other is blue \nRed door or blue door?";
                    redLabel.Text = "Red door";
                    blueLabel.Text = "Blue door";
                    yellowLabel.Text = "";
                    break;
                case 18:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "You fall forever \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 19:
                    picturesLabel.Image = Properties.Resources.download;
                    outputLabel.Text = "You win! Do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 20:
                    picturesLabel.Image = Properties.Resources._4586228f53f2ab93cae0281a683affa7;
                    outputLabel.Text = "The branch wasn't strong enough so you fall and don't wake up \nWould you like to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 21:
                    picturesLabel.Image = Properties.Resources.download;
                    outputLabel.Text = "Thank you for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                default:
                    picturesLabel.Image = Properties.Resources.download;
                    outputLabel.Text = "error";
                    break;
            }

        }
    }
}
