namespace ChatServer
{
    partial class DivingServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivingServer));
            this.labelResultDetails = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAthlete = new System.Windows.Forms.ListBox();
            this.labelAthleteID = new System.Windows.Forms.Label();
            this.labelAthleteName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAthleteParameter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResultDetails
            // 
            this.labelResultDetails.Location = new System.Drawing.Point(0, 455);
            this.labelResultDetails.Name = "labelResultDetails";
            this.labelResultDetails.Size = new System.Drawing.Size(651, 96);
            this.labelResultDetails.TabIndex = 0;
            this.labelResultDetails.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnListen.ForeColor = System.Drawing.Color.Red;
            this.btnListen.Location = new System.Drawing.Point(217, 100);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(391, 77);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "2.开始对选中参赛者评分";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.选择队员";
            // 
            // listBoxAthlete
            // 
            this.listBoxAthlete.FormattingEnabled = true;
            this.listBoxAthlete.Location = new System.Drawing.Point(7, 100);
            this.listBoxAthlete.Name = "listBoxAthlete";
            this.listBoxAthlete.Size = new System.Drawing.Size(193, 199);
            this.listBoxAthlete.TabIndex = 5;
            // 
            // labelAthleteID
            // 
            this.labelAthleteID.AutoSize = true;
            this.labelAthleteID.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAthleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteID.ForeColor = System.Drawing.Color.Green;
            this.labelAthleteID.Location = new System.Drawing.Point(333, 40);
            this.labelAthleteID.Name = "labelAthleteID";
            this.labelAthleteID.Size = new System.Drawing.Size(0, 20);
            this.labelAthleteID.TabIndex = 6;
            // 
            // labelAthleteName
            // 
            this.labelAthleteName.AutoSize = true;
            this.labelAthleteName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAthleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteName.ForeColor = System.Drawing.Color.Green;
            this.labelAthleteName.Location = new System.Drawing.Point(423, 40);
            this.labelAthleteName.Name = "labelAthleteName";
            this.labelAthleteName.Size = new System.Drawing.Size(0, 20);
            this.labelAthleteName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(181, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "选中参赛者";
            // 
            // labelAthleteParameter
            // 
            this.labelAthleteParameter.AutoSize = true;
            this.labelAthleteParameter.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAthleteParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteParameter.ForeColor = System.Drawing.Color.Green;
            this.labelAthleteParameter.Location = new System.Drawing.Point(534, 40);
            this.labelAthleteParameter.Name = "labelAthleteParameter";
            this.labelAthleteParameter.Size = new System.Drawing.Size(0, 20);
            this.labelAthleteParameter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(323, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(413, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(510, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "难度系数";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelResult.Location = new System.Drawing.Point(223, 210);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 22);
            this.labelResult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(9, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "评分详情：";
            // 
            // DivingServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAthleteParameter);
            this.Controls.Add(this.labelAthleteName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAthleteID);
            this.Controls.Add(this.listBoxAthlete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.labelResultDetails);
            this.ForeColor = System.Drawing.Color.Green;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DivingServer";
            this.Opacity = 0.95D;
            this.Text = "DivingServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DivingServer_FormClosed);
            this.Load += new System.EventHandler(this.DivingServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox labelResultDetails;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAthlete;
        private System.Windows.Forms.Label labelAthleteID;
        private System.Windows.Forms.Label labelAthleteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAthleteParameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label6;
    }
}

