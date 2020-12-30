
namespace showMeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.addTime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeoutValue = new System.Windows.Forms.NumericUpDown();
            this.pathToIcon = new System.Windows.Forms.TextBox();
            this.addIcon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNotify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleNotify = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 43);
            this.label5.TabIndex = 23;
            this.label5.Text = "Czas pojawi się w \"Tekst powiadomienia\" na samym końcu tekstu. \r\nCzas powiadomien" +
    "ia jest podawana w milisekundach. \r\n1 sekunda jest równa 1000 milisekundom.\r\n";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(297, 158);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 22;
            this.update.Text = "Zaaktualizuj";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // addTime
            // 
            this.addTime.AutoSize = true;
            this.addTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTime.Location = new System.Drawing.Point(62, 158);
            this.addTime.Name = "addTime";
            this.addTime.Size = new System.Drawing.Size(82, 17);
            this.addTime.TabIndex = 21;
            this.addTime.Text = "Dodaj czas:";
            this.addTime.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Czas powiadomienia:";
            // 
            // timeoutValue
            // 
            this.timeoutValue.Location = new System.Drawing.Point(130, 132);
            this.timeoutValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeoutValue.Name = "timeoutValue";
            this.timeoutValue.Size = new System.Drawing.Size(242, 20);
            this.timeoutValue.TabIndex = 19;
            // 
            // pathToIcon
            // 
            this.pathToIcon.Location = new System.Drawing.Point(130, 106);
            this.pathToIcon.Name = "pathToIcon";
            this.pathToIcon.Size = new System.Drawing.Size(161, 20);
            this.pathToIcon.TabIndex = 18;
            // 
            // addIcon
            // 
            this.addIcon.Location = new System.Drawing.Point(297, 104);
            this.addIcon.Name = "addIcon";
            this.addIcon.Size = new System.Drawing.Size(75, 23);
            this.addIcon.TabIndex = 17;
            this.addIcon.Text = "Wybierz";
            this.addIcon.UseVisualStyleBackColor = true;
            this.addIcon.Click += new System.EventHandler(this.addIcon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ikona powiadomienia:";
            // 
            // textNotify
            // 
            this.textNotify.Location = new System.Drawing.Point(130, 35);
            this.textNotify.Multiline = true;
            this.textNotify.Name = "textNotify";
            this.textNotify.Size = new System.Drawing.Size(242, 63);
            this.textNotify.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tekst powiadomienia:";
            // 
            // titleNotify
            // 
            this.titleNotify.Location = new System.Drawing.Point(130, 9);
            this.titleNotify.Name = "titleNotify";
            this.titleNotify.Size = new System.Drawing.Size(242, 20);
            this.titleNotify.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tytuł powiadomienia:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Ikona (*.ico)|*.ico";
            this.openFileDialog1.Title = "Wybierz ikonę";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeoutValue);
            this.Controls.Add(this.pathToIcon);
            this.Controls.Add(this.addIcon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNotify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleNotify);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(400, 275);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notify Tool - Stworzone przez KrzysiekSiemv";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeoutValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.CheckBox addTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown timeoutValue;
        private System.Windows.Forms.TextBox pathToIcon;
        private System.Windows.Forms.Button addIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNotify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleNotify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}