namespace Calculater
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
            this.label1 = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.operater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Number1
            // 
            this.Number1.BackColor = System.Drawing.Color.CadetBlue;
            this.Number1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Number1.Location = new System.Drawing.Point(28, 38);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(315, 36);
            this.Number1.TabIndex = 3;
            this.Number1.Tag = "";
            this.Number1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Number2
            // 
            this.Number2.BackColor = System.Drawing.Color.CadetBlue;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Number2.Location = new System.Drawing.Point(27, 117);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(315, 36);
            this.Number2.TabIndex = 4;
            this.Number2.Tag = "";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Azure;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(28, 175);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 75);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtract
            // 
            this.subtract.BackColor = System.Drawing.Color.Azure;
            this.subtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(139, 175);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(94, 75);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Azure;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(140, 273);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(94, 75);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Azure;
            this.equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(249, 175);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(93, 173);
            this.equal.TabIndex = 8;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.Color.Azure;
            this.multiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiple.Location = new System.Drawing.Point(27, 273);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(94, 75);
            this.multiple.TabIndex = 9;
            this.multiple.Text = "x";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.result.Location = new System.Drawing.Point(145, 368);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(98, 26);
            this.result.TabIndex = 10;
            this.result.Text = "RESULT";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // operater
            // 
            this.operater.AutoSize = true;
            this.operater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operater.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.operater.Location = new System.Drawing.Point(166, 77);
            this.operater.Name = "operater";
            this.operater.Size = new System.Drawing.Size(0, 26);
            this.operater.TabIndex = 11;
            this.operater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(375, 417);
            this.Controls.Add(this.operater);
            this.Controls.Add(this.result);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label operater;
    }
}

