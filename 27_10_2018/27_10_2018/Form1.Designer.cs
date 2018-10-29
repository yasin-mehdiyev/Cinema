namespace _27_10_2018
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
            this.BtnHall1 = new System.Windows.Forms.Button();
            this.BtnHall2 = new System.Windows.Forms.Button();
            this.BtnHall3 = new System.Windows.Forms.Button();
            this.PnlAddBtn = new System.Windows.Forms.Panel();
            this.selectedLbl = new System.Windows.Forms.Label();
            this.LblSeats = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.TotalBook = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHall1
            // 
            this.BtnHall1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHall1.Location = new System.Drawing.Point(23, 44);
            this.BtnHall1.Name = "BtnHall1";
            this.BtnHall1.Size = new System.Drawing.Size(159, 57);
            this.BtnHall1.TabIndex = 0;
            this.BtnHall1.Text = "Milyonluq quş";
            this.BtnHall1.UseVisualStyleBackColor = true;
            this.BtnHall1.Click += new System.EventHandler(this.SelectHall_Click);
            // 
            // BtnHall2
            // 
            this.BtnHall2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHall2.Location = new System.Drawing.Point(23, 128);
            this.BtnHall2.Name = "BtnHall2";
            this.BtnHall2.Size = new System.Drawing.Size(159, 57);
            this.BtnHall2.TabIndex = 1;
            this.BtnHall2.Text = "Qaragöz\r\n";
            this.BtnHall2.UseVisualStyleBackColor = true;
            this.BtnHall2.Click += new System.EventHandler(this.SelectHall_Click);
            // 
            // BtnHall3
            // 
            this.BtnHall3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHall3.Location = new System.Drawing.Point(23, 213);
            this.BtnHall3.Name = "BtnHall3";
            this.BtnHall3.Size = new System.Drawing.Size(159, 57);
            this.BtnHall3.TabIndex = 2;
            this.BtnHall3.Text = "Göktaşı\r\n";
            this.BtnHall3.UseVisualStyleBackColor = true;
            this.BtnHall3.Click += new System.EventHandler(this.SelectHall_Click);
            // 
            // PnlAddBtn
            // 
            this.PnlAddBtn.Location = new System.Drawing.Point(267, 62);
            this.PnlAddBtn.Name = "PnlAddBtn";
            this.PnlAddBtn.Size = new System.Drawing.Size(808, 583);
            this.PnlAddBtn.TabIndex = 1;
            // 
            // selectedLbl
            // 
            this.selectedLbl.AutoSize = true;
            this.selectedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedLbl.Location = new System.Drawing.Point(23, 316);
            this.selectedLbl.Name = "selectedLbl";
            this.selectedLbl.Size = new System.Drawing.Size(138, 25);
            this.selectedLbl.TabIndex = 2;
            this.selectedLbl.Text = "Seçilmiş yerlər";
            // 
            // LblSeats
            // 
            this.LblSeats.AutoSize = true;
            this.LblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeats.Location = new System.Drawing.Point(24, 364);
            this.LblSeats.Name = "LblSeats";
            this.LblSeats.Size = new System.Drawing.Size(23, 25);
            this.LblSeats.TabIndex = 2;
            this.LblSeats.Text = "0";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(24, 437);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(78, 25);
            this.TotalLbl.TabIndex = 2;
            this.TotalLbl.Text = "Toplam";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.Location = new System.Drawing.Point(24, 488);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(23, 25);
            this.LblTotalPrice.TabIndex = 2;
            this.LblTotalPrice.Text = "0";
            // 
            // TotalBook
            // 
            this.TotalBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBook.Location = new System.Drawing.Point(27, 576);
            this.TotalBook.Name = "TotalBook";
            this.TotalBook.Size = new System.Drawing.Size(138, 59);
            this.TotalBook.TabIndex = 3;
            this.TotalBook.Text = "Rezerv";
            this.TotalBook.UseVisualStyleBackColor = true;
            this.TotalBook.Visible = false;
            this.TotalBook.Click += new System.EventHandler(this.TotalBook_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(535, 44);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(70, 26);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "label1";
            this.TitleLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 706);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.TotalBook);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.LblSeats);
            this.Controls.Add(this.selectedLbl);
            this.Controls.Add(this.PnlAddBtn);
            this.Controls.Add(this.BtnHall3);
            this.Controls.Add(this.BtnHall2);
            this.Controls.Add(this.BtnHall1);
            this.Name = "Form1";
            this.Text = "Cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHall1;
        private System.Windows.Forms.Button BtnHall2;
        private System.Windows.Forms.Button BtnHall3;
        private System.Windows.Forms.Panel PnlAddBtn;
        private System.Windows.Forms.Label selectedLbl;
        private System.Windows.Forms.Label LblSeats;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Button TotalBook;
        private System.Windows.Forms.Label TitleLbl;
    }
}

