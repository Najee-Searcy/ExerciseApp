namespace Exercise_Demo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_DeleteSelected = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.btShowBack = new System.Windows.Forms.Button();
            this.btShowFront = new System.Windows.Forms.Button();
            this.lb_Exercises = new System.Windows.Forms.ListBox();
            this.pB_Body = new System.Windows.Forms.PictureBox();
            this.pB_BodyBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_BodyBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.bt_DeleteSelected);
            this.panel1.Controls.Add(this.bt_Clear);
            this.panel1.Controls.Add(this.btShowBack);
            this.panel1.Controls.Add(this.btShowFront);
            this.panel1.Controls.Add(this.lb_Exercises);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 561);
            this.panel1.TabIndex = 2;
            // 
            // bt_DeleteSelected
            // 
            this.bt_DeleteSelected.Location = new System.Drawing.Point(65, 331);
            this.bt_DeleteSelected.Name = "bt_DeleteSelected";
            this.bt_DeleteSelected.Size = new System.Drawing.Size(75, 37);
            this.bt_DeleteSelected.TabIndex = 5;
            this.bt_DeleteSelected.Text = "Delete Selected";
            this.bt_DeleteSelected.UseVisualStyleBackColor = true;
            this.bt_DeleteSelected.Click += new System.EventHandler(this.bt_DeleteSelected_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(65, 374);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.bt_Clear.TabIndex = 6;
            this.bt_Clear.Text = "Clear List";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // btShowBack
            // 
            this.btShowBack.BackColor = System.Drawing.SystemColors.Control;
            this.btShowBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btShowBack.Location = new System.Drawing.Point(65, 13);
            this.btShowBack.Name = "btShowBack";
            this.btShowBack.Size = new System.Drawing.Size(75, 23);
            this.btShowBack.TabIndex = 4;
            this.btShowBack.Text = "Show Back";
            this.btShowBack.UseVisualStyleBackColor = false;
            this.btShowBack.Click += new System.EventHandler(this.btShowBack_Click);
            // 
            // btShowFront
            // 
            this.btShowFront.Location = new System.Drawing.Point(65, 13);
            this.btShowFront.Name = "btShowFront";
            this.btShowFront.Size = new System.Drawing.Size(75, 23);
            this.btShowFront.TabIndex = 5;
            this.btShowFront.Text = "Show Front";
            this.btShowFront.UseVisualStyleBackColor = true;
            this.btShowFront.Click += new System.EventHandler(this.btShowFront_Click);
            // 
            // lb_Exercises
            // 
            this.lb_Exercises.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Exercises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Exercises.FormattingEnabled = true;
            this.lb_Exercises.Location = new System.Drawing.Point(3, 49);
            this.lb_Exercises.Name = "lb_Exercises";
            this.lb_Exercises.Size = new System.Drawing.Size(207, 260);
            this.lb_Exercises.TabIndex = 4;
            this.lb_Exercises.DoubleClick += new System.EventHandler(this.lb_Exercises_DoubleClick);
            // 
            // pB_Body
            // 
            this.pB_Body.BackColor = System.Drawing.Color.White;
            this.pB_Body.Image = global::Exercise_Demo.Properties.Resources.body;
            this.pB_Body.Location = new System.Drawing.Point(231, 56);
            this.pB_Body.Name = "pB_Body";
            this.pB_Body.Size = new System.Drawing.Size(279, 561);
            this.pB_Body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_Body.TabIndex = 0;
            this.pB_Body.TabStop = false;
            this.pB_Body.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pB_Body_Click);
            // 
            // pB_BodyBack
            // 
            this.pB_BodyBack.BackColor = System.Drawing.Color.White;
            this.pB_BodyBack.Image = global::Exercise_Demo.Properties.Resources.body_back2;
            this.pB_BodyBack.Location = new System.Drawing.Point(231, 56);
            this.pB_BodyBack.Name = "pB_BodyBack";
            this.pB_BodyBack.Size = new System.Drawing.Size(279, 561);
            this.pB_BodyBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_BodyBack.TabIndex = 3;
            this.pB_BodyBack.TabStop = false;
            this.pB_BodyBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pB_Body_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a part of the body to find exercises.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Glossary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pB_Body);
            this.Controls.Add(this.pB_BodyBack);
            this.Name = "Form1";
            this.Text = "Exercise Demo";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_BodyBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_Body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pB_BodyBack;
        private System.Windows.Forms.Button btShowBack;
        private System.Windows.Forms.Button btShowFront;
        private System.Windows.Forms.ListBox lb_Exercises;
        private System.Windows.Forms.Button bt_DeleteSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button button1;
    }
}

