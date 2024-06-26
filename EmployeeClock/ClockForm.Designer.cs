namespace EmployeeClock
{
    partial class ClockForm
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
            this.label_empId = new System.Windows.Forms.Label();
            this.button_StartWork = new System.Windows.Forms.Button();
            this.button_endWork = new System.Windows.Forms.Button();
            this.label_hello = new System.Windows.Forms.Label();
            this.label_last_in = new System.Windows.Forms.Label();
            this.label_date_last_in = new System.Windows.Forms.Label();
            this.label_date_last_out = new System.Windows.Forms.Label();
            this.label_last_out = new System.Windows.Forms.Label();
            this.link_to_login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_empId
            // 
            this.label_empId.AutoSize = true;
            this.label_empId.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label_empId.Location = new System.Drawing.Point(209, 51);
            this.label_empId.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_empId.Name = "label_empId";
            this.label_empId.Size = new System.Drawing.Size(188, 39);
            this.label_empId.TabIndex = 9;
            this.label_empId.Text = "200024396";
            // 
            // button_StartWork
            // 
            this.button_StartWork.BackColor = System.Drawing.Color.PaleGreen;
            this.button_StartWork.Location = new System.Drawing.Point(39, 333);
            this.button_StartWork.Margin = new System.Windows.Forms.Padding(12);
            this.button_StartWork.Name = "button_StartWork";
            this.button_StartWork.Size = new System.Drawing.Size(100, 100);
            this.button_StartWork.TabIndex = 8;
            this.button_StartWork.Text = "כניסה";
            this.button_StartWork.UseVisualStyleBackColor = false;
            // 
            // button_endWork
            // 
            this.button_endWork.BackColor = System.Drawing.Color.Tomato;
            this.button_endWork.Location = new System.Drawing.Point(297, 333);
            this.button_endWork.Margin = new System.Windows.Forms.Padding(12);
            this.button_endWork.Name = "button_endWork";
            this.button_endWork.Size = new System.Drawing.Size(100, 100);
            this.button_endWork.TabIndex = 7;
            this.button_endWork.Text = "יציאה";
            this.button_endWork.UseVisualStyleBackColor = false;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Location = new System.Drawing.Point(45, 51);
            this.label_hello.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(166, 39);
            this.label_hello.TabIndex = 10;
            this.label_hello.Text = "זהות עובד:";
            // 
            // label_last_in
            // 
            this.label_last_in.AutoSize = true;
            this.label_last_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_in.Location = new System.Drawing.Point(114, 124);
            this.label_last_in.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_last_in.Name = "label_last_in";
            this.label_last_in.Size = new System.Drawing.Size(225, 31);
            this.label_last_in.TabIndex = 12;
            this.label_last_in.Text = "תאריך כניסה אחרון";
            // 
            // label_date_last_in
            // 
            this.label_date_last_in.AutoSize = true;
            this.label_date_last_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_last_in.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label_date_last_in.Location = new System.Drawing.Point(150, 162);
            this.label_date_last_in.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_date_last_in.Name = "label_date_last_in";
            this.label_date_last_in.Size = new System.Drawing.Size(150, 31);
            this.label_date_last_in.TabIndex = 14;
            this.label_date_last_in.Text = "01/01/1999";
            // 
            // label_date_last_out
            // 
            this.label_date_last_out.AutoSize = true;
            this.label_date_last_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_last_out.ForeColor = System.Drawing.Color.Tomato;
            this.label_date_last_out.Location = new System.Drawing.Point(150, 242);
            this.label_date_last_out.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_date_last_out.Name = "label_date_last_out";
            this.label_date_last_out.Size = new System.Drawing.Size(150, 31);
            this.label_date_last_out.TabIndex = 16;
            this.label_date_last_out.Text = "01/01/1999";
            // 
            // label_last_out
            // 
            this.label_last_out.AutoSize = true;
            this.label_last_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_out.Location = new System.Drawing.Point(114, 204);
            this.label_last_out.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label_last_out.Name = "label_last_out";
            this.label_last_out.Size = new System.Drawing.Size(226, 31);
            this.label_last_out.TabIndex = 15;
            this.label_last_out.Text = "תאריך יציאה אחרון";
            // 
            // link_to_login
            // 
            this.link_to_login.AutoSize = true;
            this.link_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_to_login.Location = new System.Drawing.Point(193, 290);
            this.link_to_login.Name = "link_to_login";
            this.link_to_login.Size = new System.Drawing.Size(67, 29);
            this.link_to_login.TabIndex = 17;
            this.link_to_login.TabStop = true;
            this.link_to_login.Text = "ביטול";
            this.link_to_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_to_login_LinkClicked);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 454);
            this.Controls.Add(this.link_to_login);
            this.Controls.Add(this.label_date_last_out);
            this.Controls.Add(this.label_last_out);
            this.Controls.Add(this.label_date_last_in);
            this.Controls.Add(this.label_last_in);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.label_empId);
            this.Controls.Add(this.button_StartWork);
            this.Controls.Add(this.button_endWork);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ClockForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "שעון נוכחות - מסך ראשי";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_empId;
        private System.Windows.Forms.Button button_StartWork;
        private System.Windows.Forms.Button button_endWork;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label_last_in;
        private System.Windows.Forms.Label label_date_last_in;
        private System.Windows.Forms.Label label_date_last_out;
        private System.Windows.Forms.Label label_last_out;
        private System.Windows.Forms.LinkLabel link_to_login;
    }
}