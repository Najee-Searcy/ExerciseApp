using System;
using System.Collections;
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
    public partial class ListOf_Exercises : Form
    {

        public static ExerciseList exList2 = new ExerciseList();
        ExerciseIterator exIterator2;

        public List<String> be = new List<String>();
       
      

        private void Composite()
      {
          

           
            BodyComponents chest = new BodyPart("CHEST");
            chest.add(new Exercise("Wide press-up", "Calisthenics"));
            chest.add(new Exercise("Diamond push-ups", "Calisthenics"));
            chest.add(new Exercise("Dips", "Calisthenics"));
            chest.add(new Exercise("Barbell Benchpress", "Weight Training"));
            chest.add(new Exercise("Dumbbell Flys", "Weight Training"));
            chest.add(new Exercise("Dumbbell Pullover", "Weight Training"));



            BodyComponents core = new BodyPart("CORE");
            core.add(new Exercise("Plank", "Calisthenics"));
            core.add(new Exercise("Deadbug", "Calisthenics"));
            core.add(new Exercise("Leg Lowers", "Calisthenics"));
            core.add(new Exercise("Hanging Leg Raise", "Calisthenics"));
            core.add(new Exercise("Side Jackknife", "Calisthenics"));
            core.add(new Exercise("Weighted Russian Twist", "Weight Training"));
            core.add(new Exercise("Dumbbell Sidebend", "Weight Training"));
            core.add(new Exercise("Woodchop", "Weight Training"));



            BodyComponents upperArm = new BodyPart("UPPER ARM");
            upperArm.add(new Exercise("Dynamic Tension Curls (Self-Resistance Curls)", "Calisthenics"));
            upperArm.add(new Exercise("Unassisted Chin-Up", "Calisthenics"));
            upperArm.add(new Exercise("Assisted Chin-Up", "Calisthenics"));
            upperArm.add(new Exercise("Barbell Curl", "Weighted Training"));
            upperArm.add(new Exercise("Dumbbell Bicep Curl", "Weighted Training"));
            upperArm.add(new Exercise("Alternate Incline Dumbbell Curl", "Weighted Training"));
            upperArm.add(new Exercise("Machine Preacher Curl", "Weighted Training"));

            BodyComponents lowerArm = new BodyPart("LOWER ARM");
            lowerArm.add(new Exercise("Pushup","Calisthenics"));
            lowerArm.add(new Exercise("Elevated Push-Up", "Calisthenics"));
            lowerArm.add(new Exercise("Plank Ups", "Calisthenics"));
            lowerArm.add(new Exercise("Pull-Ups", "Calisthenics"));
            lowerArm.add(new Exercise("Farmer's Walk","Weighted Training"));
            lowerArm.add(new Exercise("One-Arm Palm-Up Wrist Curl", "Weighted Training"));
            lowerArm.add(new Exercise("Palms-Up Wrist Curl", "Weighted Training"));
            lowerArm.add(new Exercise("One-Arm Palm-Down Wrist Curl", "Weighted Training"));
            lowerArm.add(new Exercise("Palms-Down Wrist Curl", "Weighted Training"));

            BodyComponents upperLeg = new BodyPart("UPPER LEG");
            upperLeg.add(new Exercise("Lunges","Calisthenics"));
            upperLeg.add(new Exercise("Squat", "Calisthenics"));
            upperLeg.add(new Exercise("Single Leg Bridge", "Calisthenics"));
            upperLeg.add(new Exercise("Pistol Squats", "Calisthenics"));
            upperLeg.add(new Exercise("Glute-Ham Raise", "Calisthenics"));
            upperLeg.add(new Exercise("Weight Squats", "Weighted Training"));
            upperLeg.add(new Exercise("Leg Press", "Weighted Training"));
            upperLeg.add(new Exercise("Deadlift", "Weighted Training"));
            upperLeg.add(new Exercise("Power Clean", "Weighted Training"));


            BodyComponents lowerLeg = new BodyPart("LOWER LEG");
            lowerLeg.add(new Exercise("Standing Calf Raise","Calisthenics"));
            lowerLeg.add(new Exercise("Reverse Calf Raise", "Calisthenics"));
            lowerLeg.add(new Exercise("Steal Jump", "Calisthenics"));
            lowerLeg.add(new Exercise("Donkey Calf Raise", "Calisthenics"));
            lowerLeg.add(new Exercise("Balance Board", "Calisthenics"));
            lowerLeg.add(new Exercise("Calf Press", "Weighted Training"));
            lowerLeg.add(new Exercise("Seated Calf Raise", "Weighted Trainging"));


            BodyComponents upperBack = new BodyPart("UPPER BACK");
            upperBack.add(new Exercise("Verticle Pull Up", "Calisthenics"));
            upperBack.add(new Exercise("Horizonal Pull Up", "Calisthenics"));
            upperBack.add(new Exercise("Truck Front Lever Hold", "Calisthenics"));
            upperBack.add(new Exercise("Weighted Back Extensions", "Weighted Training"));
            upperBack.add(new Exercise("Bent-Over Row", "Weighted Training"));
            upperBack.add(new Exercise("Lat Pulldown", "Weighted Training"));


            BodyComponents lowerBack = new BodyPart("LOWERBACK");
            lowerBack.add(new Exercise("Superman Hold", "Calisthenics"));
            lowerBack.add(new Exercise("Back Bridge", "Calisthenics"));
            lowerBack.add(new Exercise("Reverse Leg Lift", "Calisthenics"));
            lowerBack.add(new Exercise("Dead Lift", "Weighted Training"));
            lowerBack.add(new Exercise("Weighted Hyper Extensions", "Weighted Training"));
            lowerBack.add(new Exercise("Good Morning", "Weighted Training"));


            BodyComponents upperArmBack = new BodyPart("UPPER BACK ARM ");
            upperArmBack.add(new Exercise("Bench Dips", "Calisthenics"));
            upperArmBack.add(new Exercise("Pike Push-Ups", "Calisthenics"));
            upperArmBack.add(new Exercise("L-Sits", "Calisthenics"));
            upperArmBack.add(new Exercise("Bench Press", "Weighted Training"));
            upperArmBack.add(new Exercise("Cable Pushdown Reverse Grip", "Weighted Training"));
            upperArmBack.add(new Exercise("Tricep Dumbbell Kickback", "Weighted Training"));



            listBox1.Items.Add(exList2);
            exIterator2 = exList2.createIterator();
            if (listBox1.Items.Count == 0 && exList2.isEmpty() == true)
            {
                listBox1.Items.Add("List is empty.");
            }
            else
            {
                try
                {
                    listBox1.Items.Clear();
                    while (exIterator2.hasNext())
                    {
                       listBox1.Items.Add(exIterator2.next());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }



        public ListOf_Exercises()
        {
            InitializeComponent();
            Composite();
        }
      
       

        private void ListOf_Exercises_Load(object sender, EventArgs e)
        {
          
        }
  
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.listOfExercises.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Form1.listOfExercises.Hide();
        }

    }


}
