
namespace Coffee_Shop_Management_System
{
    partial class Dashboaed
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
            this.LogOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddItemsLabel = new System.Windows.Forms.Label();
            this.RemoveItemsLabel = new System.Windows.Forms.Label();
            this.UpdateItemsLabel = new System.Windows.Forms.Label();
            this.PlaceOrderLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucPlaceOrder1 = new Coffee_Shop_Management_System.AllUserControls.UcPlaceOrder();
            this.ucAddItems1 = new Coffee_Shop_Management_System.AllUserControls.UcAddItems();
            this.ucWelcome1 = new Coffee_Shop_Management_System.AllUserControls.UcWelcome();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucRemoveItems1 = new Coffee_Shop_Management_System.AllUserControls.UcRemoveItems();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogOutLinkLabel);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.AddItemsLabel);
            this.panel1.Controls.Add(this.RemoveItemsLabel);
            this.panel1.Controls.Add(this.UpdateItemsLabel);
            this.panel1.Controls.Add(this.PlaceOrderLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 578);
            this.panel1.TabIndex = 0;
            // 
            // LogOutLinkLabel
            // 
            this.LogOutLinkLabel.AutoSize = true;
            this.LogOutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLinkLabel.Location = new System.Drawing.Point(31, 312);
            this.LogOutLinkLabel.Name = "LogOutLinkLabel";
            this.LogOutLinkLabel.Size = new System.Drawing.Size(68, 20);
            this.LogOutLinkLabel.TabIndex = 7;
            this.LogOutLinkLabel.TabStop = true;
            this.LogOutLinkLabel.Text = "LogOut";
            this.LogOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLinkLabel_LinkClicked);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 39);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddItemsLabel
            // 
            this.AddItemsLabel.AutoSize = true;
            this.AddItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemsLabel.Location = new System.Drawing.Point(17, 119);
            this.AddItemsLabel.Name = "AddItemsLabel";
            this.AddItemsLabel.Size = new System.Drawing.Size(91, 20);
            this.AddItemsLabel.TabIndex = 4;
            this.AddItemsLabel.Text = "Add Items";
            this.AddItemsLabel.Click += new System.EventHandler(this.AddItemsLabel_Click);
            // 
            // RemoveItemsLabel
            // 
            this.RemoveItemsLabel.AutoSize = true;
            this.RemoveItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemsLabel.Location = new System.Drawing.Point(11, 202);
            this.RemoveItemsLabel.Name = "RemoveItemsLabel";
            this.RemoveItemsLabel.Size = new System.Drawing.Size(124, 20);
            this.RemoveItemsLabel.TabIndex = 3;
            this.RemoveItemsLabel.Text = "Remove Items";
            this.RemoveItemsLabel.Click += new System.EventHandler(this.RemoveItemsLabel_Click);
            // 
            // UpdateItemsLabel
            // 
            this.UpdateItemsLabel.AutoSize = true;
            this.UpdateItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemsLabel.Location = new System.Drawing.Point(17, 161);
            this.UpdateItemsLabel.Name = "UpdateItemsLabel";
            this.UpdateItemsLabel.Size = new System.Drawing.Size(118, 20);
            this.UpdateItemsLabel.TabIndex = 2;
            this.UpdateItemsLabel.Text = "Update Items";
            // 
            // PlaceOrderLabel
            // 
            this.PlaceOrderLabel.AutoSize = true;
            this.PlaceOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderLabel.Location = new System.Drawing.Point(17, 87);
            this.PlaceOrderLabel.Name = "PlaceOrderLabel";
            this.PlaceOrderLabel.Size = new System.Drawing.Size(103, 20);
            this.PlaceOrderLabel.TabIndex = 0;
            this.PlaceOrderLabel.Text = "Place Order";
            this.PlaceOrderLabel.Click += new System.EventHandler(this.PlaceOrderLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucRemoveItems1);
            this.panel2.Controls.Add(this.ucPlaceOrder1);
            this.panel2.Controls.Add(this.ucAddItems1);
            this.panel2.Controls.Add(this.ucWelcome1);
            this.panel2.Location = new System.Drawing.Point(260, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 578);
            this.panel2.TabIndex = 1;
            // 
            // ucPlaceOrder1
            // 
            this.ucPlaceOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlaceOrder1.Location = new System.Drawing.Point(-39, -56);
            this.ucPlaceOrder1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPlaceOrder1.Name = "ucPlaceOrder1";
            this.ucPlaceOrder1.Size = new System.Drawing.Size(930, 630);
            this.ucPlaceOrder1.TabIndex = 2;
            this.ucPlaceOrder1.Load += new System.EventHandler(this.ucPlaceOrder1_Load);
            // 
            // ucAddItems1
            // 
            this.ucAddItems1.Location = new System.Drawing.Point(14, 3);
            this.ucAddItems1.Name = "ucAddItems1";
            this.ucAddItems1.Size = new System.Drawing.Size(863, 550);
            this.ucAddItems1.TabIndex = 1;
            this.ucAddItems1.Load += new System.EventHandler(this.ucAddItems1_Load);
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.Location = new System.Drawing.Point(3, 15);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(730, 531);
            this.ucWelcome1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Items";
            // 
            // ucRemoveItems1
            // 
            this.ucRemoveItems1.Location = new System.Drawing.Point(-17, 0);
            this.ucRemoveItems1.Name = "ucRemoveItems1";
            this.ucRemoveItems1.Size = new System.Drawing.Size(924, 592);
            this.ucRemoveItems1.TabIndex = 3;
            // 
            // Dashboaed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Dashboaed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboaed";
            this.Load += new System.EventHandler(this.Dashboaed_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RemoveItemsLabel;
        private System.Windows.Forms.Label UpdateItemsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlaceOrderLabel;
        private System.Windows.Forms.Label AddItemsLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.LinkLabel LogOutLinkLabel;
        private AllUserControls.UcWelcome ucWelcome1;
        private AllUserControls.UcAddItems ucAddItems1;
        private AllUserControls.UcPlaceOrder ucPlaceOrder1;
        private AllUserControls.UcRemoveItems ucRemoveItems1;
    }
}