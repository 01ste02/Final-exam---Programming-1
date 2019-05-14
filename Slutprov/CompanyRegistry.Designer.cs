namespace Slutprov
{
    partial class CompanyRegistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.lblRegName = new System.Windows.Forms.Label();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.tbxRegNum = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbxCompanies = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFilterNum = new System.Windows.Forms.Label();
            this.tbxFilterNum = new System.Windows.Forms.TextBox();
            this.cbxFilterNum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRegName
            // 
            this.lblRegName.AutoSize = true;
            this.lblRegName.Location = new System.Drawing.Point(13, 13);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(74, 13);
            this.lblRegName.TabIndex = 0;
            this.lblRegName.Text = "Företagsnamn";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Location = new System.Drawing.Point(11, 50);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(76, 13);
            this.lblRegNum.TabIndex = 1;
            this.lblRegNum.Text = "Antal anställda";
            // 
            // tbxRegName
            // 
            this.tbxRegName.Location = new System.Drawing.Point(189, 10);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(137, 20);
            this.tbxRegName.TabIndex = 2;
            // 
            // tbxRegNum
            // 
            this.tbxRegNum.Location = new System.Drawing.Point(189, 47);
            this.tbxRegNum.Name = "tbxRegNum";
            this.tbxRegNum.Size = new System.Drawing.Size(137, 20);
            this.tbxRegNum.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(251, 73);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbxCompanies
            // 
            this.lbxCompanies.FormattingEnabled = true;
            this.lbxCompanies.Location = new System.Drawing.Point(19, 144);
            this.lbxCompanies.Name = "lbxCompanies";
            this.lbxCompanies.Size = new System.Drawing.Size(188, 199);
            this.lbxCompanies.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(251, 144);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Radera";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFilterNum
            // 
            this.lblFilterNum.AutoSize = true;
            this.lblFilterNum.Location = new System.Drawing.Point(233, 273);
            this.lblFilterNum.Name = "lblFilterNum";
            this.lblFilterNum.Size = new System.Drawing.Size(76, 13);
            this.lblFilterNum.TabIndex = 7;
            this.lblFilterNum.Text = "Antal anställda";
            // 
            // tbxFilterNum
            // 
            this.tbxFilterNum.Location = new System.Drawing.Point(236, 289);
            this.tbxFilterNum.Name = "tbxFilterNum";
            this.tbxFilterNum.Size = new System.Drawing.Size(73, 20);
            this.tbxFilterNum.TabIndex = 8;
            this.tbxFilterNum.TextChanged += new System.EventHandler(this.tbxFilterNum_TextChanged);
            // 
            // cbxFilterNum
            // 
            this.cbxFilterNum.AutoSize = true;
            this.cbxFilterNum.Location = new System.Drawing.Point(236, 315);
            this.cbxFilterNum.Name = "cbxFilterNum";
            this.cbxFilterNum.Size = new System.Drawing.Size(143, 17);
            this.cbxFilterNum.TabIndex = 9;
            this.cbxFilterNum.Text = "Filtrera på antal anställda";
            this.cbxFilterNum.UseVisualStyleBackColor = true;
            this.cbxFilterNum.CheckedChanged += new System.EventHandler(this.cbxFilterNum_CheckedChanged);
            // 
            // CompanyRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 355);
            this.Controls.Add(this.cbxFilterNum);
            this.Controls.Add(this.tbxFilterNum);
            this.Controls.Add(this.lblFilterNum);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxCompanies);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbxRegNum);
            this.Controls.Add(this.tbxRegName);
            this.Controls.Add(this.lblRegNum);
            this.Controls.Add(this.lblRegName);
            this.Name = "CompanyRegistry";
            this.Text = "Företagsregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.TextBox tbxRegNum;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox lbxCompanies;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblFilterNum;
        private System.Windows.Forms.TextBox tbxFilterNum;
        private System.Windows.Forms.CheckBox cbxFilterNum;
    }
}

