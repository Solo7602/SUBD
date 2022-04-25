
namespace SUBD
{
    partial class FormMain
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
            this.button_Hotel = new System.Windows.Forms.Button();
            this.button_Employee = new System.Windows.Forms.Button();
            this.button_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Hotel
            // 
            this.button_Hotel.Location = new System.Drawing.Point(13, 13);
            this.button_Hotel.Name = "button_Hotel";
            this.button_Hotel.Size = new System.Drawing.Size(121, 53);
            this.button_Hotel.TabIndex = 0;
            this.button_Hotel.Text = "Отели";
            this.button_Hotel.UseVisualStyleBackColor = true;
            this.button_Hotel.Click += new System.EventHandler(this.button_Hotel_Click);
            // 
            // button_Employee
            // 
            this.button_Employee.Location = new System.Drawing.Point(140, 13);
            this.button_Employee.Name = "button_Employee";
            this.button_Employee.Size = new System.Drawing.Size(121, 53);
            this.button_Employee.TabIndex = 1;
            this.button_Employee.Text = "Сотрудники";
            this.button_Employee.UseVisualStyleBackColor = true;
            this.button_Employee.Click += new System.EventHandler(this.button_Employee_Click);
            // 
            // button_Client
            // 
            this.button_Client.Location = new System.Drawing.Point(267, 13);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(121, 53);
            this.button_Client.TabIndex = 2;
            this.button_Client.Text = "Клиенты";
            this.button_Client.UseVisualStyleBackColor = true;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 74);
            this.Controls.Add(this.button_Client);
            this.Controls.Add(this.button_Employee);
            this.Controls.Add(this.button_Hotel);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Hotel;
        private System.Windows.Forms.Button button_Employee;
        private System.Windows.Forms.Button button_Client;
    }
}