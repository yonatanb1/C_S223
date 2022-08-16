namespace lab4
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.objectname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ErrorProvider(this.components);
            this.priceerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.displaytable = new System.Windows.Forms.DataGridView();
            this.objname = new System.Windows.Forms.ErrorProvider(this.components);
            this.inv = new System.Windows.Forms.ErrorProvider(this.components);
            this.cnt = new System.Windows.Forms.ErrorProvider(this.components);
            this.avaliableTextBox = new System.Windows.Forms.Label();
            this.availableYes = new System.Windows.Forms.RadioButton();
            this.avialableNo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.orderCompleted = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaytable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(42, 68);
            this.number.Margin = new System.Windows.Forms.Padding(4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(163, 22);
            this.number.TabIndex = 1;
            this.number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(42, 493);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(179, 28);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(628, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inventory number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inventory
            // 
            this.inventory.Location = new System.Drawing.Point(634, 71);
            this.inventory.Margin = new System.Windows.Forms.Padding(4);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(340, 22);
            this.inventory.TabIndex = 4;
            this.inventory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(299, 69);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(241, 22);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(293, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // objectname
            // 
            this.objectname.Location = new System.Drawing.Point(43, 164);
            this.objectname.Margin = new System.Windows.Forms.Padding(4);
            this.objectname.Name = "objectname";
            this.objectname.Size = new System.Drawing.Size(511, 22);
            this.objectname.TabIndex = 8;
            this.objectname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Object name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(39, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Count";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(347, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(43, 260);
            this.count.Margin = new System.Windows.Forms.Padding(4);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(269, 22);
            this.count.TabIndex = 12;
            this.count.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(353, 260);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(201, 22);
            this.price.TabIndex = 13;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(337, 493);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(203, 28);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // name
            // 
            this.name.ContainerControl = this;
            // 
            // priceerror
            // 
            this.priceerror.ContainerControl = this;
            // 
            // displaytable
            // 
            this.displaytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaytable.Location = new System.Drawing.Point(45, 573);
            this.displaytable.Margin = new System.Windows.Forms.Padding(4);
            this.displaytable.Name = "displaytable";
            this.displaytable.RowHeadersWidth = 51;
            this.displaytable.Size = new System.Drawing.Size(995, 185);
            this.displaytable.TabIndex = 15;
            this.displaytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displaytable_CellContentClick_1);
            // 
            // objname
            // 
            this.objname.ContainerControl = this;
            // 
            // inv
            // 
            this.inv.ContainerControl = this;
            // 
            // cnt
            // 
            this.cnt.ContainerControl = this;
            // 
            // avaliableTextBox
            // 
            this.avaliableTextBox.AutoSize = true;
            this.avaliableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.avaliableTextBox.Location = new System.Drawing.Point(628, 129);
            this.avaliableTextBox.Name = "avaliableTextBox";
            this.avaliableTextBox.Size = new System.Drawing.Size(143, 31);
            this.avaliableTextBox.TabIndex = 16;
            this.avaliableTextBox.Text = "Availability";
            // 
            // availableYes
            // 
            this.availableYes.AutoSize = true;
            this.availableYes.Location = new System.Drawing.Point(634, 191);
            this.availableYes.Name = "availableYes";
            this.availableYes.Size = new System.Drawing.Size(52, 20);
            this.availableYes.TabIndex = 17;
            this.availableYes.TabStop = true;
            this.availableYes.Text = "Yes";
            this.availableYes.UseVisualStyleBackColor = true;
            // 
            // avialableNo
            // 
            this.avialableNo.AutoSize = true;
            this.avialableNo.Location = new System.Drawing.Point(725, 191);
            this.avialableNo.Name = "avialableNo";
            this.avialableNo.Size = new System.Drawing.Size(46, 20);
            this.avialableNo.TabIndex = 18;
            this.avialableNo.TabStop = true;
            this.avialableNo.Text = "No";
            this.avialableNo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label7.Location = new System.Drawing.Point(628, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Additional services";
            // 
            // checkedList
            // 
            this.checkedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.checkedList.FormattingEnabled = true;
            this.checkedList.Items.AddRange(new object[] {
            "Transportation",
            "Installation",
            "Load/Unload"});
            this.checkedList.Location = new System.Drawing.Point(634, 375);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(261, 96);
            this.checkedList.TabIndex = 20;
            // 
            // orderCompleted
            // 
            this.orderCompleted.AutoSize = true;
            this.orderCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.orderCompleted.Location = new System.Drawing.Point(634, 250);
            this.orderCompleted.Name = "orderCompleted";
            this.orderCompleted.Size = new System.Drawing.Size(222, 35);
            this.orderCompleted.TabIndex = 21;
            this.orderCompleted.Text = "Order complete";
            this.orderCompleted.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1100, 771);
            this.Controls.Add(this.orderCompleted);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avialableNo);
            this.Controls.Add(this.availableYes);
            this.Controls.Add(this.avaliableTextBox);
            this.Controls.Add(this.displaytable);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.objectname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaytable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox objectname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider name;
        private System.Windows.Forms.ErrorProvider priceerror;
        private System.Windows.Forms.DataGridView displaytable;
        private System.Windows.Forms.ErrorProvider objname;
        private System.Windows.Forms.ErrorProvider inv;
        private System.Windows.Forms.ErrorProvider cnt;
        private System.Windows.Forms.Label avaliableTextBox;
        private System.Windows.Forms.RadioButton avialableNo;
        private System.Windows.Forms.RadioButton availableYes;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox orderCompleted;
    }
}