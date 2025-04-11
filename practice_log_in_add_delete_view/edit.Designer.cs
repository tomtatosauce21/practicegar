namespace practice_log_in_add_delete_view
{
    partial class edit
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
            this.txtnameedit = new System.Windows.Forms.TextBox();
            this.txtIDedit = new System.Windows.Forms.TextBox();
            this.txtemailedit = new System.Windows.Forms.TextBox();
            this.txtadressdedit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnameedit
            // 
            this.txtnameedit.Location = new System.Drawing.Point(131, 87);
            this.txtnameedit.Name = "txtnameedit";
            this.txtnameedit.Size = new System.Drawing.Size(204, 22);
            this.txtnameedit.TabIndex = 0;
            // 
            // txtIDedit
            // 
            this.txtIDedit.Location = new System.Drawing.Point(131, 195);
            this.txtIDedit.Name = "txtIDedit";
            this.txtIDedit.Size = new System.Drawing.Size(204, 22);
            this.txtIDedit.TabIndex = 1;
            // 
            // txtemailedit
            // 
            this.txtemailedit.Location = new System.Drawing.Point(131, 145);
            this.txtemailedit.Name = "txtemailedit";
            this.txtemailedit.Size = new System.Drawing.Size(204, 22);
            this.txtemailedit.TabIndex = 2;
            // 
            // txtadressdedit
            // 
            this.txtadressdedit.Location = new System.Drawing.Point(131, 245);
            this.txtadressdedit.Name = "txtadressdedit";
            this.txtadressdedit.Size = new System.Drawing.Size(204, 22);
            this.txtadressdedit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(105, 334);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(214, 334);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadressdedit);
            this.Controls.Add(this.txtemailedit);
            this.Controls.Add(this.txtIDedit);
            this.Controls.Add(this.txtnameedit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnameedit;
        private System.Windows.Forms.TextBox txtIDedit;
        private System.Windows.Forms.TextBox txtemailedit;
        private System.Windows.Forms.TextBox txtadressdedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btncancel;
    }
}