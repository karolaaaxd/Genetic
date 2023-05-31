namespace Projekt1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.provideequation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectmethod = new System.Windows.Forms.ComboBox();
            this.maxiteration = new System.Windows.Forms.TextBox();
            this.populationsize = new System.Windows.Forms.TextBox();
            this.mutationrate = new System.Windows.Forms.TextBox();
            this.crossoverrate = new System.Windows.Forms.TextBox();
            this.domaina = new System.Windows.Forms.TextBox();
            this.domainb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.solutionbox = new System.Windows.Forms.TextBox();
            this.fill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bestbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // provideequation
            // 
            this.provideequation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.provideequation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.provideequation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.provideequation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.provideequation.ForeColor = System.Drawing.Color.White;
            this.provideequation.Location = new System.Drawing.Point(400, 87);
            this.provideequation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provideequation.Multiline = true;
            this.provideequation.Name = "provideequation";
            this.provideequation.Size = new System.Drawing.Size(395, 27);
            this.provideequation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provide an equation:";
            // 
            // selectmethod
            // 
            this.selectmethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectmethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.selectmethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectmethod.ForeColor = System.Drawing.Color.White;
            this.selectmethod.FormattingEnabled = true;
            this.selectmethod.Items.AddRange(new object[] {
            "Rank",
            "Roulette",
            "Elite"});
            this.selectmethod.Location = new System.Drawing.Point(400, 151);
            this.selectmethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectmethod.Name = "selectmethod";
            this.selectmethod.Size = new System.Drawing.Size(393, 24);
            this.selectmethod.TabIndex = 2;
            // 
            // maxiteration
            // 
            this.maxiteration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.maxiteration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxiteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxiteration.ForeColor = System.Drawing.Color.White;
            this.maxiteration.Location = new System.Drawing.Point(103, 87);
            this.maxiteration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxiteration.Multiline = true;
            this.maxiteration.Name = "maxiteration";
            this.maxiteration.Size = new System.Drawing.Size(224, 27);
            this.maxiteration.TabIndex = 3;
            // 
            // populationsize
            // 
            this.populationsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.populationsize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.populationsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.populationsize.ForeColor = System.Drawing.Color.White;
            this.populationsize.Location = new System.Drawing.Point(103, 153);
            this.populationsize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.populationsize.Multiline = true;
            this.populationsize.Name = "populationsize";
            this.populationsize.Size = new System.Drawing.Size(224, 27);
            this.populationsize.TabIndex = 4;
            // 
            // mutationrate
            // 
            this.mutationrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.mutationrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mutationrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mutationrate.ForeColor = System.Drawing.Color.White;
            this.mutationrate.Location = new System.Drawing.Point(103, 217);
            this.mutationrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mutationrate.Multiline = true;
            this.mutationrate.Name = "mutationrate";
            this.mutationrate.Size = new System.Drawing.Size(224, 27);
            this.mutationrate.TabIndex = 5;
            // 
            // crossoverrate
            // 
            this.crossoverrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.crossoverrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crossoverrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.crossoverrate.ForeColor = System.Drawing.Color.White;
            this.crossoverrate.Location = new System.Drawing.Point(103, 277);
            this.crossoverrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crossoverrate.Multiline = true;
            this.crossoverrate.Name = "crossoverrate";
            this.crossoverrate.Size = new System.Drawing.Size(224, 27);
            this.crossoverrate.TabIndex = 6;
            // 
            // domaina
            // 
            this.domaina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.domaina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domaina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domaina.ForeColor = System.Drawing.Color.White;
            this.domaina.Location = new System.Drawing.Point(400, 217);
            this.domaina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domaina.Multiline = true;
            this.domaina.Name = "domaina";
            this.domaina.Size = new System.Drawing.Size(188, 27);
            this.domaina.TabIndex = 7;
            // 
            // domainb
            // 
            this.domainb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.domainb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domainb.ForeColor = System.Drawing.Color.White;
            this.domainb.Location = new System.Drawing.Point(593, 217);
            this.domainb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.domainb.Multiline = true;
            this.domainb.Name = "domainb";
            this.domainb.Size = new System.Drawing.Size(201, 27);
            this.domainb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max iteration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Population Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mutation rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Crossover rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(397, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Domain:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(397, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selection method:";
            // 
            // startbutton
            // 
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.ForeColor = System.Drawing.Color.White;
            this.startbutton.Location = new System.Drawing.Point(400, 277);
            this.startbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(188, 27);
            this.startbutton.TabIndex = 15;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // solutionbox
            // 
            this.solutionbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.solutionbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.solutionbox.ForeColor = System.Drawing.Color.White;
            this.solutionbox.Location = new System.Drawing.Point(103, 359);
            this.solutionbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.solutionbox.Multiline = true;
            this.solutionbox.Name = "solutionbox";
            this.solutionbox.Size = new System.Drawing.Size(692, 27);
            this.solutionbox.TabIndex = 17;
            // 
            // fill
            // 
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.ForeColor = System.Drawing.Color.White;
            this.fill.Location = new System.Drawing.Point(593, 277);
            this.fill.Margin = new System.Windows.Forms.Padding(4);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(201, 27);
            this.fill.TabIndex = 18;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(99, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Solution:";
            // 
            // bestbox
            // 
            this.bestbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bestbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bestbox.ForeColor = System.Drawing.Color.White;
            this.bestbox.Location = new System.Drawing.Point(103, 417);
            this.bestbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bestbox.Multiline = true;
            this.bestbox.Name = "bestbox";
            this.bestbox.Size = new System.Drawing.Size(692, 27);
            this.bestbox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(99, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Best:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(901, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bestbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.solutionbox);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainb);
            this.Controls.Add(this.domaina);
            this.Controls.Add(this.crossoverrate);
            this.Controls.Add(this.mutationrate);
            this.Controls.Add(this.populationsize);
            this.Controls.Add(this.maxiteration);
            this.Controls.Add(this.selectmethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.provideequation);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Projekt1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox provideequation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectmethod;
        private System.Windows.Forms.TextBox maxiteration;
        private System.Windows.Forms.TextBox populationsize;
        private System.Windows.Forms.TextBox mutationrate;
        private System.Windows.Forms.TextBox crossoverrate;
        private System.Windows.Forms.TextBox domaina;
        private System.Windows.Forms.TextBox domainb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.TextBox solutionbox;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bestbox;
        private System.Windows.Forms.Label label9;
    }
}

