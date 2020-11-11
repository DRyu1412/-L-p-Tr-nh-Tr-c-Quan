namespace QuanLyNhaHang
{
    partial class fBan
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
            this.listView_Bill = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_AddFood = new System.Windows.Forms.Button();
            this.comboBox_Food = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.num_FoodCount = new System.Windows.Forms.NumericUpDown();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Bill
            // 
            this.listView_Bill.HideSelection = false;
            this.listView_Bill.Location = new System.Drawing.Point(510, 124);
            this.listView_Bill.Name = "listView_Bill";
            this.listView_Bill.Size = new System.Drawing.Size(480, 371);
            this.listView_Bill.TabIndex = 1;
            this.listView_Bill.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.num_FoodCount);
            this.panel2.Controls.Add(this.button_AddFood);
            this.panel2.Controls.Add(this.comboBox_Category);
            this.panel2.Controls.Add(this.comboBox_Food);
            this.panel2.Location = new System.Drawing.Point(510, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 77);
            this.panel2.TabIndex = 2;
            // 
            // button_AddFood
            // 
            this.button_AddFood.Location = new System.Drawing.Point(300, 3);
            this.button_AddFood.Name = "button_AddFood";
            this.button_AddFood.Size = new System.Drawing.Size(118, 68);
            this.button_AddFood.TabIndex = 1;
            this.button_AddFood.Text = "Thêm Món";
            this.button_AddFood.UseVisualStyleBackColor = true;
            // 
            // comboBox_Food
            // 
            this.comboBox_Food.FormattingEnabled = true;
            this.comboBox_Food.Location = new System.Drawing.Point(5, 37);
            this.comboBox_Food.Name = "comboBox_Food";
            this.comboBox_Food.Size = new System.Drawing.Size(280, 21);
            this.comboBox_Food.TabIndex = 0;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(5, 10);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(280, 21);
            this.comboBox_Category.TabIndex = 0;
            // 
            // num_FoodCount
            // 
            this.num_FoodCount.Location = new System.Drawing.Point(437, 29);
            this.num_FoodCount.Name = "num_FoodCount";
            this.num_FoodCount.Size = new System.Drawing.Size(29, 20);
            this.num_FoodCount.TabIndex = 2;
            this.num_FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 47);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(492, 565);
            this.flpTable.TabIndex = 3;
            // 
            // fBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 662);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView_Bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBan";
            this.Text = "fBan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_FoodCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_AddFood;
        private System.Windows.Forms.ComboBox comboBox_Food;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.NumericUpDown num_FoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}