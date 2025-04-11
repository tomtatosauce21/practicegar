namespace practice_log_in_add_delete_view
{
    partial class txtemailadd
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddressadd = new System.Windows.Forms.TextBox();
            this.txtemaileadd = new System.Windows.Forms.TextBox();
            this.txtsexadd = new System.Windows.Forms.TextBox();
            this.txtnameadd = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "name";
            // 
            // txtaddressadd
            // 
            this.txtaddressadd.Location = new System.Drawing.Point(137, 242);
            this.txtaddressadd.Name = "txtaddressadd";
            this.txtaddressadd.Size = new System.Drawing.Size(204, 22);
            this.txtaddressadd.TabIndex = 11;
            // 
            // txtemaileadd
            // 
            this.txtemaileadd.Location = new System.Drawing.Point(137, 142);
            this.txtemaileadd.Name = "txtemaileadd";
            this.txtemaileadd.Size = new System.Drawing.Size(204, 22);
            this.txtemaileadd.TabIndex = 10;
            // 
            // txtsexadd
            // 
            this.txtsexadd.Location = new System.Drawing.Point(137, 192);
            this.txtsexadd.Name = "txtsexadd";
            this.txtsexadd.Size = new System.Drawing.Size(204, 22);
            this.txtsexadd.TabIndex = 9;
            // 
            // txtnameadd
            // 
            this.txtnameadd.Location = new System.Drawing.Point(137, 84);
            this.txtnameadd.Name = "txtnameadd";
            this.txtnameadd.Size = new System.Drawing.Size(204, 22);
            this.txtnameadd.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(100, 320);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(220, 320);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtemailadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddressadd);
            this.Controls.Add(this.txtemaileadd);
            this.Controls.Add(this.txtsexadd);
            this.Controls.Add(this.txtnameadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "txtemailadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            this.Load += new System.EventHandler(this.txtemailadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddressadd;
        private System.Windows.Forms.TextBox txtemaileadd;
        private System.Windows.Forms.TextBox txtsexadd;
        private System.Windows.Forms.TextBox txtnameadd;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}