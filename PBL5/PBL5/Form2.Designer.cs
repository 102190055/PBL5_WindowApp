
namespace PBL5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCameraIn = new System.Windows.Forms.ComboBox();
            this.comboBoxCameraOut = new System.Windows.Forms.ComboBox();
            this.buttonConnectCamera1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnectCamera2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.buttonConnectCamera2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonConnectCamera1);
            this.groupBox1.Controls.Add(this.comboBoxCameraOut);
            this.groupBox1.Controls.Add(this.comboBoxCameraIn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn camera";
            // 
            // comboBoxCameraIn
            // 
            this.comboBoxCameraIn.FormattingEnabled = true;
            this.comboBoxCameraIn.Location = new System.Drawing.Point(22, 56);
            this.comboBoxCameraIn.Name = "comboBoxCameraIn";
            this.comboBoxCameraIn.Size = new System.Drawing.Size(178, 30);
            this.comboBoxCameraIn.TabIndex = 0;
            // 
            // comboBoxCameraOut
            // 
            this.comboBoxCameraOut.FormattingEnabled = true;
            this.comboBoxCameraOut.Location = new System.Drawing.Point(22, 112);
            this.comboBoxCameraOut.Name = "comboBoxCameraOut";
            this.comboBoxCameraOut.Size = new System.Drawing.Size(178, 30);
            this.comboBoxCameraOut.TabIndex = 1;
            // 
            // buttonConnectCamera1
            // 
            this.buttonConnectCamera1.BackColor = System.Drawing.Color.Salmon;
            this.buttonConnectCamera1.ForeColor = System.Drawing.Color.White;
            this.buttonConnectCamera1.Location = new System.Drawing.Point(206, 55);
            this.buttonConnectCamera1.Name = "buttonConnectCamera1";
            this.buttonConnectCamera1.Size = new System.Drawing.Size(107, 31);
            this.buttonConnectCamera1.TabIndex = 2;
            this.buttonConnectCamera1.Text = "Kết nối ";
            this.buttonConnectCamera1.UseVisualStyleBackColor = false;
            this.buttonConnectCamera1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Camera ra";
            // 
            // buttonConnectCamera2
            // 
            this.buttonConnectCamera2.BackColor = System.Drawing.Color.Salmon;
            this.buttonConnectCamera2.ForeColor = System.Drawing.Color.White;
            this.buttonConnectCamera2.Location = new System.Drawing.Point(206, 111);
            this.buttonConnectCamera2.Name = "buttonConnectCamera2";
            this.buttonConnectCamera2.Size = new System.Drawing.Size(107, 31);
            this.buttonConnectCamera2.TabIndex = 5;
            this.buttonConnectCamera2.Text = "Kết nối ";
            this.buttonConnectCamera2.UseVisualStyleBackColor = false;
            this.buttonConnectCamera2.Click += new System.EventHandler(this.buttonConnectCamera2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(401, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 218);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn cổng COM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(206, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết nối ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(206, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kết nối ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 30);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 30);
            this.comboBox2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form2";
            this.Text = "Cài đặt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnectCamera1;
        private System.Windows.Forms.ComboBox comboBoxCameraOut;
        private System.Windows.Forms.ComboBox comboBoxCameraIn;
        private System.Windows.Forms.Button buttonConnectCamera2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}