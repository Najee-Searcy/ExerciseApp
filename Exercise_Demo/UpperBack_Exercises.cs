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
     * Contributor(s): ALL
     * */
    public partial class UpperBack_Exercises : Form
    {
        String videoUrl;

        public UpperBack_Exercises()
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
                cB_Exercises.Items.Add("Verticle Pull Up");
                cB_Exercises.Items.Add("Horizonal Pull Up");
                cB_Exercises.Items.Add("Truck Front Lever Hold");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Verticle Pull Up");
                cB_Exercises.Items.Add("Horizonal Pull Up");
                cB_Exercises.Items.Add("Truck Front Lever Hold");
            }

            cB_Exercises.SelectedItem = "Verticle Pull Up"; // sets default value
            cB_Exercises.SelectedItem = "Horizonal Pull Up";
            cB_Exercises.SelectedItem = "Truck Front Lever Hold";

        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Weighted Back Extensions");
                cB_Exercises.Items.Add("Bent-Over Row");
                cB_Exercises.Items.Add("Lat Pulldown");
            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Weighted Back Extensions");
                cB_Exercises.Items.Add("Bent-Over Row");
                cB_Exercises.Items.Add("Lat Pulldown");
            }

            cB_Exercises.SelectedItem = "Weighted Back Extensions"; // sets default value
            cB_Exercises.SelectedItem = "Bent-Over Row";
            cB_Exercises.SelectedItem = "Lat Pulldown";

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
                    case "Verticle Pull Up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.Verticle_Pull_Up; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=vA9zI-Y1I1s";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Grip the bar shoulder-width apart with straight arms for start position. Pull up by pulling your elbows to the floor. Keep pulling until your chin passes the bar. Lower yourself back down until your arms are straight again. Repeat exercise for a number of reps."; // sets description
                        break;


                    case "Horizonal Pull Up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.HorizonalPullUp; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=-cR3DaM0Nv0";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Grip bar shoulder-width  apart. Walk your feet forward util your body reach a horizonal position. Tighten your core to make a straight line from heels to the head. Do not let the body arch. Drive your elbows down and back. Keep your body tight through the complete movement. Pull to your chest. Repeat a number of repetions."
                            + " and repeat."; // sets description
                        break;

                    case "Truck Front Lever Hold":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.TruckFrontLeverHold;// sets image
                        videoUrl = "https://www.youtube.com/watch?v=nZNOMXBOXrw";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "In start position assume an inverted hand position on a pull-up bar or gym rings. Lower your body slowly down until completely horizonal (your body facing upwards). Maintain the hold as long as good form will allow.";
                        break;

                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Weighted Back Extensions":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.WeightedBackExtensions; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=nP820X_9_dk";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Lie face down on a hyperextension bench, tucking you ankles securely under the footpads. Adjust upper pad if possible to allow your thighs to lie flat across the wide pad. With your body straight grab barbell or dumbbells. Start bending forward slowly at the waist, keeping your back staight. Slowly raise your torso back to the initial position. Repeat as necessary for a number of repetions."; // sets description
                        break;

                    case "Bent-Over Row":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.bentOverRow; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=QFq5jdwWwX4";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Hold a barbell with a pronated grip(palms facing down), bend your knees slightly and bring your torso forward, by bending at the waist, while keeping your back straight. Tip: Make sure you keep your head up. This is your starting position. Keeping your torso stationary, lift the barbell to you. keep the elbows close to the body and only use the forarms to hold weight. Slowly lower the barbell back in starting position. Repeat for a recommended amount of repetitions."; // sets description
                        break;

                    case "Lat Pulldown":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.latPulldown; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=xsHAG5rSzeM";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Adjust the pad so it sits snugly on your thighs to minimise movement. Grip the bar with a wide grip, looking forward with your torso upright. Pull the bar down in front of you to your upper chest. Slowly raise back to start position. Repeat for a number of repetitions."; // sets description
                        break;

                    default: break;
                }
            }

            if (Form1.exList.contains("UpperBack - " + cB_Exercises.SelectedItem.ToString()))
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
        private void UpperBack_Exercises_Load(object sender, EventArgs e)
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
            String entry = "UpperBack - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.upperBack.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.upperBack.Hide();
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
                case "Verticle Pull Up":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Horizonal Pull Up":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Truck Front Lever Hold":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Weighted Back Extensions":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Bent-Over Row":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Lat Pulldown":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name: " + ex); break;

            }
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void UpperBack_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}
