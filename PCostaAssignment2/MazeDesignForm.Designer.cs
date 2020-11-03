namespace PCostaAssignment2
{
    partial class MazeDesignForm
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
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbxGreenBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pbxRedBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbxGreenDoor = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxRedDoor = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbxWall = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxNone = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMaze = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlToolBox.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenBox)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedBox)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenDoor)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedDoor)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWall)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns:";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(142, 9);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 31);
            this.txtRows.TabIndex = 2;
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(344, 9);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 31);
            this.txtColumns.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGenerate.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(633, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(82, 40);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtColumns);
            this.panel1.Controls.Add(this.txtRows);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(188, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 51);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "File";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.tsmFile.ForeColor = System.Drawing.Color.Silver;
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlToolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolBox.Controls.Add(this.panel8);
            this.pnlToolBox.Controls.Add(this.panel7);
            this.pnlToolBox.Controls.Add(this.panel6);
            this.pnlToolBox.Controls.Add(this.panel5);
            this.pnlToolBox.Controls.Add(this.panel4);
            this.pnlToolBox.Controls.Add(this.panel3);
            this.pnlToolBox.Controls.Add(this.label3);
            this.pnlToolBox.Location = new System.Drawing.Point(0, 23);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(190, 726);
            this.pnlToolBox.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.pbxGreenBox);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(14, 448);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 73);
            this.panel8.TabIndex = 4;
            // 
            // pbxGreenBox
            // 
            this.pbxGreenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxGreenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGreenBox.Image = global::PCostaAssignment2.Properties.Resources.GreenBox;
            this.pbxGreenBox.Location = new System.Drawing.Point(10, 4);
            this.pbxGreenBox.Name = "pbxGreenBox";
            this.pbxGreenBox.Size = new System.Drawing.Size(60, 60);
            this.pbxGreenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGreenBox.TabIndex = 8;
            this.pbxGreenBox.TabStop = false;
            this.pbxGreenBox.Click += new System.EventHandler(this.pbxGreenBox_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(79, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Green Box";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.pbxRedBox);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(14, 370);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 73);
            this.panel7.TabIndex = 3;
            // 
            // pbxRedBox
            // 
            this.pbxRedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRedBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRedBox.Image = global::PCostaAssignment2.Properties.Resources.RedBox;
            this.pbxRedBox.Location = new System.Drawing.Point(10, 4);
            this.pbxRedBox.Name = "pbxRedBox";
            this.pbxRedBox.Size = new System.Drawing.Size(60, 60);
            this.pbxRedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRedBox.TabIndex = 7;
            this.pbxRedBox.TabStop = false;
            this.pbxRedBox.Click += new System.EventHandler(this.pbxRedBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(86, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Red Box";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.pbxGreenDoor);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(14, 292);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 73);
            this.panel6.TabIndex = 3;
            // 
            // pbxGreenDoor
            // 
            this.pbxGreenDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxGreenDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxGreenDoor.Image = global::PCostaAssignment2.Properties.Resources.GreenDoor;
            this.pbxGreenDoor.Location = new System.Drawing.Point(10, 4);
            this.pbxGreenDoor.Name = "pbxGreenDoor";
            this.pbxGreenDoor.Size = new System.Drawing.Size(60, 60);
            this.pbxGreenDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGreenDoor.TabIndex = 6;
            this.pbxGreenDoor.TabStop = false;
            this.pbxGreenDoor.Click += new System.EventHandler(this.pbxGreenDoor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(77, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Green Door";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pbxRedDoor);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(14, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 73);
            this.panel5.TabIndex = 3;
            // 
            // pbxRedDoor
            // 
            this.pbxRedDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRedDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRedDoor.Image = global::PCostaAssignment2.Properties.Resources.RedDoor;
            this.pbxRedDoor.Location = new System.Drawing.Point(10, 3);
            this.pbxRedDoor.Name = "pbxRedDoor";
            this.pbxRedDoor.Size = new System.Drawing.Size(60, 60);
            this.pbxRedDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRedDoor.TabIndex = 5;
            this.pbxRedDoor.TabStop = false;
            this.pbxRedDoor.Click += new System.EventHandler(this.pbxRedDoor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(83, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Red Door";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pbxWall);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(14, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 73);
            this.panel4.TabIndex = 3;
            // 
            // pbxWall
            // 
            this.pbxWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxWall.Image = global::PCostaAssignment2.Properties.Resources.Wall;
            this.pbxWall.Location = new System.Drawing.Point(10, 3);
            this.pbxWall.Name = "pbxWall";
            this.pbxWall.Size = new System.Drawing.Size(60, 60);
            this.pbxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxWall.TabIndex = 4;
            this.pbxWall.TabStop = false;
            this.pbxWall.Click += new System.EventHandler(this.pbxWall_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(98, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wall";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pbxNone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(14, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 73);
            this.panel3.TabIndex = 1;
            // 
            // pbxNone
            // 
            this.pbxNone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxNone.Image = global::PCostaAssignment2.Properties.Resources.None;
            this.pbxNone.Location = new System.Drawing.Point(10, 3);
            this.pbxNone.Name = "pbxNone";
            this.pbxNone.Size = new System.Drawing.Size(60, 60);
            this.pbxNone.TabIndex = 3;
            this.pbxNone.TabStop = false;
            this.pbxNone.Click += new System.EventHandler(this.pbxNone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(96, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 27F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tool Box";
            // 
            // pnlMaze
            // 
            this.pnlMaze.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMaze.Location = new System.Drawing.Point(188, 73);
            this.pnlMaze.Name = "pnlMaze";
            this.pnlMaze.Size = new System.Drawing.Size(720, 676);
            this.pnlMaze.TabIndex = 8;
            // 
            // MazeDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 748);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMaze);
            this.Name = "MazeDesignForm";
            this.Text = "Design Form";
            this.Load += new System.EventHandler(this.MazeDesignForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenBox)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreenDoor)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRedDoor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWall)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxNone;
        private System.Windows.Forms.PictureBox pbxGreenBox;
        private System.Windows.Forms.PictureBox pbxRedBox;
        private System.Windows.Forms.PictureBox pbxGreenDoor;
        private System.Windows.Forms.PictureBox pbxRedDoor;
        private System.Windows.Forms.PictureBox pbxWall;
        private System.Windows.Forms.Panel pnlMaze;
    }
}