using System.Data.SqlClient;

namespace Lab2
{
    
    partial class QueryEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        const string ConnectionString = @"Data Source = KIRILL_COMP\SQLEXPRESS;Initial Catalog = Football; Integrated Security = True";
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
            this.TestInput = new System.Windows.Forms.RichTextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.DoSQLbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TestInput
            // 
            this.TestInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestInput.Location = new System.Drawing.Point(40, 29);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(470, 122);
            this.TestInput.TabIndex = 0;
            this.TestInput.Text = "SELECT";
            // 
            // Clearbutton
            // 
            this.Clearbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.Location = new System.Drawing.Point(525, 72);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(109, 38);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // DoSQLbutton
            // 
            this.DoSQLbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoSQLbutton.Location = new System.Drawing.Point(525, 29);
            this.DoSQLbutton.Name = "DoSQLbutton";
            this.DoSQLbutton.Size = new System.Drawing.Size(109, 37);
            this.DoSQLbutton.TabIndex = 2;
            this.DoSQLbutton.Text = "Do SQL";
            this.DoSQLbutton.UseVisualStyleBackColor = true;
            this.DoSQLbutton.Click += new System.EventHandler(this.DoSQLbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(525, 116);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(109, 35);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // QueryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.DoSQLbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.TestInput);
            this.Name = "QueryEdit";
            this.Text = "QueryEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TestInput;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button DoSQLbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}