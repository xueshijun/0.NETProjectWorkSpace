namespace ChatClient
{
    partial class DivingClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DivingClient));
            this.label1 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAthleteID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAthleteName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAthleteParameter = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "在线评委：";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCount.Image = ((System.Drawing.Image)(resources.GetObject("labelCount.Image")));
            this.labelCount.Location = new System.Drawing.Point(107, 19);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(27, 20);
            this.labelCount.TabIndex = 9;
            this.labelCount.Text = "***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(223, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "当前评委：";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Image = ((System.Drawing.Image)(resources.GetObject("labelName.Image")));
            this.labelName.Location = new System.Drawing.Point(350, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(27, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "***";
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxScore.ForeColor = System.Drawing.Color.Red;
            this.textBoxScore.Location = new System.Drawing.Point(370, 141);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(268, 38);
            this.textBoxScore.TabIndex = 11;
            this.textBoxScore.Text = "9.9999";
            this.textBoxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(131, 305);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(350, 53);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "提交评分";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "评分标准:",
            "失败 0分",
            "不好 0．5～2分",
            "普通 2．5—4·5分",
            "较好 5～6分",
            "很好 6．5～8分",
            "最好 8～10分",
            "在比赛中，裁判员根据运动员的助跑（即走板、跑台）、起跳、空中动作和入水动作来评定分数。",
            "因此，运动员在比赛时助跑应平稳，起跳要果断有力，起跳角度要恰当，并具有一定高度；",
            "空中姿势优美，翻腾、转体快速；人水时身体与水面垂直，水花越小越好。",
            "n名裁判员打出分数以后，先删去最高和最低的无效分，",
            "余下（n-2）名裁判员的分数之和乘以运动员所跳动作的难度系数，便得出该动作的实得分。"});
            this.listBox1.Location = new System.Drawing.Point(-1, 381);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(650, 186);
            this.listBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "当前选手编号:";
            // 
            // labelAthleteID
            // 
            this.labelAthleteID.AutoSize = true;
            this.labelAthleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteID.Image = ((System.Drawing.Image)(resources.GetObject("labelAthleteID.Image")));
            this.labelAthleteID.Location = new System.Drawing.Point(127, 74);
            this.labelAthleteID.Name = "labelAthleteID";
            this.labelAthleteID.Size = new System.Drawing.Size(27, 20);
            this.labelAthleteID.TabIndex = 6;
            this.labelAthleteID.Text = "***";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(204, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "当前选手姓名:";
            // 
            // labelAthleteName
            // 
            this.labelAthleteName.AutoSize = true;
            this.labelAthleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteName.Image = ((System.Drawing.Image)(resources.GetObject("labelAthleteName.Image")));
            this.labelAthleteName.Location = new System.Drawing.Point(319, 74);
            this.labelAthleteName.Name = "labelAthleteName";
            this.labelAthleteName.Size = new System.Drawing.Size(27, 20);
            this.labelAthleteName.TabIndex = 6;
            this.labelAthleteName.Text = "***";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(388, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "当前选手难度系数:";
            // 
            // labelAthleteParameter
            // 
            this.labelAthleteParameter.AutoSize = true;
            this.labelAthleteParameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAthleteParameter.Image = ((System.Drawing.Image)(resources.GetObject("labelAthleteParameter.Image")));
            this.labelAthleteParameter.Location = new System.Drawing.Point(535, 74);
            this.labelAthleteParameter.Name = "labelAthleteParameter";
            this.labelAthleteParameter.Size = new System.Drawing.Size(27, 20);
            this.labelAthleteParameter.TabIndex = 6;
            this.labelAthleteParameter.Text = "***";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(125, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 6;
            this.label9.Text = "评委评分:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelID.Image = ((System.Drawing.Image)(resources.GetObject("labelID.Image")));
            this.labelID.Location = new System.Drawing.Point(317, 19);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 20);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "***";
            this.labelID.Visible = false;
            // 
            // DivingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 567);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelAthleteParameter);
            this.Controls.Add(this.labelAthleteName);
            this.Controls.Add(this.labelAthleteID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DivingClient";
            this.Opacity = 0.95D;
            this.Text = "Diving Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DivingClient_FormClosed);
            this.Load += new System.EventHandler(this.DivingClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAthleteID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAthleteName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAthleteParameter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelID;
    }
}

