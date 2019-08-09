namespace Polymorphism6percent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cowmilk = new System.Windows.Forms.TextBox();
            this.txt_cow = new System.Windows.Forms.TextBox();
            this.txt_jersey = new System.Windows.Forms.TextBox();
            this.txt_goat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_browse = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.rtxt_result = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_goatmilk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cow Milk Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cow Vaccination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jersey Cow Vaccination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goat Vaccination:";
            // 
            // txt_cowmilk
            // 
            this.txt_cowmilk.Location = new System.Drawing.Point(170, 63);
            this.txt_cowmilk.Name = "txt_cowmilk";
            this.txt_cowmilk.Size = new System.Drawing.Size(100, 20);
            this.txt_cowmilk.TabIndex = 1;
            this.txt_cowmilk.TextChanged += new System.EventHandler(this.Txt_cowmilk_TextChanged);
            // 
            // txt_cow
            // 
            this.txt_cow.Location = new System.Drawing.Point(170, 121);
            this.txt_cow.Name = "txt_cow";
            this.txt_cow.Size = new System.Drawing.Size(100, 20);
            this.txt_cow.TabIndex = 3;
            this.txt_cow.TextChanged += new System.EventHandler(this.Txt_cow_TextChanged);
            // 
            // txt_jersey
            // 
            this.txt_jersey.Location = new System.Drawing.Point(170, 152);
            this.txt_jersey.Name = "txt_jersey";
            this.txt_jersey.Size = new System.Drawing.Size(100, 20);
            this.txt_jersey.TabIndex = 4;
            this.txt_jersey.TextChanged += new System.EventHandler(this.Txt_jersey_TextChanged);
            // 
            // txt_goat
            // 
            this.txt_goat.Location = new System.Drawing.Point(170, 181);
            this.txt_goat.Name = "txt_goat";
            this.txt_goat.Size = new System.Drawing.Size(100, 20);
            this.txt_goat.TabIndex = 5;
            this.txt_goat.TextChanged += new System.EventHandler(this.Txt_goat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Values:";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(29, 217);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 6;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // lbl_browse
            // 
            this.lbl_browse.AutoEllipsis = true;
            this.lbl_browse.Location = new System.Drawing.Point(110, 222);
            this.lbl_browse.Name = "lbl_browse";
            this.lbl_browse.Size = new System.Drawing.Size(160, 18);
            this.lbl_browse.TabIndex = 11;
            this.lbl_browse.Text = "No file";
            this.lbl_browse.TextChanged += new System.EventHandler(this.Lbl_browse_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(29, 248);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(118, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // rtxt_result
            // 
            this.rtxt_result.Location = new System.Drawing.Point(29, 277);
            this.rtxt_result.Name = "rtxt_result";
            this.rtxt_result.Size = new System.Drawing.Size(241, 96);
            this.rtxt_result.TabIndex = 13;
            this.rtxt_result.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Goat Milk Price:";
            // 
            // txt_goatmilk
            // 
            this.txt_goatmilk.Location = new System.Drawing.Point(170, 94);
            this.txt_goatmilk.Name = "txt_goatmilk";
            this.txt_goatmilk.Size = new System.Drawing.Size(100, 20);
            this.txt_goatmilk.TabIndex = 2;
            this.txt_goatmilk.TextChanged += new System.EventHandler(this.Txt_goatmilk_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(293, 393);
            this.Controls.Add(this.txt_goatmilk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxt_result);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_browse);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_goat);
            this.Controls.Add(this.txt_jersey);
            this.Controls.Add(this.txt_cow);
            this.Controls.Add(this.txt_cowmilk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Livestock Profitablilty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cowmilk;
        private System.Windows.Forms.TextBox txt_cow;
        private System.Windows.Forms.TextBox txt_jersey;
        private System.Windows.Forms.TextBox txt_goat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_browse;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RichTextBox rtxt_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_goatmilk;
    }
}

