
namespace AutocompletTextBox_Smart
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox13 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(503, 20);
            this.textBox1.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(3, 61);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 34);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.94382F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.05618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 101);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // listBox13
            // 
            this.listBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox13.FormattingEnabled = true;
            this.listBox13.ItemHeight = 20;
            this.listBox13.Location = new System.Drawing.Point(68, 121);
            this.listBox13.Name = "listBox13";
            this.listBox13.Size = new System.Drawing.Size(504, 104);
            this.listBox13.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox13);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox13;
    }
}