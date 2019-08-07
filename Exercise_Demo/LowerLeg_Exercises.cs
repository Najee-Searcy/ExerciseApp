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
     * LowerLeg_Exercises: This form displays suggested workouts that will
     * improve the user's lower legs
     * 
     * Contributor(s): ALL
     * */
    public partial class LowerLeg_Exercises : Form
    {
        String videoUrl;

        public LowerLeg_Exercises()
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
                cB_Exercises.Items.Add("Standing Calf Raise");
                cB_Exercises.Items.Add("Reverse Calf Raise");
                cB_Exercises.Items.Add("Seal Jump");
                cB_Exercises.Items.Add("Donkey Calf Raise");
                cB_Exercises.Items.Add("Balance Board");


            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Standing Calf Raise");
                cB_Exercises.Items.Add("Reverse Calf Raise");
                cB_Exercises.Items.Add("Seal Jump");
                cB_Exercises.Items.Add("Donkey Calf Raise");
                cB_Exercises.Items.Add("Balance Board");

            }

            cB_Exercises.SelectedItem = "Standing Calf Raise"; // sets default value


        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Calf Press");
                cB_Exercises.Items.Add("Seated Calf Raise");


            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Calf Press");
                cB_Exercises.Items.Add("Seated Calf Raise");


            }

            cB_Exercises.SelectedItem = "Calf Press"; // sets default value


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
                    case "Standing Calf Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.scr_graphic; //sets image
                        videoUrl = "https://www.youtube.com/watch?v=-M4-G8p8fmc"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Stand straight and push up with the front of your feet so the heels do not touch the ground.  Can also be done as a weight training exercise using a Smith Machine."; // sets description
                        break;

                    case "Reverse Calf Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.rcr_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Xp7x-2L9N9Q"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Have your heels on an elevated object and raise the front of your feet.  Can also be done as a weight training exercise using a Smith Machine."; // sets description
                        break;

                    case "Seal Jump":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.sj_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=opbUwnQnR2U"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "For added difficulty and muscle activation, hold position for longer intervals."; // sets description
                        break;

                    case "Donkey Calf Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dcr_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=r30EoMPSNns"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Similar to a standing calf raise, but this time you will have your back and legs at a 90 degree angle."; // sets description
                        break;

                    case "Balance Board":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.balb_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=BPMEj-jeH9w"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "This workout is simple, you just balance on a balance board."; // sets description
                        break;


                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Calf Press":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.cp_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=IrxfRHGiGE0"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Use your toes to push the platfrom."; // sets description
                        break;

                    case "Seated Calf Raise":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.stcr_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=YhiXK53vde0"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Can be done like above with dumbbells, or with your body weight in a squat position."; // sets description
                        break;


                    default: break;
                }
            }

            if (Form1.exList.contains("LowerLeg - " + cB_Exercises.SelectedItem.ToString()))
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
        private void LowerLeg_Exercises_Load(object sender, EventArgs e)
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
            String entry = "LowerLeg - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.lowerleg.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.lowerleg.Hide();
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
                case "Standing Calf Raise":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Reverse Calf Raise":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Seal Jump":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Donkey Calf Raise":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Balance Board":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Calf Press":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Seated Calf Raise":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name"); break;

            }
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void LowerLeg_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}