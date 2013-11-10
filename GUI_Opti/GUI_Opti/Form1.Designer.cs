namespace WindowsFormsApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseButton = new System.Windows.Forms.Button();
            this.Mondays = new System.Windows.Forms.CheckBox();
            this.Tuesdays = new System.Windows.Forms.CheckBox();
            this.Wednesdays = new System.Windows.Forms.CheckBox();
            this.Thursdays = new System.Windows.Forms.CheckBox();
            this.Fridays = new System.Windows.Forms.CheckBox();
            this.Saturdays = new System.Windows.Forms.CheckBox();
            this.Sundays = new System.Windows.Forms.CheckBox();
            this.nightClass = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.earlyClass = new System.Windows.Forms.CheckBox();
            this.classNum = new System.Windows.Forms.Label();
            this.numSun = new System.Windows.Forms.CheckBox();
            this.numSat = new System.Windows.Forms.CheckBox();
            this.numFri = new System.Windows.Forms.CheckBox();
            this.numThurs = new System.Windows.Forms.CheckBox();
            this.numWed = new System.Windows.Forms.CheckBox();
            this.numTues = new System.Windows.Forms.CheckBox();
            this.numMonday = new System.Windows.Forms.CheckBox();
            this.ReGen = new System.Windows.Forms.Button();
            this.course1Box = new System.Windows.Forms.RichTextBox();
            this.Course1 = new System.Windows.Forms.Label();
            this.Course3 = new System.Windows.Forms.Label();
            this.course3Box = new System.Windows.Forms.RichTextBox();
            this.Course2 = new System.Windows.Forms.Label();
            this.course2Box = new System.Windows.Forms.RichTextBox();
            this.Course5 = new System.Windows.Forms.Label();
            this.course5Box = new System.Windows.Forms.RichTextBox();
            this.Course4 = new System.Windows.Forms.Label();
            this.course4Box = new System.Windows.Forms.RichTextBox();
            this.Course6 = new System.Windows.Forms.Label();
            this.course6Box = new System.Windows.Forms.RichTextBox();
            this.axSkin1 = new AxACTIVESKINLib.AxSkin();
            this.programStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSkin1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(900, 427);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(117, 23);
            this.courseButton.TabIndex = 1;
            this.courseButton.Text = "Add Courses!";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click);
            // 
            // Mondays
            // 
            this.Mondays.AutoSize = true;
            this.Mondays.Location = new System.Drawing.Point(1122, 44);
            this.Mondays.Name = "Mondays";
            this.Mondays.Size = new System.Drawing.Size(69, 17);
            this.Mondays.TabIndex = 3;
            this.Mondays.Text = "Mondays";
            this.Mondays.UseVisualStyleBackColor = true;
            // 
            // Tuesdays
            // 
            this.Tuesdays.AutoSize = true;
            this.Tuesdays.Location = new System.Drawing.Point(1201, 44);
            this.Tuesdays.Name = "Tuesdays";
            this.Tuesdays.Size = new System.Drawing.Size(72, 17);
            this.Tuesdays.TabIndex = 4;
            this.Tuesdays.Text = "Tuesdays";
            this.Tuesdays.UseVisualStyleBackColor = true;
            // 
            // Wednesdays
            // 
            this.Wednesdays.AutoSize = true;
            this.Wednesdays.Location = new System.Drawing.Point(1122, 67);
            this.Wednesdays.Name = "Wednesdays";
            this.Wednesdays.Size = new System.Drawing.Size(88, 17);
            this.Wednesdays.TabIndex = 5;
            this.Wednesdays.Text = "Wednesdays";
            this.Wednesdays.UseVisualStyleBackColor = true;
            // 
            // Thursdays
            // 
            this.Thursdays.AutoSize = true;
            this.Thursdays.Location = new System.Drawing.Point(1122, 90);
            this.Thursdays.Name = "Thursdays";
            this.Thursdays.Size = new System.Drawing.Size(75, 17);
            this.Thursdays.TabIndex = 6;
            this.Thursdays.Text = "Thursdays";
            this.Thursdays.UseVisualStyleBackColor = true;
            // 
            // Fridays
            // 
            this.Fridays.AutoSize = true;
            this.Fridays.Location = new System.Drawing.Point(1203, 90);
            this.Fridays.Name = "Fridays";
            this.Fridays.Size = new System.Drawing.Size(59, 17);
            this.Fridays.TabIndex = 7;
            this.Fridays.Text = "Fridays";
            this.Fridays.UseVisualStyleBackColor = true;
            // 
            // Saturdays
            // 
            this.Saturdays.AutoSize = true;
            this.Saturdays.Location = new System.Drawing.Point(1122, 113);
            this.Saturdays.Name = "Saturdays";
            this.Saturdays.Size = new System.Drawing.Size(73, 17);
            this.Saturdays.TabIndex = 8;
            this.Saturdays.Text = "Saturdays";
            this.Saturdays.UseVisualStyleBackColor = true;
            // 
            // Sundays
            // 
            this.Sundays.AutoSize = true;
            this.Sundays.Location = new System.Drawing.Point(1201, 113);
            this.Sundays.Name = "Sundays";
            this.Sundays.Size = new System.Drawing.Size(67, 17);
            this.Sundays.TabIndex = 9;
            this.Sundays.Text = "Sundays";
            this.Sundays.UseVisualStyleBackColor = true;
            // 
            // nightClass
            // 
            this.nightClass.AutoSize = true;
            this.nightClass.Location = new System.Drawing.Point(1122, 173);
            this.nightClass.Name = "nightClass";
            this.nightClass.Size = new System.Drawing.Size(107, 17);
            this.nightClass.TabIndex = 10;
            this.nightClass.Text = "No Night Classes";
            this.nightClass.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1119, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Days Off";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1119, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Other Criterias";
            // 
            // earlyClass
            // 
            this.earlyClass.AutoSize = true;
            this.earlyClass.Location = new System.Drawing.Point(1122, 196);
            this.earlyClass.Name = "earlyClass";
            this.earlyClass.Size = new System.Drawing.Size(105, 17);
            this.earlyClass.TabIndex = 14;
            this.earlyClass.Text = "No Early Classes";
            this.earlyClass.UseVisualStyleBackColor = true;
            // 
            // classNum
            // 
            this.classNum.AutoSize = true;
            this.classNum.Location = new System.Drawing.Point(1114, 241);
            this.classNum.Name = "classNum";
            this.classNum.Size = new System.Drawing.Size(113, 13);
            this.classNum.TabIndex = 15;
            this.classNum.Text = "Less than 3 Classes In";
            // 
            // numSun
            // 
            this.numSun.AutoSize = true;
            this.numSun.Location = new System.Drawing.Point(1201, 337);
            this.numSun.Name = "numSun";
            this.numSun.Size = new System.Drawing.Size(67, 17);
            this.numSun.TabIndex = 22;
            this.numSun.Text = "Sundays";
            this.numSun.UseVisualStyleBackColor = true;
            // 
            // numSat
            // 
            this.numSat.AutoSize = true;
            this.numSat.Location = new System.Drawing.Point(1122, 337);
            this.numSat.Name = "numSat";
            this.numSat.Size = new System.Drawing.Size(73, 17);
            this.numSat.TabIndex = 21;
            this.numSat.Text = "Saturdays";
            this.numSat.UseVisualStyleBackColor = true;
            // 
            // numFri
            // 
            this.numFri.AutoSize = true;
            this.numFri.Location = new System.Drawing.Point(1203, 314);
            this.numFri.Name = "numFri";
            this.numFri.Size = new System.Drawing.Size(59, 17);
            this.numFri.TabIndex = 20;
            this.numFri.Text = "Fridays";
            this.numFri.UseVisualStyleBackColor = true;
            // 
            // numThurs
            // 
            this.numThurs.AutoSize = true;
            this.numThurs.Location = new System.Drawing.Point(1122, 314);
            this.numThurs.Name = "numThurs";
            this.numThurs.Size = new System.Drawing.Size(75, 17);
            this.numThurs.TabIndex = 19;
            this.numThurs.Text = "Thursdays";
            this.numThurs.UseVisualStyleBackColor = true;
            // 
            // numWed
            // 
            this.numWed.AutoSize = true;
            this.numWed.Location = new System.Drawing.Point(1122, 291);
            this.numWed.Name = "numWed";
            this.numWed.Size = new System.Drawing.Size(83, 17);
            this.numWed.TabIndex = 18;
            this.numWed.Text = "Wednesday";
            this.numWed.UseVisualStyleBackColor = true;
            // 
            // numTues
            // 
            this.numTues.AutoSize = true;
            this.numTues.Location = new System.Drawing.Point(1201, 268);
            this.numTues.Name = "numTues";
            this.numTues.Size = new System.Drawing.Size(72, 17);
            this.numTues.TabIndex = 17;
            this.numTues.Text = "Tuesdays";
            this.numTues.UseVisualStyleBackColor = true;
            // 
            // numMonday
            // 
            this.numMonday.AutoSize = true;
            this.numMonday.Location = new System.Drawing.Point(1122, 268);
            this.numMonday.Name = "numMonday";
            this.numMonday.Size = new System.Drawing.Size(69, 17);
            this.numMonday.TabIndex = 16;
            this.numMonday.Text = "Mondays";
            this.numMonday.UseVisualStyleBackColor = true;
            // 
            // ReGen
            // 
            this.ReGen.Location = new System.Drawing.Point(1135, 390);
            this.ReGen.Name = "ReGen";
            this.ReGen.Size = new System.Drawing.Size(127, 23);
            this.ReGen.TabIndex = 23;
            this.ReGen.Text = "Generate Schedule";
            this.ReGen.UseVisualStyleBackColor = true;
            this.ReGen.Click += new System.EventHandler(this.ReGen_Click_1);
            // 
            // course1Box
            // 
            this.course1Box.Location = new System.Drawing.Point(842, 28);
            this.course1Box.Name = "course1Box";
            this.course1Box.Size = new System.Drawing.Size(202, 40);
            this.course1Box.TabIndex = 88;
            this.course1Box.Text = "";
            // 
            // Course1
            // 
            this.Course1.AutoSize = true;
            this.Course1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course1.Location = new System.Drawing.Point(845, 12);
            this.Course1.Name = "Course1";
            this.Course1.Size = new System.Drawing.Size(46, 13);
            this.Course1.TabIndex = 89;
            this.Course1.Text = "Course1";
            // 
            // Course3
            // 
            this.Course3.AutoSize = true;
            this.Course3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course3.Location = new System.Drawing.Point(842, 133);
            this.Course3.Name = "Course3";
            this.Course3.Size = new System.Drawing.Size(46, 13);
            this.Course3.TabIndex = 91;
            this.Course3.Text = "Course3";
            // 
            // course3Box
            // 
            this.course3Box.Location = new System.Drawing.Point(842, 154);
            this.course3Box.Name = "course3Box";
            this.course3Box.Size = new System.Drawing.Size(202, 43);
            this.course3Box.TabIndex = 90;
            this.course3Box.Text = "";
            // 
            // Course2
            // 
            this.Course2.AutoSize = true;
            this.Course2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course2.Location = new System.Drawing.Point(842, 71);
            this.Course2.Name = "Course2";
            this.Course2.Size = new System.Drawing.Size(46, 13);
            this.Course2.TabIndex = 93;
            this.Course2.Text = "Course2";
            // 
            // course2Box
            // 
            this.course2Box.Location = new System.Drawing.Point(842, 90);
            this.course2Box.Name = "course2Box";
            this.course2Box.Size = new System.Drawing.Size(202, 40);
            this.course2Box.TabIndex = 92;
            this.course2Box.Text = "";
            // 
            // Course5
            // 
            this.Course5.AutoSize = true;
            this.Course5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course5.Location = new System.Drawing.Point(842, 272);
            this.Course5.Name = "Course5";
            this.Course5.Size = new System.Drawing.Size(46, 13);
            this.Course5.TabIndex = 95;
            this.Course5.Text = "Course5";
            // 
            // course5Box
            // 
            this.course5Box.Location = new System.Drawing.Point(842, 291);
            this.course5Box.Name = "course5Box";
            this.course5Box.Size = new System.Drawing.Size(202, 50);
            this.course5Box.TabIndex = 94;
            this.course5Box.Text = "";
            // 
            // Course4
            // 
            this.Course4.AutoSize = true;
            this.Course4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course4.Location = new System.Drawing.Point(842, 204);
            this.Course4.Name = "Course4";
            this.Course4.Size = new System.Drawing.Size(46, 13);
            this.Course4.TabIndex = 97;
            this.Course4.Text = "Course4";
            // 
            // course4Box
            // 
            this.course4Box.Location = new System.Drawing.Point(842, 220);
            this.course4Box.Name = "course4Box";
            this.course4Box.Size = new System.Drawing.Size(202, 49);
            this.course4Box.TabIndex = 96;
            this.course4Box.Text = "";
            // 
            // Course6
            // 
            this.Course6.AutoSize = true;
            this.Course6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Course6.Location = new System.Drawing.Point(842, 344);
            this.Course6.Name = "Course6";
            this.Course6.Size = new System.Drawing.Size(46, 13);
            this.Course6.TabIndex = 99;
            this.Course6.Text = "Course6";
            // 
            // course6Box
            // 
            this.course6Box.Location = new System.Drawing.Point(842, 360);
            this.course6Box.Name = "course6Box";
            this.course6Box.Size = new System.Drawing.Size(202, 53);
            this.course6Box.TabIndex = 98;
            this.course6Box.Text = "";
            // 
            // axSkin1
            // 
            this.axSkin1.Enabled = true;
            this.axSkin1.Location = new System.Drawing.Point(0, 0);
            this.axSkin1.Name = "axSkin1";
            this.axSkin1.TabIndex = 0;
            // 
            // programStart
            // 
            this.programStart.Location = new System.Drawing.Point(1135, 441);
            this.programStart.Name = "programStart";
            this.programStart.Size = new System.Drawing.Size(127, 23);
            this.programStart.TabIndex = 100;
            this.programStart.Text = "Generate File";
            this.programStart.UseVisualStyleBackColor = true;
            this.programStart.Click += new System.EventHandler(this.programStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 572);
            this.Controls.Add(this.programStart);
            this.Controls.Add(this.Course6);
            this.Controls.Add(this.course6Box);
            this.Controls.Add(this.Course4);
            this.Controls.Add(this.course4Box);
            this.Controls.Add(this.Course5);
            this.Controls.Add(this.course5Box);
            this.Controls.Add(this.Course2);
            this.Controls.Add(this.course2Box);
            this.Controls.Add(this.Course3);
            this.Controls.Add(this.course3Box);
            this.Controls.Add(this.Course1);
            this.Controls.Add(this.course1Box);
            this.Controls.Add(this.ReGen);
            this.Controls.Add(this.numSun);
            this.Controls.Add(this.numSat);
            this.Controls.Add(this.numFri);
            this.Controls.Add(this.numThurs);
            this.Controls.Add(this.numWed);
            this.Controls.Add(this.numTues);
            this.Controls.Add(this.numMonday);
            this.Controls.Add(this.classNum);
            this.Controls.Add(this.earlyClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nightClass);
            this.Controls.Add(this.Sundays);
            this.Controls.Add(this.Saturdays);
            this.Controls.Add(this.Fridays);
            this.Controls.Add(this.Thursdays);
            this.Controls.Add(this.Wednesdays);
            this.Controls.Add(this.Tuesdays);
            this.Controls.Add(this.Mondays);
            this.Controls.Add(this.courseButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axSkin1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.CheckBox Mondays;
        private System.Windows.Forms.CheckBox Tuesdays;
        private System.Windows.Forms.CheckBox Wednesdays;
        private System.Windows.Forms.CheckBox Thursdays;
        private System.Windows.Forms.CheckBox Fridays;
        private System.Windows.Forms.CheckBox Saturdays;
        private System.Windows.Forms.CheckBox Sundays;
        private System.Windows.Forms.CheckBox nightClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox earlyClass;
        private System.Windows.Forms.Label classNum;
        private System.Windows.Forms.CheckBox numSun;
        private System.Windows.Forms.CheckBox numSat;
        private System.Windows.Forms.CheckBox numFri;
        private System.Windows.Forms.CheckBox numThurs;
        private System.Windows.Forms.CheckBox numWed;
        private System.Windows.Forms.CheckBox numTues;
        private System.Windows.Forms.CheckBox numMonday;
        private System.Windows.Forms.Button ReGen;
        private System.Windows.Forms.RichTextBox course1Box;
        private System.Windows.Forms.Label Course1;
        private System.Windows.Forms.Label Course3;
        private System.Windows.Forms.RichTextBox course3Box;
        private System.Windows.Forms.Label Course2;
        private System.Windows.Forms.RichTextBox course2Box;
        private System.Windows.Forms.Label Course5;
        private System.Windows.Forms.RichTextBox course5Box;
        private System.Windows.Forms.Label Course4;
        private System.Windows.Forms.RichTextBox course4Box;
        private System.Windows.Forms.Label Course6;
        private System.Windows.Forms.RichTextBox course6Box;
        private AxACTIVESKINLib.AxSkin axSkin1;
        private System.Windows.Forms.Button programStart;
    }
}

