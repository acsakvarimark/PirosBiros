namespace Hotcakes_PirosBiros
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termék_Neve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlane = new System.Windows.Forms.Button();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonAccess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToResizeColumns = false;
            this.productsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGridView.ColumnHeadersHeight = 35;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Termék_Neve,
            this.Ár});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGridView.EnableHeadersVisualStyles = false;
            this.productsDataGridView.GridColor = System.Drawing.Color.LightGray;
            this.productsDataGridView.Location = new System.Drawing.Point(303, 82);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.RowHeadersWidth = 25;
            this.productsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.productsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.productsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productsDataGridView.RowTemplate.DividerHeight = 1;
            this.productsDataGridView.RowTemplate.Height = 25;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(645, 370);
            this.productsDataGridView.TabIndex = 0;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Termék_Neve
            // 
            this.Termék_Neve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Termék_Neve.DataPropertyName = "Termék_Neve";
            this.Termék_Neve.HeaderText = "Termék Neve";
            this.Termék_Neve.Name = "Termék_Neve";
            this.Termék_Neve.ReadOnly = true;
            // 
            // Ár
            // 
            this.Ár.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ár.DataPropertyName = "Ár";
            this.Ár.FillWeight = 50F;
            this.Ár.HeaderText = "Ár";
            this.Ár.Name = "Ár";
            this.Ár.ReadOnly = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(12, 47);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(278, 25);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(635, 47);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(161, 25);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox_Validating);
            this.priceTextBox.Validated += new System.EventHandler(this.priceTextBox_Validated);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(804, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&FRISSÍT!";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPrice.Location = new System.Drawing.Point(700, 27);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(37, 17);
            this.labelNewPrice.TabIndex = 8;
            this.labelNewPrice.Text = "Új Ár";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(401, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Kiválasztott Termék";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(91, 24);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(120, 17);
            this.labelFilter.TabIndex = 11;
            this.labelFilter.Text = "Termékek Keresése";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 33);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategóriák";
            // 
            // buttonPlane
            // 
            this.buttonPlane.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlane.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonPlane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlane.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlane.Location = new System.Drawing.Point(12, 143);
            this.buttonPlane.Name = "buttonPlane";
            this.buttonPlane.Size = new System.Drawing.Size(278, 54);
            this.buttonPlane.TabIndex = 13;
            this.buttonPlane.Text = "&REPÜLŐ";
            this.buttonPlane.UseVisualStyleBackColor = true;
            this.buttonPlane.Click += new System.EventHandler(this.buttonPlane_Click);
            // 
            // buttonTrain
            // 
            this.buttonTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.Location = new System.Drawing.Point(12, 228);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(278, 54);
            this.buttonTrain.TabIndex = 14;
            this.buttonTrain.Text = "&VONAT";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCar.Location = new System.Drawing.Point(12, 314);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(278, 54);
            this.buttonCar.TabIndex = 15;
            this.buttonCar.Text = "&AUTÓ";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonAccess
            // 
            this.buttonAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccess.Location = new System.Drawing.Point(12, 398);
            this.buttonAccess.Name = "buttonAccess";
            this.buttonAccess.Size = new System.Drawing.Size(278, 54);
            this.buttonAccess.TabIndex = 16;
            this.buttonAccess.Text = "&KIEGÉSZÍTŐ";
            this.buttonAccess.UseVisualStyleBackColor = true;
            this.buttonAccess.Click += new System.EventHandler(this.buttonAccess_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(303, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 25);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 467);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAccess);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.buttonPlane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.productsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PirosBiros Árfrissítő";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccess;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonPlane;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termék_Neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ár;
        private System.Windows.Forms.TextBox textBox1;
    }
}

