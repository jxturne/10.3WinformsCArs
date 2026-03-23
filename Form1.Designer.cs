namespace _10._3WinformsCArs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnSubmit = new Button();
            btnRefresh = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVIN = new TextBox();
            txtMAKE = new TextBox();
            txtMODEL = new TextBox();
            txtYEAR = new TextBox();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(797, 85);
            label1.Name = "label1";
            label1.Size = new Size(328, 35);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Information";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(543, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(757, 354);
            dataGridView1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(496, 722);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(826, 722);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Vehicle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(1140, 722);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(112, 34);
            btnDel.TabIndex = 4;
            btnDel.Text = "Delete Vehicle";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoEllipsis = true;
            btnSubmit.Location = new Point(632, 823);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit Info";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(997, 823);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh Page";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(1384, 246);
            label2.Name = "label2";
            label2.Size = new Size(45, 26);
            label2.TabIndex = 7;
            label2.Text = "VIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(1384, 345);
            label3.Name = "label3";
            label3.Size = new Size(67, 26);
            label3.TabIndex = 8;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(1382, 441);
            label4.Name = "label4";
            label4.Size = new Size(81, 26);
            label4.TabIndex = 9;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(1382, 619);
            label5.Name = "label5";
            label5.Size = new Size(69, 26);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(1382, 527);
            label6.Name = "label6";
            label6.Size = new Size(63, 26);
            label6.TabIndex = 11;
            label6.Text = "Year";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(1594, 241);
            txtVIN.Name = "txtVIN";
            txtVIN.PlaceholderText = "Required Field";
            txtVIN.Size = new Size(150, 31);
            txtVIN.TabIndex = 12;
            // 
            // txtMAKE
            // 
            txtMAKE.Location = new Point(1594, 340);
            txtMAKE.Name = "txtMAKE";
            txtMAKE.PlaceholderText = "Required Field";
            txtMAKE.Size = new Size(150, 31);
            txtMAKE.TabIndex = 13;
            // 
            // txtMODEL
            // 
            txtMODEL.Location = new Point(1594, 436);
            txtMODEL.Name = "txtMODEL";
            txtMODEL.Size = new Size(150, 31);
            txtMODEL.TabIndex = 14;
            // 
            // txtYEAR
            // 
            txtYEAR.Location = new Point(1594, 527);
            txtYEAR.Name = "txtYEAR";
            txtYEAR.Size = new Size(150, 31);
            txtYEAR.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1594, 619);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1979, 1226);
            Controls.Add(txtPrice);
            Controls.Add(txtYEAR);
            Controls.Add(txtMODEL);
            Controls.Add(txtMAKE);
            Controls.Add(txtVIN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRefresh);
            Controls.Add(btnSubmit);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Button btnSubmit;
        private Button btnRefresh;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtVIN;
        private TextBox txtMAKE;
        private TextBox txtMODEL;
        private TextBox txtYEAR;
        private TextBox txtPrice;
    }
}
