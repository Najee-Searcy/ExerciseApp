using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Demo
{
    /****
     * Core_Exercises: This form displays suggested workouts that will
     * improve the user's core
     * 
     * Contributor(s): Jacob, Najee
     * */
    public partial class Core_Exercises : Form
    {
        String videoUrl;

        public Core_Exercises()
        {
            InitializeComponent();
        }


        /**
         * rB_Calisthenics_CheckChanged: When the radio button for calisthenics is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_Calisthenics_CheckedChanged(object sender, EventArgs e)
        {   

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Plank");
                cB_Exercises.Items.Add("Deadbug");
                cB_Exercises.Items.Add("Leg Lowers");
                cB_Exercises.Items.Add("Hanging Leg Raise");
                cB_Exercises.Items.Add("Side Jackknife");


            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Plank");
                cB_Exercises.Items.Add("Deadbug");
                cB_Exercises.Items.Add("Leg Lowers");
                cB_Exercises.Items.Add("Hanging Leg Raise");
                cB_Exercises.Items.Add("Side Jackknife");

            }

            cB_Exercises.SelectedItem = "Plank"; // sets default value
           

        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {
            

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Weighted Russian Twist");
                cB_Exercises.Items.Add("Dumbbell Sidebend");
                cB_Exercises.Items.Add("Woodchop");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Weighted Russian Twist");
                cB_Exercises.Items.Add("Dumbbell Sidebend");
                cB_Exercises.Items.Add("Woodchop");


            }

            cB_Exercises.SelectedItem = "Weighted Russian Twist"; // sets default value
           

        }

        

        /***
        * generate: When this method is called, an exercise is displayed
        * based on the information provided from the radio button and combo box controls
        * */
        private void generate()
        {
            if (rB_Calisthenics.Checked == true)
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Plank":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.plank_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=opbUwnQnR2U"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "For added difficulty and muscle activation, hold position for longer intervals."; // sets description
                        break;


                    case "Deadbug":
                          pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.deadbug; // sets image
                          videoUrl = "https://www.youtube.com/watch?v=CEMqETRl_fY"; // sets hyperlink
                          lbl_ExerciseDescription.Text = "Lie face-up with your arms extended toward the ceiling, directly over your shoulders" +
                            " and knees bent 90 degrees over hips, calves parallel to floor. Keeping your shoulders down and feet flexed, engage" +
                            "your core and extend your right arm and left leg away from you. Tap your heel to floor and return to center." + 
                            "Immediately repeat on the opposite side. Continue alternating sides for 16 reps total (eight on each side). " + 
                            "Try this move for three to four times a week to see results."; // sets description
                          break;
                    
                    case "Leg Lowers":
                         pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.leglowers;// sets image
                         videoUrl = "https://www.youtube.com/watch?v=TFTk1ige0xM"; // sets hyperlink
                         lbl_ExerciseDescription.Text = "Make sure back stays flat on floor and abs are tight (pull navel in towards spine)." + 
                            " Modify this exercise and reduce any back strain by ending the knees instead of keeping legs straight. ";
                         break;

                    case "Hanging Leg Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.hanginglegraise_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=hdng3Nm1x_E"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Rotating legs from side to side can be added for increased difficulty."; // sets description
                        break;

                    case "Side Jackknife":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.sidejackknife_graphic;// sets image
                        videoUrl = "https://www.youtube.com/watch?v=eLUSfdbxvF8"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "This exercise primarly focuses on your obliques.";
                        break;



                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Weighted Russian Twist":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.weightedrussiantwist_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Hn0sdqn2t7k"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Make sure to continue twist until your arms are parallel to the floor."; // sets description
                        break;

                     case "Dumbbell Sidebend":
                         pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dbsidebend_graphic; // sets image
                         videoUrl = "https://www.youtube.com/watch?v=_bVcLMlYZM8"; // sets hyperlink
                         lbl_ExerciseDescription.Text = "In order to target core, make sure to focus on keeping your chest up."; // sets description
                         break;

                     case "Woodchop":
                         pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.woodchop_graphic; // sets image
                         videoUrl = "https://www.youtube.com/watch?v=tH8ZeVgupYY"; // sets hyperlink
                         lbl_ExerciseDescription.Text = "Exercise can be done with a dumbbell, medicine ball, or a cable."; // sets description
                         break;
                         

                    default: break;
                }
            }

            if (Form1.exList.contains("Core - " + cB_Exercises.SelectedItem.ToString()))
            {
                bt_Add.Enabled = false;
            }
            ll_VideoLink.LinkVisited = false; // restores link color
            ll_VideoLink.Show();

        }

        /***
         * ll_VideoLink_LinkClicked: When the hyperlink is clicked, it attempts to called VisitLink()
         * which opens the YouTube video in the user's default web browser
         * */
        private void ll_VideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            ll_VideoLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start(videoUrl);
        }

        private void Core_Exercises_Load(object sender, EventArgs e)
        {
            rB_Calisthenics.Checked = true;
            rB_Calisthenics_CheckedChanged(sender, e);
            generate();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            String entry = "Core - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.core.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.core.Hide();
        }

        private void cB_Exercises_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Form1.exList.contains(cB_Exercises.SelectedItem.ToString()) == false)
            {
                bt_Add.Enabled = true;
            }
            generate();
        }

        public void displayExercise(String ex)
        {
            switch (ex)
            {
                case "Plank":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Deadbug":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Leg Lowers":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Hanging Leg Raise":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Side Jackknife":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Weighted Russian Twist": rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dumbbell Sidebend":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Woodchop":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name"); break;

            }
        }

        private void Core_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}
