
namespace TicTac
{
    partial class TicTac
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btA1 = new System.Windows.Forms.Button();
            this.btB1 = new System.Windows.Forms.Button();
            this.btC1 = new System.Windows.Forms.Button();
            this.btA2 = new System.Windows.Forms.Button();
            this.btB2 = new System.Windows.Forms.Button();
            this.btC2 = new System.Windows.Forms.Button();
            this.btA3 = new System.Windows.Forms.Button();
            this.btB3 = new System.Windows.Forms.Button();
            this.btC3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.lbO = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.Ngame);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.Info);
            // 
            // btA1
            // 
            this.btA1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btA1.Location = new System.Drawing.Point(12, 45);
            this.btA1.Name = "btA1";
            this.btA1.Size = new System.Drawing.Size(69, 59);
            this.btA1.TabIndex = 1;
            this.btA1.UseVisualStyleBackColor = true;
            this.btA1.Click += new System.EventHandler(this.BtClick);
            this.btA1.MouseEnter += new System.EventHandler(this.MEnter);
            this.btA1.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btB1
            // 
            this.btB1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btB1.Location = new System.Drawing.Point(87, 45);
            this.btB1.Name = "btB1";
            this.btB1.Size = new System.Drawing.Size(69, 59);
            this.btB1.TabIndex = 2;
            this.btB1.UseVisualStyleBackColor = true;
            this.btB1.Click += new System.EventHandler(this.BtClick);
            this.btB1.MouseEnter += new System.EventHandler(this.MEnter);
            this.btB1.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btC1
            // 
            this.btC1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btC1.Location = new System.Drawing.Point(162, 45);
            this.btC1.Name = "btC1";
            this.btC1.Size = new System.Drawing.Size(69, 59);
            this.btC1.TabIndex = 3;
            this.btC1.UseVisualStyleBackColor = true;
            this.btC1.Click += new System.EventHandler(this.BtClick);
            this.btC1.MouseEnter += new System.EventHandler(this.MEnter);
            this.btC1.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btA2
            // 
            this.btA2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btA2.Location = new System.Drawing.Point(13, 110);
            this.btA2.Name = "btA2";
            this.btA2.Size = new System.Drawing.Size(69, 59);
            this.btA2.TabIndex = 4;
            this.btA2.UseVisualStyleBackColor = true;
            this.btA2.Click += new System.EventHandler(this.BtClick);
            this.btA2.MouseEnter += new System.EventHandler(this.MEnter);
            this.btA2.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btB2
            // 
            this.btB2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btB2.Location = new System.Drawing.Point(87, 110);
            this.btB2.Name = "btB2";
            this.btB2.Size = new System.Drawing.Size(69, 59);
            this.btB2.TabIndex = 5;
            this.btB2.UseVisualStyleBackColor = true;
            this.btB2.Click += new System.EventHandler(this.BtClick);
            this.btB2.MouseEnter += new System.EventHandler(this.MEnter);
            this.btB2.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btC2
            // 
            this.btC2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btC2.Location = new System.Drawing.Point(162, 110);
            this.btC2.Name = "btC2";
            this.btC2.Size = new System.Drawing.Size(69, 59);
            this.btC2.TabIndex = 6;
            this.btC2.UseVisualStyleBackColor = true;
            this.btC2.Click += new System.EventHandler(this.BtClick);
            this.btC2.MouseEnter += new System.EventHandler(this.MEnter);
            this.btC2.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btA3
            // 
            this.btA3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btA3.Location = new System.Drawing.Point(12, 175);
            this.btA3.Name = "btA3";
            this.btA3.Size = new System.Drawing.Size(69, 59);
            this.btA3.TabIndex = 7;
            this.btA3.UseVisualStyleBackColor = true;
            this.btA3.Click += new System.EventHandler(this.BtClick);
            this.btA3.MouseEnter += new System.EventHandler(this.MEnter);
            this.btA3.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btB3
            // 
            this.btB3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btB3.Location = new System.Drawing.Point(87, 175);
            this.btB3.Name = "btB3";
            this.btB3.Size = new System.Drawing.Size(69, 59);
            this.btB3.TabIndex = 8;
            this.btB3.UseVisualStyleBackColor = true;
            this.btB3.Click += new System.EventHandler(this.BtClick);
            this.btB3.MouseEnter += new System.EventHandler(this.MEnter);
            this.btB3.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // btC3
            // 
            this.btC3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btC3.Location = new System.Drawing.Point(162, 175);
            this.btC3.Name = "btC3";
            this.btC3.Size = new System.Drawing.Size(69, 59);
            this.btC3.TabIndex = 9;
            this.btC3.UseVisualStyleBackColor = true;
            this.btC3.Click += new System.EventHandler(this.BtClick);
            this.btC3.MouseEnter += new System.EventHandler(this.MEnter);
            this.btC3.MouseLeave += new System.EventHandler(this.MLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNo);
            this.groupBox1.Controls.Add(this.lbO);
            this.groupBox1.Controls.Add(this.lbX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scores";
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNo.Location = new System.Drawing.Point(175, 104);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(19, 21);
            this.lbNo.TabIndex = 5;
            this.lbNo.Text = "0";
            // 
            // lbO
            // 
            this.lbO.AutoSize = true;
            this.lbO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbO.Location = new System.Drawing.Point(175, 73);
            this.lbO.Name = "lbO";
            this.lbO.Size = new System.Drawing.Size(19, 21);
            this.lbO.TabIndex = 4;
            this.lbO.Text = "0";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbX.Location = new System.Drawing.Point(175, 42);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(19, 21);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Winner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Winner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Winner";
            // 
            // TicTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btC3);
            this.Controls.Add(this.btB3);
            this.Controls.Add(this.btA3);
            this.Controls.Add(this.btC2);
            this.Controls.Add(this.btB2);
            this.Controls.Add(this.btA2);
            this.Controls.Add(this.btC1);
            this.Controls.Add(this.btB1);
            this.Controls.Add(this.btA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTac";
            this.Text = "TicTac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btA1;
        private System.Windows.Forms.Button btB1;
        private System.Windows.Forms.Button btC1;
        private System.Windows.Forms.Button btA2;
        private System.Windows.Forms.Button btB2;
        private System.Windows.Forms.Button btC2;
        private System.Windows.Forms.Button btA3;
        private System.Windows.Forms.Button btB3;
        private System.Windows.Forms.Button btC3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.Label lbO;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        
    }
}

