namespace Exercise_Demo
{
    partial class UpperArm_Exercises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cB_Exercises = new System.Windows.Forms.ComboBox();
            this.rB_Calisthenics = new System.Windows.Forms.RadioButton();
            this.rB_WeightTraining = new System.Windows.Forms.RadioButton();
            this.ll_VideoLink = new System.Windows.Forms.LinkLabel();
            this.lbl_ExerciseDescription = new System.Windows.Forms.Label();
            this.bt_Back = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.pB_PictureDemo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_PictureDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Exercises
            // 
            this.cB_Exercises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Exercises.FormattingEnabled = true;
            this.cB_Exercises.Location = new System.Drawing.Point(12, 91);
            this.cB_Exercises.Name = "cB_Exercises";
            this.cB_Exercises.Size = new System.Drawing.Size(147, 21);
            this.cB_Exercises.TabIndex = 2;
            this.cB_Exercises.SelectedValueChanged += new System.EventHandler(this.cB_Exercises_SelectedValueChanged);
            // 
            // rB_Calisthenics
            // 
            this.rB_Calisthenics.AutoSize = true;
            this.rB_Calisthenics.Location = new System.Drawing.Point(12, 12);
            this.rB_Calisthenics.Name = "rB_Calisthenics";
            this.rB_Calisthenics.Size = new System.Drawing.Size(81, 17);
            this.rB_Calisthenics.TabIndex = 3;
            this.rB_Calisthenics.TabStop = true;
            this.rB_Calisthenics.Text = "Calisthenics";
            this.rB_Calisthenics.UseVisualStyleBackColor = true;
            this.rB_Calisthenics.CheckedChanged += new System.EventHandler(this.rB_Calisthenics_CheckedChanged);
            // 
            // rB_WeightTraining
            // 
            this.rB_WeightTraining.AutoSize = true;
            this.rB_WeightTraining.Location = new System.Drawing.Point(12, 36);
            this.rB_WeightTraining.Name = "rB_WeightTraining";
            this.rB_WeightTraining.Size = new System.Drawing.Size(100, 17);
            this.rB_WeightTraining.TabIndex = 4;
            this.rB_WeightTraining.TabStop = true;
            this.rB_WeightTraining.Text = "Weight Training";
            this.rB_WeightTraining.UseVisualStyleBackColor = true;
            this.rB_WeightTraining.CheckedChanged += new System.EventHandler(this.rB_WeightTraining_CheckedChanged);
            // 
            // ll_VideoLink
            // 
            this.ll_VideoLink.AutoSize = true;
            this.ll_VideoLink.Location = new System.Drawing.Point(293, 265);
            this.ll_VideoLink.Name = "ll_VideoLink";
            this.ll_VideoLink.Size = new System.Drawing.Size(141, 13);
            this.ll_VideoLink.TabIndex = 5;
            this.ll_VideoLink.TabStop = true;
            this.ll_VideoLink.Text = "Instructional YouTube Video";
            this.ll_VideoLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_VideoLink_LinkClicked);
            // 
            // lbl_ExerciseDescription
            // 
            this.lbl_ExerciseDescription.Location = new System.Drawing.Point(165, 302);
            this.lbl_ExerciseDescription.Name = "lbl_ExerciseDescription";
            this.lbl_ExerciseDescription.Size = new System.Drawing.Size(401, 94);
            this.lbl_ExerciseDescription.TabIndex = 6;
            this.lbl_ExerciseDescription.Text = "Exercise description goes here.";
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(37, 378);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(75, 23);
            this.bt_Back.TabIndex = 12;
            this.bt_Back.Text = "Back";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(37, 240);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 11;
            this.bt_Add.Text = "Add To List";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // pB_PictureDemo
            // 
            this.pB_PictureDemo.Location = new System.Drawing.Point(165, 12);
            this.pB_PictureDemo.Name = "pB_PictureDemo";
            this.pB_PictureDemo.Size = new System.Drawing.Size(401, 250);
            this.pB_PictureDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_PictureDemo.TabIndex = 0;
            this.pB_PictureDemo.TabStop = false;
            // 
            // UpperArm_Exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.lbl_ExerciseDescription);
            this.Controls.Add(this.ll_VideoLink);
            this.Controls.Add(this.rB_WeightTraining);
            this.Controls.Add(this.rB_Calisthenics);
            this.Controls.Add(this.cB_Exercises);
            this.Controls.Add(this.pB_PictureDemo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpperArm_Exercises";
            this.Text = "UpperArm_Exercises";
            this.Activated += new System.EventHandler(this.UpperArm_Exercises_Activated);
            this.Load += new System.EventHandler(this.UpperArm_Exercises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_PictureDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_PictureDemo;
        private System.Windows.Forms.ComboBox cB_Exercises;
        private System.Windows.Forms.RadioButton rB_Calisthenics;
        private System.Windows.Forms.RadioButton rB_WeightTraining;
        private System.Windows.Forms.LinkLabel ll_VideoLink;
        private System.Windows.Forms.Label lbl_ExerciseDescription;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Button bt_Add;
    }
}