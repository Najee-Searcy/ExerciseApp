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
    public partial class Chest_Exercises : Form
    {
        String videoUrl;
        
        public Chest_Exercises()
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
                cB_Exercises.Items.Add("Wide press-up");
                cB_Exercises.Items.Add("Diamond push-up");
                cB_Exercises.Items.Add("Dips");

            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Wide press-up");
                cB_Exercises.Items.Add("Diamond push-up");
                cB_Exercises.Items.Add("Dips");
            }

            if (cB_Exercises.SelectedItem == null) {
                cB_Exercises.SelectedItem = "Wide press-up"; // sets default value
            }
            

        }

        /* *
         * rB_WeightTraining_CheckedChanged: When the radio button for weight training is clicked,
         * the appropriate options are added to the combo box
         * */
        private void rB_WeightTraining_CheckedChanged(object sender, EventArgs e)
        {

            if (cB_Exercises.Items.Count == 0) // check if combo box is empty
            {
                cB_Exercises.Items.Add("Barbell Benchpress");
                cB_Exercises.Items.Add("Dumbbell Flys");
                cB_Exercises.Items.Add("Dumbbell Pullover");
            }
            else
            {
                cB_Exercises.Items.Clear();
                cB_Exercises.Items.Add("Barbell Benchpress");
                cB_Exercises.Items.Add("Dumbbell Flys");
                cB_Exercises.Items.Add("Dumbbell Pullover");
            }

            if (cB_Exercises.SelectedItem == null) {
                cB_Exercises.SelectedItem = "Barbell Benchpress"; // sets default value
            }


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
                    case "Wide press-up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.wpu_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=rr6eFNNDQdU"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Perform a standard press-up, but with your hands placed wider than shoulder-width apart."; // sets description
                        break;


                    case "Diamond push-up":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dpu_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=pD3mD6WgykM"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Form a diamond with your hands, then do a standard push-up in this position until your chest touches the diamond. Then rise"
                            + " and repeat."; // sets description
                        break;

                    case "Dips":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dip_graphic;// sets image
                        videoUrl = "https://www.youtube.com/watch?v=sM6XUdt1rm4"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "In order to focus on chest, lean as far forward as comfortable while performing exercise.";
                        break;

                    default: break;
                }
            }
            else
            {
                switch (cB_Exercises.SelectedItem.ToString())
                {
                    case "Barbell Benchpress":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.bb_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=rT7DgCr-3pg"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Consider varying your grip width for more complete chest development."; // sets description
                        break;

                    case "Dumbbell Flys":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dbf_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=eozdVDA78K0"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "Make sure to hold the weights above you for a few seconds for best results."; // sets description
                        break;

                    case "Dumbbell Pullover":
                        pB_PictureDemo.Image = Exercise_Demo.Properties.Resources.dbp_graphic; // sets image
                        videoUrl = "https://www.youtube.com/watch?v=Ydpy886udzo"; // sets hyperlink
                        lbl_ExerciseDescription.Text = "When lowering the weight back behind the head, continue until you feel your lats stretching, then pull back over your chest."; // sets description
                        break;

                    default: break;
                }
            }

            if (Form1.exList.contains("Chest - " + cB_Exercises.SelectedItem.ToString()))
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
         * Load: When the form loads, a calisthenics exercise is selected by default.
         * */
        private void Chest_Exercises_Load(object sender, EventArgs e)
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
            String entry = "Chest - " + cB_Exercises.SelectedItem.ToString();
            Form1.exList.add(entry);
            bt_Add.Enabled = false;
        }

        /* *
         * bt_Back_Click: Hides form
         * */
        private void bt_Back_Click(object sender, EventArgs e)
        {
            Form1.chest.Hide();
        }

        /* *
         * OnFormClosing: Hides form instead of exiting.
         * */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.chest.Hide();
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
            switch(ex)
            {
                case "Wide press-up": rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Diamond push-up": rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dips": rB_Calisthenics.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Barbell Benchpress": rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dumbbell Flys": rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                case "Dumbbell Pullover": rB_WeightTraining.Checked = true; cB_Exercises.SelectedItem = ex; generate(); this.Show();
                    break;
                default: MessageBox.Show("Invalid Exercise Name"); break;

            }
        
        }

        /* *
         * Activated: when this is the active form, the generate method is called 
         * to refresh the form.
         * */
        private void Chest_Exercises_Activated(object sender, EventArgs e)
        {
            bt_Add.Enabled = true;
            generate();
        }
    }
}
