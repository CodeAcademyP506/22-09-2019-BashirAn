namespace To_do_list
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
            this.Daily = new System.Windows.Forms.GroupBox();
            this.First = new System.Windows.Forms.CheckBox();
            this.Second = new System.Windows.Forms.CheckBox();
            this.Third = new System.Windows.Forms.CheckBox();
            this.Fourth = new System.Windows.Forms.CheckBox();
            this.Fifth = new System.Windows.Forms.CheckBox();
            this.Sixth = new System.Windows.Forms.CheckBox();
            this.Seventh = new System.Windows.Forms.CheckBox();
            this.Eighth = new System.Windows.Forms.CheckBox();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Daily.SuspendLayout();
            this.SuspendLayout();
            // 
            // Daily
            // 
            this.Daily.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Daily.Controls.Add(this.Eighth);
            this.Daily.Controls.Add(this.Seventh);
            this.Daily.Controls.Add(this.Sixth);
            this.Daily.Controls.Add(this.Fifth);
            this.Daily.Controls.Add(this.Fourth);
            this.Daily.Controls.Add(this.Third);
            this.Daily.Controls.Add(this.Second);
            this.Daily.Controls.Add(this.First);
            this.Daily.Location = new System.Drawing.Point(1, 1);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(701, 225);
            this.Daily.TabIndex = 0;
            this.Daily.TabStop = false;
            this.Daily.Text = "To Do List Hotel Receptionist AM Shift";
            this.Daily.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Location = new System.Drawing.Point(12, 37);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(97, 17);
            this.First.TabIndex = 3;
            this.First.Text = "Shift Handover";
            this.First.UseVisualStyleBackColor = true;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(12, 60);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(110, 17);
            this.Second.TabIndex = 4;
            this.Second.Text = "Check Cash Float";
            this.Second.UseVisualStyleBackColor = true;
            // 
            // Third
            // 
            this.Third.AutoSize = true;
            this.Third.Location = new System.Drawing.Point(12, 83);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(89, 17);
            this.Third.TabIndex = 5;
            this.Third.Text = "Check Lobby";
            this.Third.UseVisualStyleBackColor = true;
            // 
            // Fourth
            // 
            this.Fourth.AutoSize = true;
            this.Fourth.Location = new System.Drawing.Point(12, 106);
            this.Fourth.Name = "Fourth";
            this.Fourth.Size = new System.Drawing.Size(135, 17);
            this.Fourth.TabIndex = 6;
            this.Fourth.Text = "Check Due Out Billings";
            this.Fourth.UseVisualStyleBackColor = true;
            // 
            // Fifth
            // 
            this.Fifth.AutoSize = true;
            this.Fifth.Location = new System.Drawing.Point(12, 130);
            this.Fifth.Name = "Fifth";
            this.Fifth.Size = new System.Drawing.Size(180, 17);
            this.Fifth.TabIndex = 7;
            this.Fifth.Text = "Read and Follow Up New emails";
            this.Fifth.UseVisualStyleBackColor = true;
            // 
            // Sixth
            // 
            this.Sixth.AutoSize = true;
            this.Sixth.Location = new System.Drawing.Point(11, 153);
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(303, 17);
            this.Sixth.TabIndex = 8;
            this.Sixth.Text = "Check if all rooms are allocated and status till check-in time";
            this.Sixth.UseVisualStyleBackColor = true;
            // 
            // Seventh
            // 
            this.Seventh.AutoSize = true;
            this.Seventh.Location = new System.Drawing.Point(11, 176);
            this.Seventh.Name = "Seventh";
            this.Seventh.Size = new System.Drawing.Size(279, 17);
            this.Seventh.TabIndex = 9;
            this.Seventh.Text = "Check and follow up on Guest Request Control Sheet";
            this.Seventh.UseVisualStyleBackColor = true;
            // 
            // Eighth
            // 
            this.Eighth.AutoSize = true;
            this.Eighth.Location = new System.Drawing.Point(11, 199);
            this.Eighth.Name = "Eighth";
            this.Eighth.Size = new System.Drawing.Size(216, 17);
            this.Eighth.TabIndex = 10;
            this.Eighth.Text = "Check and close cashier with supervisor";
            this.Eighth.UseVisualStyleBackColor = true;
            // 
            // Checkbtn
            // 
            this.Checkbtn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkbtn.Location = new System.Drawing.Point(12, 248);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(162, 45);
            this.Checkbtn.TabIndex = 1;
            this.Checkbtn.Text = "Check";
            this.Checkbtn.UseVisualStyleBackColor = true;
            this.Checkbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(200, 248);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(162, 45);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Closebtn
            // 
            this.Closebtn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.Location = new System.Drawing.Point(540, 248);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(162, 45);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Daily);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Daily.ResumeLayout(false);
            this.Daily.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Daily;
        private System.Windows.Forms.CheckBox First;
        private System.Windows.Forms.CheckBox Eighth;
        private System.Windows.Forms.CheckBox Seventh;
        private System.Windows.Forms.CheckBox Sixth;
        private System.Windows.Forms.CheckBox Fifth;
        private System.Windows.Forms.CheckBox Fourth;
        private System.Windows.Forms.CheckBox Third;
        private System.Windows.Forms.CheckBox Second;
        private System.Windows.Forms.Button Checkbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Closebtn;
    }
}

