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
    public partial class UpperArmBack_Exercises : Form
    {
        String videoUrl;

        public UpperArmBack_Exercises()
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
                cB_Exercises.Items.Add("Bench Dips");
                cB_Exercises.Items.Add("Pike Push-Ups");
                cB_Exercises.Items.Add("L-Sits");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Bench Dips");
                cB_Exercises.Items.Add("Pike Push-Ups");
                cB_Exercises.Items.Add("L-Sits");
            }

            cB_Exercises.SelectedItem = "Bench Dips"; // sets default value
            cB_Exercises.SelectedItem = "Pike Push-Ups";
            cB_Exercises.SelectedItem = "L-Sits";

        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Bench Press");
                cB_Exercises.Items.Add("Cable Pushdown Reverse Grip");
                cB_Exercises.Items.Add("Tricep Dumbbell Kickback");
            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Bench Press");
                cB_Exercises.Items.Add("Cable Pushdown Reverse Grip");
                cB_Exercises.Items.Add("Tricep Dumbbell Kickback");
            }

            cB_Exercises.SelectedItem = "Bench Press"; // sets default value
            cB_Exercises.SelectedItem = "Cable Pushdown Reverse Grip";
            cB_Exercises.SelectedItem = "Tricep Dumbbell Kickback";

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
                    case "Bench Dips":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.BenchDips; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=c3ZGl4pAwZ4&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Place a bench behind your back. With the bench perpendicular to your body, hold on the bench on its edge. Extend your legs forward, bent at the waist and perpendicular to your torso. This is starting position. Slowly lower your body by bending at the elbows until you lower yourself far enough to where there is an angle slightly smaller than 90 degrees between the upper arm and forearm. Using your triceps to bring your torso up again, lift yourself back to the starting position. Repeat the exercise for a numnber of repetitions."; // sets description
                        break;


                    case "Pike Push-Ups":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.pikePushUps; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=x7_I5SUAd00&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Get down on your hands and feet, with hands shoulder-width apart, your legs and hands straight, and your hips up. Bend your elbows , until your arms form a 90 degree angle. Bring your head close to the mat. Straighten your elbows, pushing your body away from the mat, and return to the starting position. Repeat exercise for a number of repitions."
                            + " and repeat."; // sets description
                        break;

                    case "L-Sits":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.L_Sits;// sets image
                        videoUrl = "https://www.youtube.com/watch?v=qNj4luV93-4&feature=youtu.be";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "DStart in the position with your feets tucked underneath your body. Extend your hands to the ground. Make sure your arms are straight. Next, extend one leg out and lift your yourself off from the ground using your arms. extend the other leg while your are off from the ground. Hold for desired amount of time.";
                        break;

                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Bench Press":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.benchPress; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=rT7DgCr-3pg";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Lie back on a flat bench. Using a medium width grip, lift the bar from the rack and hold it straight over you with your arms locked. This will be starting position. From starting position, begin coming down slowly until the bar touches your chest. After a brief pause, push the bar back to the starting position. Repeat the movement for a prescribed amount of repetition. when you are done, plave the bar in the rack."; // sets description
                        break;

                    case "Cable Pushdown Reverse Grip":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.CablePushdownReverseGrip; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=2668NKYmls4";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Facing the bar attachment, grab it with the palms facing up at shoulder width. Lower the bar using your lats until your arm are fully extended by your side. This is starting position. Slowly elevate the bar up so it is aligned with your chest. Only the forearm should move and the elbows/upper arms should be stationary by your side at all times. Begin to lower the cable bar back down to the original starting position while contracting the triceps hard. Repeat for a number of repetitions."; // sets description
                        break;

                    case "Tricep Dumbbell Kickback":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.TricepDumbbellKickBack; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=6SS6K3lAwZ8";  // sets hyperlink
                        lbl_ExerciseDescription.Text = "Start with a dumbbell in each hand. Keep your back straight with a slight bend in the knees and bend forward at the waist. Your torso should be almost parallel to the floor. Keeping your head up, your upper arms should be close to your torso. Your forearm should be a 90 degree angle for between your for arm and upper arm. this starting position. While keeping your upper arm stationary, use your triceps to lift the weights until the arm is fully extended. After a pause, slowly lower the dumbbell back down to the starting position. Repeat for a number of repitions."; // sets description
                        break;

                    default: break;
                }
            }

            if (Form1.exList.contains("UpperArmBack - " + cB_Exercises.SelectedItem.ToString()))
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
        private void UpperArmBack_Exercises_Load(object sender, EventArgs e)
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
            String entry = "UpperArmBack - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.upperArmBack.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.upperArmBack.Hide();
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
                case "Bench Dips":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Pike Push-Ups":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "L-Sits":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Bench Press":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Cable Pushdown Reverse Grip":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Tricep Dumbbell Kickback":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name: " + ex); break;

            }
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void UpperArmBack_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}
