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
     * UpperArm_Exercises: This form displays suggested workouts that will
     * improve the user's upper arms
     * 
     * Contributor(s): ALL
     * */
    public partial class UpperArm_Exercises : Form
    {
        String videoUrl;

        public UpperArm_Exercises()
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
                cB_Exercises.Items.Add("Dynamic Tension Curls (Self-Resistance Curls)");
                cB_Exercises.Items.Add("Unassisted Chin-Up");
                cB_Exercises.Items.Add("Assisted Chin-Up");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Dynamic Tension Curls (Self-Resistance Curls)");
                cB_Exercises.Items.Add("Unassisted Chin-Up");
                cB_Exercises.Items.Add("Assisted Chin-Up");

            }

            cB_Exercises.SelectedItem = "Dynamic Tension Curls (Self-Resistance Curls)"; // sets default value


        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {


            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Barbell Curl");
                cB_Exercises.Items.Add("Dumbbell Bicep Curl");
                cB_Exercises.Items.Add("Alternate Incline Dumbbell Curl");
                cB_Exercises.Items.Add("Machine Preacher Curl");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Barbell Curl");
                cB_Exercises.Items.Add("Dumbbell Bicep Curl");
                cB_Exercises.Items.Add("Alternate Incline Dumbbell Curl");
                cB_Exercises.Items.Add("Machine Preacher Curl");

            }

            cB_Exercises.SelectedItem = "Barbell Curl"; // sets default value


        }


        /***
        * generate: When this method is called, an exercise is displayed
        * based on the information provided from the radio button and combo box controls
        * */
        private void generate() //Descriptions provided by bodybuilding.com
        {
            if (rB_Calisthenics.Checked == true)
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Dynamic Tension Curls (Self-Resistance Curls)":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dynamictensioncurls; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=cfIvLikFTQU"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Similar to doing a dumbbell bicep curl, but instead of using a weight, you use your off hand to resist or push down the working hand. You are curling the resistance added by your off arm."; // sets description
                        break;
                    case "Unassisted Chin-Up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.unassistedchinup; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=unGnP96HlEg"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Start by having your palms face you, instead of away from you (pull-up). This places the load of the movement on the biceps as opposed to the shoulders and back."; // sets description
                        break;
                    case "Assisted Chin-Up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.assistedchinup; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=ntVYkpoKRMQ"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Chin-Ups with the assistance of a machine. Make sure to pick an assistance level that allows you to correctly complete the movement without swinging your body up"; // sets description
                        break;


                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Barbell Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.barbellcurl; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=kwG2ipFRgfo"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out. Only the forearms should move."; // sets description
                        break;
                    case "Dumbbell Bicep Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dumbbellbicepcurl1; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=ykJmrZ5v0Oo"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Keeping the upper arms stationary, exhale and curl the weights while contracting your biceps. Continue to raise the weights until your biceps are fully contracted and the dumbbells are at shoulder level. Hold the contracted position for a brief pause as you squeeze your biceps."; // sets description
                        break;
                    case "Alternate Incline Dumbbell Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.alternateinclinedumbbellcurl; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=b4jOP-spQW8"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Similar to dumbbell bicep curl, but only one at a time while sitting on an incline."; // sets description
                        break;
                    case "Machine Preacher Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.machinepreachercurl; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=OJlTCY9GVVk"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "You can use free weights (barbells and dumbbells) to perform this exercise on a preacher bench. Alternatively, you can use the pulley machine as well in conjunction with a preacher bench."; // sets description
                        break;



                    default: break;
                }
            }

            if (Form1.exList.contains("UpperArm - " + cB_Exercises.SelectedItem.ToString()))
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

        /* *
         * Load: When the form loads, a calisthenics exercise is selected by default.
         * */
        private void UpperArm_Exercises_Load(object sender, EventArgs e)
        {
            rB_Calisthenics.Checked = true;
            rB_Calisthenics_CheckedChanged(sender, e);
            generate();
        }

        /* *
         * bt_Add_Click: When the "Add to List" button is clicked, this method sends the
         * exercise as a string value to the list in the main window.
         * */
        private void bt_Add_Click(object sender, EventArgs e)
        {
            String entry = "UpperArm - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.upperarm.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.upperarm.Hide();
        }

        /* *
         * cB_Exercises_SelectedValueChanged: When a new item is selected, the
         * option is add it to the list is made available
         * */
        private void cB_Exercises_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Form1.exList.contains(cB_Exercises.SelectedItem.ToString()) == false)
            {
                bt_Add.Enabled = true;
            }
            generate();
        }

        /* *
         * displayExercise: When called, this method displays an exercise based on the string value it was passed.
         * 
         * */
        public void displayExercise(String ex)
        {
            switch (ex)
            {
                case "Dynamic Tension Curls (Self-Resistance Curls)":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Unassisted Chin-Up":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Assisted Chin-Up":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Barbell Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dumbbell Bicep Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Alternate Incline Dumbbell Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Machine Preacher Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name: " + ex); break;

            }
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void UpperArm_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}