
namespace AutocompletTextBox_Smart
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
            this.TxbNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbNames = new System.Windows.Forms.ComboBox();
            this.comboBox1_ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxbNombres
            // 
            this.TxbNombres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxbNombres.Location = new System.Drawing.Point(178, 40);
            this.TxbNombres.Name = "TxbNombres";
            this.TxbNombres.Size = new System.Drawing.Size(477, 20);
            this.TxbNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 141);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmbNames
            // 
            this.CmbNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CmbNames.FormattingEnabled = true;
            this.CmbNames.Location = new System.Drawing.Point(179, 64);
            this.CmbNames.Name = "CmbNames";
            this.CmbNames.Size = new System.Drawing.Size(475, 28);
            this.CmbNames.TabIndex = 5;
            this.CmbNames.DropDown += new System.EventHandler(this.CmbNames_DropDown);
            this.CmbNames.SelectedIndexChanged += new System.EventHandler(this.CmbNames_SelectedIndexChanged);
            this.CmbNames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmbNames_MouseClick);
            this.CmbNames.MouseCaptureChanged += new System.EventHandler(this.CmbNames_MouseCaptureChanged);
            this.CmbNames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmbNames_MouseDown);
            this.CmbNames.MouseHover += new System.EventHandler(this.CmbNames_MouseHover);
            this.CmbNames.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CmbNames_MouseMove);
            // 
            // comboBox1_
            // 
            this.comboBox1_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_.FormattingEnabled = true;
            this.comboBox1_.Location = new System.Drawing.Point(127, 377);
            this.comboBox1_.Name = "comboBox1_";
            this.comboBox1_.Size = new System.Drawing.Size(330, 21);
            this.comboBox1_.TabIndex = 6;
            this.comboBox1_.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            this.comboBox1_.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1_);
            this.Controls.Add(this.CmbNames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbNombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbNames;
        private System.Windows.Forms.ComboBox comboBox1_;
    }
}

