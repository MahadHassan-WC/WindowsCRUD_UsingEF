namespace WindowsCRUD_UsingEF
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
            dataGridView1 = new DataGridView();
            btnCreate = new Button();
            txtDogName = new TextBox();
            txtWeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            txtId = new TextBox();
            btnDelete = new Button();
            label4 = new Label();
            txtFavoriteFood = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 301);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1193, 532);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(14, 180);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(214, 101);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtDogName
            // 
            txtDogName.Location = new Point(14, 88);
            txtDogName.Margin = new Padding(3, 4, 3, 4);
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(306, 27);
            txtDogName.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(344, 88);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(306, 27);
            txtWeight.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 64);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Dog Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 64);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Dog Weight:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(234, 180);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(217, 101);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(14, 16);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(458, 180);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(341, 101);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(675, 64);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 12;
            label4.Text = "Favorite Food:";
            // 
            // txtFavoriteFood
            // 
            txtFavoriteFood.Location = new Point(675, 88);
            txtFavoriteFood.Margin = new Padding(3, 4, 3, 4);
            txtFavoriteFood.Name = "txtFavoriteFood";
            txtFavoriteFood.Size = new Size(306, 27);
            txtFavoriteFood.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 849);
            Controls.Add(label4);
            Controls.Add(txtFavoriteFood);
            Controls.Add(btnDelete);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWeight);
            Controls.Add(txtDogName);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "CRUD Using EF Core";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCreate;
        private TextBox txtDogName;
        private TextBox txtWeight;
        private Label label1;
        private Label label2;
        private Button btnUpdate;
        private TextBox txtId;
        private Button btnDelete;
        private Label label4;
        private TextBox txtFavoriteFood;
    }
}
