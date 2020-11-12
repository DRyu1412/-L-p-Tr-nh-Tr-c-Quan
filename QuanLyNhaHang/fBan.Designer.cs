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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton_AddFood = new FontAwesome.Sharp.IconButton();
            this.num_FoodCount = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Food = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton_CheckOut = new FontAwesome.Sharp.IconButton();
            this.iconButton_Discount = new FontAwesome.Sharp.IconButton();
            this.num_Discount = new System.Windows.Forms.NumericUpDown();
            this.iconButton_SwitchTable = new FontAwesome.Sharp.IconButton();
            this.comboBox_SwitchTable = new System.Windows.Forms.ComboBox();
            this.textBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Bill
            // 
            this.listView_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Bill.GridLines = true;
            this.listView_Bill.HideSelection = false;
            this.listView_Bill.Location = new System.Drawing.Point(676, 161);
            this.listView_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Bill.Name = "listView_Bill";
            this.listView_Bill.Size = new System.Drawing.Size(659, 485);
            this.listView_Bill.TabIndex = 1;
            this.listView_Bill.UseCompatibleStateImageBehavior = false;
            this.listView_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "        Tên Món";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá    ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền     ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 192;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton_AddFood);
            this.panel2.Controls.Add(this.num_FoodCount);
            this.panel2.Controls.Add(this.comboBox_Category);
            this.panel2.Controls.Add(this.comboBox_Food);
            this.panel2.Location = new System.Drawing.Point(676, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 95);
            this.panel2.TabIndex = 2;
            // 
            // iconButton_AddFood
            // 
            this.iconButton_AddFood.BackColor = System.Drawing.Color.White;
            this.iconButton_AddFood.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_AddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_AddFood.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.iconButton_AddFood.IconColor = System.Drawing.Color.Blue;
            this.iconButton_AddFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_AddFood.IconSize = 48;
            this.iconButton_AddFood.Location = new System.Drawing.Point(386, 14);
            this.iconButton_AddFood.Name = "iconButton_AddFood";
            this.iconButton_AddFood.Rotation = 0D;
            this.iconButton_AddFood.Size = new System.Drawing.Size(202, 72);
            this.iconButton_AddFood.TabIndex = 3;
            this.iconButton_AddFood.Text = "Thêm Món";
            this.iconButton_AddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_AddFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_AddFood.UseVisualStyleBackColor = true;
            this.iconButton_AddFood.Click += new System.EventHandler(this.iconButton_AddFood_Click);
            // 
            // num_FoodCount
            // 
            this.num_FoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_FoodCount.Location = new System.Drawing.Point(605, 37);
            this.num_FoodCount.Margin = new System.Windows.Forms.Padding(4);
            this.num_FoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_FoodCount.Name = "num_FoodCount";
            this.num_FoodCount.Size = new System.Drawing.Size(39, 30);
            this.num_FoodCount.TabIndex = 2;
            this.num_FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(7, 12);
            this.comboBox_Category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(372, 33);
            this.comboBox_Category.TabIndex = 0;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // comboBox_Food
            // 
            this.comboBox_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Food.FormattingEnabled = true;
            this.comboBox_Food.Location = new System.Drawing.Point(7, 53);
            this.comboBox_Food.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Food.Name = "comboBox_Food";
            this.comboBox_Food.Size = new System.Drawing.Size(372, 33);
            this.comboBox_Food.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(13, 58);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(656, 695);
            this.flpTable.TabIndex = 3;
            // 
            // iconButton_CheckOut
            // 
            this.iconButton_CheckOut.BackColor = System.Drawing.Color.White;
            this.iconButton_CheckOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_CheckOut.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconButton_CheckOut.IconColor = System.Drawing.Color.Blue;
            this.iconButton_CheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_CheckOut.IconSize = 48;
            this.iconButton_CheckOut.Location = new System.Drawing.Point(1159, 663);
            this.iconButton_CheckOut.Name = "iconButton_CheckOut";
            this.iconButton_CheckOut.Rotation = 0D;
            this.iconButton_CheckOut.Size = new System.Drawing.Size(180, 76);
            this.iconButton_CheckOut.TabIndex = 3;
            this.iconButton_CheckOut.Text = "Thanh Toán";
            this.iconButton_CheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton_CheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_CheckOut.UseVisualStyleBackColor = true;
            this.iconButton_CheckOut.Click += new System.EventHandler(this.iconButton_CheckOut_Click);
            // 
            // iconButton_Discount
            // 
            this.iconButton_Discount.BackColor = System.Drawing.Color.White;
            this.iconButton_Discount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Discount.IconChar = FontAwesome.Sharp.IconChar.Percent;
            this.iconButton_Discount.IconColor = System.Drawing.Color.Blue;
            this.iconButton_Discount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Discount.IconSize = 30;
            this.iconButton_Discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_Discount.Location = new System.Drawing.Point(826, 685);
            this.iconButton_Discount.Name = "iconButton_Discount";
            this.iconButton_Discount.Rotation = 0D;
            this.iconButton_Discount.Size = new System.Drawing.Size(119, 64);
            this.iconButton_Discount.TabIndex = 3;
            this.iconButton_Discount.Text = "Giảm Giá";
            this.iconButton_Discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_Discount.UseVisualStyleBackColor = true;
            // 
            // num_Discount
            // 
            this.num_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Discount.Location = new System.Drawing.Point(828, 648);
            this.num_Discount.Margin = new System.Windows.Forms.Padding(4);
            this.num_Discount.Name = "num_Discount";
            this.num_Discount.Size = new System.Drawing.Size(117, 30);
            this.num_Discount.TabIndex = 2;
            this.num_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconButton_SwitchTable
            // 
            this.iconButton_SwitchTable.BackColor = System.Drawing.Color.White;
            this.iconButton_SwitchTable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_SwitchTable.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButton_SwitchTable.IconColor = System.Drawing.Color.Blue;
            this.iconButton_SwitchTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_SwitchTable.IconSize = 48;
            this.iconButton_SwitchTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_SwitchTable.Location = new System.Drawing.Point(676, 685);
            this.iconButton_SwitchTable.Name = "iconButton_SwitchTable";
            this.iconButton_SwitchTable.Rotation = 0D;
            this.iconButton_SwitchTable.Size = new System.Drawing.Size(144, 64);
            this.iconButton_SwitchTable.TabIndex = 3;
            this.iconButton_SwitchTable.Text = "Chuyển Bàn";
            this.iconButton_SwitchTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton_SwitchTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_SwitchTable.UseVisualStyleBackColor = true;
            // 
            // comboBox_SwitchTable
            // 
            this.comboBox_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SwitchTable.FormattingEnabled = true;
            this.comboBox_SwitchTable.Location = new System.Drawing.Point(676, 645);
            this.comboBox_SwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SwitchTable.Name = "comboBox_SwitchTable";
            this.comboBox_SwitchTable.Size = new System.Drawing.Size(144, 33);
            this.comboBox_SwitchTable.TabIndex = 0;
            // 
            // textBox_TotalPrice
            // 
            this.textBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TotalPrice.Location = new System.Drawing.Point(951, 685);
            this.textBox_TotalPrice.Name = "textBox_TotalPrice";
            this.textBox_TotalPrice.ReadOnly = true;
            this.textBox_TotalPrice.Size = new System.Drawing.Size(202, 45);
            this.textBox_TotalPrice.TabIndex = 4;
            this.textBox_TotalPrice.Text = "0";
            this.textBox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 815);
            this.Controls.Add(this.textBox_TotalPrice);
            this.Controls.Add(this.iconButton_SwitchTable);
            this.Controls.Add(this.iconButton_Discount);
            this.Controls.Add(this.num_Discount);
            this.Controls.Add(this.comboBox_SwitchTable);
            this.Controls.Add(this.iconButton_CheckOut);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView_Bill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBan";
            this.Text = "fBan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_FoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Discount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView_Bill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Food;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.NumericUpDown num_FoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private FontAwesome.Sharp.IconButton iconButton_AddFood;
        private FontAwesome.Sharp.IconButton iconButton_CheckOut;
        private FontAwesome.Sharp.IconButton iconButton_Discount;
        private System.Windows.Forms.NumericUpDown num_Discount;
        private FontAwesome.Sharp.IconButton iconButton_SwitchTable;
        private System.Windows.Forms.ComboBox comboBox_SwitchTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox_TotalPrice;
    }
}