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
    /* *
     * UpperLeg_Exercises: This form displays suggested workouts that will
     * improve the user's upper legs
     * 
     * Contributor(s): ALL
     * */
    public partial class UpperLeg_Exercises : Form
    {
        String videoUrl;

        public UpperLeg_Exercises()
        {
            InitializeComponent();
        }

        /* *
         * rB_Calisthenics_CheckChanged: When the radio button for calisthenics is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_Calisthenics_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Lunges");
                cB_Exercises.Items.Add("Squats");
                cB_Exercises.Items.Add("Single Leg Bridge");
                cB_Exercises.Items.Add("Pistol Squats");
                cB_Exercises.Items.Add("Glute-Ham Raise");



            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Lunges");
                cB_Exercises.Items.Add("Squats");
                cB_Exercises.Items.Add("Single Leg Bridge");
                cB_Exercises.Items.Add("Pistol Squats");
                cB_Exercises.Items.Add("Glute-Ham Raise");

            }

            cB_Exercises.SelectedItem = "Lunges"; // sets default value
            cB_Exercises.SelectedItem = "Squats";
            cB_Exercises.SelectedItem = "Single Leg Bridge";
            cB_Exercises.SelectedItem = "Pistol Squats";
            cB_Exercises.SelectedItem = "Glute-Ham Raise";


        }

        /* *
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Weighted Squats");
                cB_Exercises.Items.Add("Leg Press");
                cB_Exercises.Items.Add("Deadlift");
                cB_Exercises.Items.Add("Power Clean");
            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Weighted Squats");
                cB_Exercises.Items.Add("Leg Press");
                cB_Exercises.Items.Add("Deadlift");
                cB_Exercises.Items.Add("Power Clean");
            }

            cB_Exercises.SelectedItem = "Weighted Squats"; // sets default value
            cB_Exercises.SelectedItem = "Leg Press";
            cB_Exercises.SelectedItem = "Deadlift";
            cB_Exercises.SelectedItem = "Power Clean";



        }

        /* *
        * generate: When this method is called, an exercise is displayed
        * based on the information provided from the radio button and combo box controls
        * */
        private void generate()
        {
            if (rB_Calisthenics.Checked == true)
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Lunges":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.lunge_graphic1; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=QOVaHwm-Q6U"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Make sure to keep your front knee vertical and that it does not go past your toes."; // sets description
                        break;

                    case "Squats":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.squat_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=aclHkVaku9U"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Make sure to avoid arching your back throughout the entire exercise."; // sets description
                        break;

                    case "Single Leg Bridge":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.singlelegbridge_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=3NXv0Nany-Q"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "For the best results, do not rest in between legs.(Rest after doing both legs)"; // sets description
                        break;

                    case "Pistol Squats":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.pistolsquat_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=7NvOuty_Fnc"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Use your extended arms to help balance while lowering and raising your body."; // sets description
                        break;

                    case "Glute-Ham Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.glutehamraise_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=lZbONXtf07g"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "If this exercise is too difficult at first, try using an exercise band until you are able to perform the exercise without it."; // sets description
                        break;



                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Weighted Squats":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.weightedsquat_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Dy28eq2PjcM"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Your feet should be about shoulder-width apart."; // sets description
                        break;

                    case "Leg Press":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.legpress_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=IZxyjW7MPJQ"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Make sure to keep your knees inline with your toes."; // sets description
                        break;

                    case "Deadlift":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.deadlift_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=op9kVnSso6Q"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Your shoulders should be slightly in front of the bar when before you have begun lifting."; // sets description
                        break;

                    case "Power Clean":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.powerclean_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=KjGvwQl8tis"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "This exercise is complex and we recommend practicing with lower weight until you are confident in your ability to perform the exercise correctly."; // sets description
                        break;



                    default: break;
                }
            }

            if (Form1.exList.contains("UpperLeg - " + cB_Exercises.SelectedItem.ToString()))
            {
                bt_Add.Enabled = false;
            }
            ll_VideoLink.LinkVisited = false; // restores link color
            ll_VideoLink.Show();
        }

        /* *
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
         * bt_Add_Click: When the "Add to List" button is clicked, this method sends the
         * exercise as a string value to the list in the main window.
         * */
        private void bt_Add_Click(object sender, EventArgs e)
        {
            String entry = "UpperLeg - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.upperleg.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.upperleg.Hide();
        }

        /* *
         * Load: When the form loads, a calisthenics exercise is selected by default.
         * */
        private void UpperLeg_Exercises_Load(object sender, EventArgs e)
        {
            rB_Calisthenics.Checked = true;
            rB_Calisthenics_CheckedChanged(sender, e);
            generate();
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
                case "Lunges":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Squats":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Single Leg Bridge":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Pistol Squats":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Glute-Ham Raise":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Weighted Squats":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Leg Press":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Deadlift":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Power Clean":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name: " + ex); break;

            }
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void UpperLeg_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}