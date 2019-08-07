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
     * Chest_Exercises: This form displays suggested workouts that will
     * improve the user's pectorals
     * 
     * Contributor(s): Najee,Jacob
     * */
    public partial class LowerBack_Exercises : Form
    {
        String videoUrl;

        public LowerBack_Exercises()
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
                cB_Exercises.Items.Add("Superman Hold");
                cB_Exercises.Items.Add("Back Bridge");
                cB_Exercises.Items.Add("Reverse Leg Lift");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Superman Hold");
                cB_Exercises.Items.Add("Back Bridge");
                cB_Exercises.Items.Add("Reverse Leg Lift");
            }

            cB_Exercises.SelectedItem = "Superman Hold"; // sets default value
            cB_Exercises.SelectedItem = "Back Bridge";
            cB_Exercises.SelectedItem = "Reverse Leg Lift";

        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Dead Lift");
                cB_Exercises.Items.Add("Weighted Hyper Extensions");
                cB_Exercises.Items.Add("Good Morning");
            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Dead Lift");
                cB_Exercises.Items.Add("Weighted Hyper Extensions");
                cB_Exercises.Items.Add("Good Morning");
            }

            cB_Exercises.SelectedItem = "Dead Lift"; // sets default value
            cB_Exercises.SelectedItem = "Weighted Hyper Extensions";
            cB_Exercises.SelectedItem = "Good Morning";

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
                    case "Superman Hold":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.superManHoldsPic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=VUT1RHyMEuc&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Lie straight and face down on the floor or exercise mat. Extend arms in front of you in start position. Simultaneously raise your arms, legs, and chest off of the floor and hold for 2 seconds. Slowly begin to lower your arms, legs, and chest back down to start position. Repeat for a number of repetions."; // sets description
                        break;


                    case "Back Bridge":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.backBridge; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=DyjaVoxirkk&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Lay on back with your hands by your side, your knees bent, and feet on the floor. While making sure your feet is under your knees, Tighten your abdominal and buttock muscles and raise your hips up. Maintain a straight line from your shoulders to your knees and hold for 20 seconds. Repeat for a number of repetions.";
                        // sets description
                        break;

                    case "Reverse Leg Lift":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.reverseLegLift;// sets image
                        videoUrl = "https://www.youtube.com/watch?v=U765-0BOLP0&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Start by laying face down on the exercise bench. Fully extend arms and legs. Lift your legs as high as you can and hold for a second. Return to starting position and repeat. ";
                        break;

                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Dead Lift":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.deadLift; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=op9kVnSso6Q";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "With feet flat beneat bar, squat down and grasp bar. lift bar by extending hips and knees to full extension. Pull shoulders back on top of lift if rounded. Return weights back to the floor while keeping your back straight and knees bent. Repeat a number of repetions "; // sets description
                        break;

                    case "Weighted Hyper Extensions":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.weightedHyperExtensions; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=J6QVRADMPm8";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Begin with your torso pressing agianst the bench parallel to the floor. While holding some form or weights, slowly raise your torso up by bending at the waist and lower back. Repeat a number of repitions"; // sets description
                        break;

                    case "Good Morning":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.goodMorning; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=xUZRtvrJgSg";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Stand with your feet shoulder-width apart. Rest a light barbell across the back of your shoulders, not your neck. hinge forward from your hips, not waist. slightly bend your knees and back straight. Repeat a number of repitions. "; // sets description
                        break;

                    default: break;
                }
            }

            if (Form1.exList.contains("LowerBack - " + cB_Exercises.SelectedItem.ToString()))
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

        private void LowerBack_Exercises_Load(object sender, EventArgs e)
        {
            rB_Calisthenics.Checked = true;
            rB_Calisthenics_CheckedChanged(sender, e);
            generate();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            String entry = "LowerBack - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.lowerBack.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.lowerBack.Hide();
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
                case "Superman Hold":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Back Bridge":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Reverse Leg Lift":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dead Lift":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Weighted Hyper Extensions":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Good Morning":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name"); break;

            }
        }

        private void LowerBack_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}
