namespace EmployeeClock
{
    partial class LoginForm
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
            this.label_insertId = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_insertPassword = new System.Windows.Forms.Label();
            this.button_change_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_insertId
            // 
            this.label_insertId.AutoSize = true;
            this.label_insertId.Location = new System.Drawing.Point(152, 33);
            this.label_insertId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_insertId.Name = "label_insertId";
            this.label_insertId.Size = new System.Drawing.Size(142, 31);
            this.label_insertId.TabIndex = 0;
            this.label_insertId.Text = "תעודת זהות";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(98, 70);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(248, 38);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(98, 303);
            this.button_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(248, 45);
            this.button_submit.TabIndex = 2;
            this.button_submit.Text = "כניסה";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(98, 167);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(248, 38);
            this.textBox_password.TabIndex = 4;
            // 
            // label_insertPassword
            // 
            this.label_insertPassword.AutoSize = true;
            this.label_insertPassword.Location = new System.Drawing.Point(177, 130);
            this.label_insertPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_insertPassword.Name = "label_insertPassword";
            this.label_insertPassword.Size = new System.Drawing.Size(87, 31);
            this.label_insertPassword.TabIndex = 3;
            this.label_insertPassword.Text = "סיסמא";
            // 
            // button_change_password
            // 
            this.button_change_password.Location = new System.Drawing.Point(98, 372);
            this.button_change_password.Margin = new System.Windows.Forms.Padding(6);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(248, 45);
            this.button_change_password.TabIndex = 5;
            this.button_change_password.Text = "החלפת סיסמא";
            this.button_change_password.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 454);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_insertPassword);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_insertId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "שעון נוכחות - מסך התחברות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_insertId;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_insertPassword;
        private System.Windows.Forms.Button button_change_password;
    }
}