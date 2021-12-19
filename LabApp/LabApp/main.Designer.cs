
namespace labapp
{
    partial class main
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Exit1B = new System.Windows.Forms.Button();
            this.TheoryB = new System.Windows.Forms.Button();
            this.PracticB = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainPanel.Controls.Add(this.Exit1B);
            this.MainPanel.Controls.Add(this.TheoryB);
            this.MainPanel.Controls.Add(this.PracticB);
            this.MainPanel.Location = new System.Drawing.Point(0, -2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 453);
            this.MainPanel.TabIndex = 3;
            // 
            // Exit1B
            // 
            this.Exit1B.BackColor = System.Drawing.SystemColors.Control;
            this.Exit1B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit1B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit1B.Location = new System.Drawing.Point(211, 337);
            this.Exit1B.Name = "Exit1B";
            this.Exit1B.Size = new System.Drawing.Size(363, 51);
            this.Exit1B.TabIndex = 2;
            this.Exit1B.Text = "Выход";
            this.Exit1B.UseVisualStyleBackColor = false;
            this.Exit1B.Click += new System.EventHandler(this.Exit1B_Click);
            // 
            // TheoryB
            // 
            this.TheoryB.BackColor = System.Drawing.SystemColors.Control;
            this.TheoryB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheoryB.Enabled = false;
            this.TheoryB.Location = new System.Drawing.Point(437, 81);
            this.TheoryB.Name = "TheoryB";
            this.TheoryB.Size = new System.Drawing.Size(363, 58);
            this.TheoryB.TabIndex = 1;
            this.TheoryB.Text = "Теоретическая часть";
            this.TheoryB.UseVisualStyleBackColor = false;
            this.TheoryB.Click += new System.EventHandler(this.TheoryB_Click);
            // 
            // PracticB
            // 
            this.PracticB.BackColor = System.Drawing.SystemColors.Control;
            this.PracticB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PracticB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PracticB.Location = new System.Drawing.Point(12, 81);
            this.PracticB.Name = "PracticB";
            this.PracticB.Size = new System.Drawing.Size(363, 58);
            this.PracticB.TabIndex = 0;
            this.PracticB.Text = "Практическая часть";
            this.PracticB.UseVisualStyleBackColor = false;
            this.PracticB.Click += new System.EventHandler(this.PracticB_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "main";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Exit1B;
        private System.Windows.Forms.Button TheoryB;
        private System.Windows.Forms.Button PracticB;
    }
}

