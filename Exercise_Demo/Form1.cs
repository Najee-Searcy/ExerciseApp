using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This program gives the user the option to generate several exercises that strengthen a specific region of the human body. The GUI allows
/// the user to choose from nine different regions based on an image that contains a diagram of the body (front and back). From there, exercises
/// for that region are displayed in a new window. The new windows also contains the option to save a specific exercise to list for quick access.
/// 
/// Factory/Singleton Pattern: used to manage the form objects that contain exercises for a targeted body region.
/// Iterator Pattern: used to manange a list of exercises used for quick access.
/// Composite Pattern: used to contain a glossary of all exercises available in the program.
/// 
/// Contributor(s): ALL
/// </summary>
namespace Exercise_Demo
{   
    public partial class Form1 : Form
    {
        Image bodyView;
        public static IFactory chest = FactorySingleton.GetFactory.GetExercise("Chest");
        public static IFactory upperarm = FactorySingleton.GetFactory.GetExercise("UpperArm");
        public static IFactory lowerarm = FactorySingleton.GetFactory.GetExercise("LowerArm");
        public static IFactory core = FactorySingleton.GetFactory.GetExercise("Core");
        public static IFactory upperleg = FactorySingleton.GetFactory.GetExercise("UpperLeg");
        public static IFactory lowerleg = FactorySingleton.GetFactory.GetExercise("LowerLeg");
        public static IFactory lowerBack = FactorySingleton.GetFactory.GetExercise("LowerBack");
        public static IFactory upperBack = FactorySingleton.GetFactory.GetExercise("UpperBack");
        public static IFactory listOfExercises = FactorySingleton.GetFactory.GetExercise("ListOfExercises");
        public static IFactory upperArmBack = FactorySingleton.GetFactory.GetExercise("UpperArmBack");
        public static ExerciseList exList = new ExerciseList();
        ExerciseIterator exIterator;

        public Form1()
        {
            InitializeComponent();

        }

        /* *
         * pB_Body_Click: When the user clicks inside of the picture box, the color of the pixel clicked is
         * compared with the color value stored for a body section.
         * */
        private void pB_Body_Click(object sender, MouseEventArgs e)
        {
            int chestCV = ColorTranslator.FromHtml("#FF00CC99").ToArgb();
            int upperBackCV = ColorTranslator.FromHtml("#FFFF6600").ToArgb();
            int coreCV = ColorTranslator.FromHtml("#FF00FF99").ToArgb();
            int lowerBackCV = ColorTranslator.FromHtml("#FFFF9933").ToArgb();
            int upperArmFrontCV = ColorTranslator.FromHtml("#FF00CCCC").ToArgb();
            int upperArmBackCV = ColorTranslator.FromHtml("#FFFF3300").ToArgb();
            int lowerArmFrontCV = ColorTranslator.FromHtml("#FF00CCFF").ToArgb();
            int lowerArmBackCV = ColorTranslator.FromHtml("#FFFF9966").ToArgb();
            int upperLegFrontCV = ColorTranslator.FromHtml("#FF00FFCC").ToArgb();
            int upperLegBackCV = ColorTranslator.FromHtml("#FFFFCC66").ToArgb();
            int lowerLegFrontCV = ColorTranslator.FromHtml("#FF99FFFF").ToArgb();
            int lowerLegBackCV = ColorTranslator.FromHtml("#FFFFFF99").ToArgb();

            using (var bmp = new Bitmap(bodyView))
            {
                if (e.X < bodyView.Width && e.Y < bodyView.Height) // checks to see if the mouse was clicked inside of the image
                {
                    var colorAtMouse = bmp.GetPixel(e.X, e.Y); // gets the pixel clicked

                    if (colorAtMouse.ToArgb() == chestCV) // Compares the pixel (colorAtMouse) with color value assigned to the chest area (#FF00CC99)
                    {
                        chest.Show();
                    }
                    else if (colorAtMouse.ToArgb() == upperArmFrontCV)
                    {
                        upperarm.Show();
                    }
                    else if (colorAtMouse.ToArgb() == lowerArmFrontCV || colorAtMouse.ToArgb() == lowerArmBackCV) // || back color for lower arm 
                    {
                        lowerarm.Show();
                    }
                    else if (colorAtMouse.ToArgb() == coreCV) // || back color for core
                    {
                        core.Show();
                    }
                    else if (colorAtMouse.ToArgb() == upperLegFrontCV || colorAtMouse.ToArgb() == upperLegBackCV)
                    {
                        upperleg.Show();
                    }
                    else if (colorAtMouse.ToArgb() == lowerLegFrontCV || colorAtMouse.ToArgb() == lowerLegBackCV)// || back color for lower leg
                    {
                        lowerleg.Show();
                    }
                    else if (colorAtMouse.ToArgb() == lowerBackCV)
                    {
                        lowerBack.Show();
                    }
                    else if (colorAtMouse.ToArgb() == upperBackCV)
                    {

                        upperBack.Show();
                    }
                    else if (colorAtMouse.ToArgb() == upperArmBackCV)
                    {
                        upperArmBack.Show();
                        
                    }

                }
            }


        }

        /* *
         * Form1_Load: When this form is loaded, the body image is set to front by default.
         * The option to delete an item from the empty list is disabled, and clear list button shown.
         * */
        private void Form1_Load(object sender, EventArgs e)
        {
            bodyView = pB_Body.Image;
            //bt_DeleteSelected.Enabled = false;
            //bt_Clear.Show();
        }

        /* *
         * btShowBack_Click: When this button is clicked, a rear view of the body is shown.
         * 
         * */
        private void btShowBack_Click(object sender, EventArgs e)
        {
            pB_Body.SendToBack();
            bodyView = pB_BodyBack.Image;
            btShowBack.Hide();
        }

        /* *
         * btShowFront_Click: When this button is clicked, a front view of the body is shown.
         * */
        private void btShowFront_Click(object sender, EventArgs e)
        {
            pB_Body.BringToFront();
            bodyView = pB_Body.Image;
            btShowBack.Show();
        }

        /* *
         * ReloadList: Displays the latest data in the list of exercises using the Iterator pattern.
         * */
        private void ReloadList()
        {
            exIterator = exList.createIterator();
            if (lb_Exercises.Items.Count == 0 && exList.isEmpty() == true)
            {
                // do nothing.
            }
            else
            {
                try
                {
                    lb_Exercises.Items.Clear();
                    while (exIterator.hasNext())
                    {
                        lb_Exercises.Items.Add(exIterator.next());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /* *
         * bt_Clear_Click: When this button is clicked, the list of exercises is emptied.
         * */
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            exList.clear();
            lb_Exercises.Items.Clear();
            ReloadList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfExercises.Show();
        }

        /* *
         * Form1_Activated: When this form is the active form, the list is reloaded
         * */
        private void Form1_Activated(object sender, EventArgs e)
        {
            ReloadList();
            if(lb_Exercises.Items.Count > 0)
            {
                bt_DeleteSelected.Enabled = true;
            }
        }

        /* *
         * lb_Exercises: When an item in the exercise list is double clicked, the appropriated exercise form is opened
         * with that exercise displayed.
         * */
        private void lb_Exercises_DoubleClick(object sender, EventArgs e)
        {
            if(lb_Exercises.Items.Count == 0 || lb_Exercises.SelectedItem == null)
            {
                // do nothing.
            } else
            {
                //lb_Exercises.SelectedItem.ToString().
                String ex = lb_Exercises.SelectedItem.ToString();
                if (ex.Contains("Chest - "))
                {
                    chest.DisplayExercise(ex.Substring(8));
                }
                else if (ex.Contains("UpperArm - "))
                {
                    upperarm.DisplayExercise(ex.Substring(11));
                }
                else if (ex.Contains("LowerArm - "))
                {
                    lowerarm.DisplayExercise(ex.Substring(11));
                }
                else if (ex.Contains("Core - "))
                {
                    core.DisplayExercise(ex.Substring(7));
                }
                else if (ex.Contains("UpperLeg - "))
                {
                    upperleg.DisplayExercise(ex.Substring(11));
                }
                else if (ex.Contains("LowerLeg - "))
                {
                    lowerleg.DisplayExercise(ex.Substring(11));
                }
                else if (ex.Contains("LowerBack - "))
                {
                    lowerBack.DisplayExercise(ex.Substring(12));
                }
                else if (ex.Contains("UpperBack - "))
                {
                    upperBack.DisplayExercise(ex.Substring(12));
                }
                else if (ex.Contains("UpperArmBack - "))
                {
                    upperArmBack.DisplayExercise(ex.Substring(15));
                }

            }
        }

        /* *
         * bt_DeleteSelected_Click: When this button is clicked, the selected item is deleted
         * from the list.
         * */
        private void bt_DeleteSelected_Click(object sender, EventArgs e)
        {
            if(lb_Exercises.SelectedItem == null)
            {
                // do nothing.
            } else
            {
                exList.remove(lb_Exercises.SelectedItem.ToString());
                lb_Exercises.Items.Remove(lb_Exercises.SelectedItem);
            }
        }
    }

    /* * * * * * * * * * * * * * * * * * * * * * * *
     * The Code below this point pertains to the Factory and Singleton design patterns.
     *
     * * * * * * * * * * * * * * * * * * * * * * * */

    public interface IFactory
    {
        void Show();
        void Hide();
        void DisplayExercise(String ex);
    }

    public class Chest : IFactory
    {
        Chest_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new Chest_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new Chest_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class UpperArm : IFactory
    {
        UpperArm_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new UpperArm_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new UpperArm_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }

    }

    public class LowerArm : IFactory
    {
        LowerArm_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new LowerArm_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new LowerArm_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class Core : IFactory
    {
        Core_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new Core_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new Core_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }


    }

    public class UpperLeg : IFactory
    {
        UpperLeg_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new UpperLeg_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new UpperLeg_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class LowerLeg : IFactory
    {
        LowerLeg_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new LowerLeg_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new LowerLeg_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class UpperBack : IFactory
    {
        UpperBack_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new UpperBack_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new UpperBack_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class LowerBack : IFactory
    {
        LowerBack_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new LowerBack_Exercises();
                form.Show();
            }
            
        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new LowerBack_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public class ListOfExercises : IFactory
    {
        ListOf_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new ListOf_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new ListOf_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
        }
    }

    public class UpperArmBack : IFactory
    {
        UpperArmBack_Exercises form;

        public void Show()
        {
            if (form != null)
            {
                form.Show();
            }
            else
            {
                form = new UpperArmBack_Exercises();
                form.Show();
            }

        }

        public void Hide()
        {
            if (form != null)
            {
                form.Hide();
            }
            else
            {
                form = new UpperArmBack_Exercises();
                form.Hide();
            }
        }

        public void DisplayExercise(String ex)
        {
            form.displayExercise(ex);
        }
    }

    public abstract class BodyFactory
    {
        public abstract IFactory GetExercise(String Body);
    }

    public sealed class FactorySingleton : BodyFactory
    {
        private static FactorySingleton instance;
        private FactorySingleton() { }
        Chest ch = new Chest();
        UpperArm ua = new UpperArm();
        LowerArm la = new LowerArm();
        Core co = new Core();
        UpperLeg ul = new UpperLeg();
        LowerLeg ll = new LowerLeg();
        LowerBack lb = new LowerBack();
        UpperBack ub = new UpperBack();
        UpperArmBack uab = new UpperArmBack();
        ListOfExercises loe = new ListOfExercises();

        public static FactorySingleton GetFactory
        {
            get
            {
                if (instance == null)
                {
                    instance = new FactorySingleton();
                }
                return instance;
            }
        }


        public override IFactory GetExercise(String Body)
        {
            switch (Body)
            {
                case "Chest":
                    return ch;
                case "UpperArm":
                    return ua;
                case "LowerArm":
                    return la;
                case "Core":
                    return co;
                case "UpperLeg":
                    return ul;
                case "LowerLeg":
                    return ll;
                case "LowerBack":
                    return lb;
                case "UpperBack":
                    return ub;
                case "UpperArmBack":
                    return uab;
                case "ListOfExercises":
                    return loe;
                default:
                    throw new ApplicationException(string.Format("Body part cannot be created", Body));
            }
        }
    }
}
