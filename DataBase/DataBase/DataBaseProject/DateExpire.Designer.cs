namespace DataBaseProject
{
    partial class marfa_Alimentare
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
            this.lp_summa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_produce = new System.Windows.Forms.DateTimePicker();
            this.date_expire = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Produce Price";
            // 
            // lp_summa
            // 
            this.lp_summa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_summa.Location = new System.Drawing.Point(35, 85);
            this.lp_summa.Multiline = true;
            this.lp_summa.Name = "lp_summa";
            this.lp_summa.Size = new System.Drawing.Size(288, 62);
            this.lp_summa.TabIndex = 1;
            this.lp_summa.TextChanged += new System.EventHandler(this.lp_summa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expire";
            // 
            // Date_produce
            // 
            this.Date_produce.Location = new System.Drawing.Point(12, 249);
            this.Date_produce.Name = "Date_produce";
            this.Date_produce.Size = new System.Drawing.Size(293, 26);
            this.Date_produce.TabIndex = 2;
            // 
            // date_expire
            // 
            this.date_expire.Location = new System.Drawing.Point(311, 249);
            this.date_expire.Name = "date_expire";
            this.date_expire.Size = new System.Drawing.Size(301, 26);
            this.date_expire.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(172, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marfa_Alimentare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_expire);
            this.Controls.Add(this.Date_produce);
            this.Controls.Add(this.lp_summa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "marfa_Alimentare";
            this.Text = "DateExpire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lp_summa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Date_produce;
        private System.Windows.Forms.DateTimePicker date_expire;
        private System.Windows.Forms.Button button1;
    }
}