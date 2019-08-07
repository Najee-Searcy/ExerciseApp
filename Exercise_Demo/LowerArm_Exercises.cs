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
     * LowerArm_Exercises: This form displays suggested workouts that will
     * improve the user's lower arms
     * 
     * Contributor(s): Jacob, Najee, Wyatt
     * */
    public partial class LowerArm_Exercises : Form
    {
        String videoUrl;

        public LowerArm_Exercises()
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
                
                cB_Exercises.Items.Add("Elevated Push-Up");
                cB_Exercises.Items.Add("Plank Ups");
                cB_Exercises.Items.Add("Pull-Ups");


            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Pushup");
                cB_Exercises.Items.Add("Elevated Push-Up");
                cB_Exercises.Items.Add("Plank Ups");
                cB_Exercises.Items.Add("Pull-Ups");

            }

            cB_Exercises.SelectedItem = "Pushup"; // sets default value


        }

        /**
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Farmer's Walk");
                cB_Exercises.Items.Add("One-Arm Palm-Up Wrist Curl");
                cB_Exercises.Items.Add("Palms-Up Wrist Curl");
                cB_Exercises.Items.Add("One-Arm Palm-Down Wrist Curl");
                cB_Exercises.Items.Add("Palms-Down Wrist Curl");


            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Farmer's Walk");
                cB_Exercises.Items.Add("One-Arm Palm-Up Wrist Curl");
                cB_Exercises.Items.Add("Palms-Up Wrist Curl");
                cB_Exercises.Items.Add("One-Arm Palm-Down Wrist Curl");
                cB_Exercises.Items.Add("Palms-Down Wrist Curl");

            }

            cB_Exercises.SelectedItem = "Farmer's Walk"; // sets default value



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
                    case "Pushup":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.pushup_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Eh00_rniF8E"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "1.) Place your hands on the ground about shoulder-width apart, and put your feet slightly apart on your toes." +
                        "\n2.) Lower your body toward the ground until your chest and hip are almost touching it.Keep your head in alignment with your spine and hip. Tighten your buttocks to keep your alignment." +
                        "\n3.) Exhale and push yourself up.Do not stick your neck forward or hyperextend your lower back.Perform three sets of 10 to 15 reps."; // sets description
                        break;
                    case "Elevated Push-Up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.elevatedpushup;
                        videoUrl = "https://www.youtube.com/watch?v=HmZcKSDlIYc";
                        lbl_ExerciseDescription.Text = "1) Start in high plank with your hands resting on a low box, bench, step, or couch." +
                        "\n2) Keeping your elbows close to your torso, bend your arms and lower your chest to meet the top of the box." +
                        "\n3) Be sure to keep your core tight and spine long.Then, push through your palms to straighten arms.";
                        break;//Description from:https://www.self.com/gallery/sexy-arms-no-equipment-slideshow
                    case "Plank Ups":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.plankup;
                        videoUrl = "https://www.youtube.com/watch?v=L4oFJRDAU4Q";
                        lbl_ExerciseDescription.Text = "1) Start in high plank. Bend one arm to bring your elbow and your forearm to the floor." +
                        "\n2) Bring the other arm down so you are in a forearm plank." +
                        "\n3) Push back up to the start position, placing each hand where your elbows were." +
                        "\n4) Repeat this movement, alternating which side you lower first with each rep.";
                        break;//Description from:https://www.self.com/gallery/sexy-arms-no-equipment-slideshow
                    case "Pull-Ups":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.pullup;
                        videoUrl = "https://www.youtube.com/watch?v=n1q-lAzAWms";
                        lbl_ExerciseDescription.Text = "This exercise works more of your upper arms than it does your lower arms, but the lower arms are still utilized in pulling your body weight up and over the bar.";
                        break;



                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Farmer's Walk":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.farmerswalk_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Fkzk_RqlYig"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Start by choosing your variation of the Farmer’s walk – dumbbells (heavy), short barbells etc." +
                        "\na) Begin this exercise by positioning yourself in-between your weights choice" +
                        "\nb) Lower yourself down and grip the handles firmly" +
                        "\nc) Keeping your back straight and head forward, power through your heels to raise yourself up" +
                        "\nd) Steps should be short – move forward quickly for the furthest distance available in your gym/training area (take frequent breaths!)"; // sets description
                        break;
                    case "One-Arm Palm-Up Wrist Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.onearmpalmupwristcurl;
                        videoUrl = "https://www.youtube.com/watch?v=5iSVEUa2T0Y";
                        lbl_ExerciseDescription.Text = "1) Sit on one end of a bench and hold one dumbbell with one hand, wrist against your knee, palm facing up." +
                        "\n2) Raise one dumbbell up by raising only your hand and slowly lower it back down after a short pause. Alternate hands after a set." +
                        "\n3) Keep your arms still throughout.";//Description from:https://dumbbell-exercises.com/exercises/forearms/
                        break;
                    case "Palms-Up Wrist Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.palmsupwristcurl;
                        videoUrl = "https://www.youtube.com/watch?v=R5A5ODRSLXo";
                        lbl_ExerciseDescription.Text = "1) Sit on one end of a bench and hold one dumbbell on each hand, wrists against your knees, palms facing up." +
                        "\n2) Raise the dumbbells or barbell up by raising only your hands and slowly lower them back down after a short pause." +
                        "\n3) Keep your arms still throughout.";//Description from:https://dumbbell-exercises.com/exercises/forearms/
                        break;
                    case "One-Arm Palm-Down Wrist Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.onearmpalmdownwristcurl;
                        videoUrl = "https://www.youtube.com/watch?v=FfjD0YriJEM";
                        lbl_ExerciseDescription.Text = "1) Sit on one end of a bench and hold one dumbbell with one hand, wrist against your knee, palm facing down." +
                        "\n2) Raise one dumbbell up by raising only your hand and slowly lower it back down after a short pause. Alternate hands after a set." +
                        "\n3) Keep your arms still throughout.";//Description from:https://dumbbell-exercises.com/exercises/forearms/
                        break;
                    case "Palms-Down Wrist Curl":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.palmsdownwristcurl;
                        videoUrl = "https://www.youtube.com/watch?v=oa51kB8pDmo";
                        lbl_ExerciseDescription.Text = "1) Sit on one end of a bench and hold one dumbbell on each hand, wrists against your knees, palms facing down." +
                        "\n2) Raise the dumbbells or barbell up by raising only your hands and slowly lower them back down after a short pause." +
                        "\n3) Keep your arms still throughout.";//Description from:https://dumbbell-exercises.com/exercises/forearms/
                        break;

                    default: break;
                }
            }

            if (Form1.exList.contains("LowerArm - " + cB_Exercises.SelectedItem.ToString()))
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
            String entry = "LowerArm - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.lowerarm.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.lowerarm.Hide();
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
                case "Pushup":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Elevated Push-Up":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Plank Ups":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Pull-Ups":
                    rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Farmer's Walk":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "One-Arm Palm-Up Wrist Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Palms-Up Wrist Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "One-Arm Palm-Down Wrist Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Palms-Down Wrist Curl":
                    rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name"); break;

            }
        }

        private void LowerArm_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}