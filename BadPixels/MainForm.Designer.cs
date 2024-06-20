/*
 * Created by SharpDevelop.
 * User: SerVer
 * Date: 14.06.2024
 * Time: 9:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
//using System.Drawing;
//using System.Windows.Forms;

 
 
namespace BadPixels
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.Label lblMade;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.group = new System.Windows.Forms.GroupBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMade = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.lblMade);
            this.group.Controls.Add(this.lblL);
            this.group.Controls.Add(this.lblBad);
            this.group.Controls.Add(this.btnStart);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Margin = new System.Windows.Forms.Padding(0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(600, 480);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // lblL
            // 
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL.Location = new System.Drawing.Point(0, 263);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(600, 89);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "LMB - change color\r\nRMB - exit";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBad
            // 
            this.lblBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBad.Location = new System.Drawing.Point(0, 0);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(600, 149);
            this.lblBad.TabIndex = 1;
            this.lblBad.Text = "Bad Pixels";
            this.lblBad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(0, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(600, 113);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // lblMade
            // 
            this.lblMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMade.Location = new System.Drawing.Point(0, 149);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(600, 98);
            this.lblMade.TabIndex = 4;
            this.lblMade.Text = "Test for finding broken monitor pixels\r\n\r\nmade_by_SerVer\r\nhttps://github.com/SerV" +
    "erXPlanet";
            this.lblMade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BadPixels";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseClick);
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
//        Point GetMainMonitorSize()
//        {
//            var s = Screen.FromControl(this).Bounds;
//            return new Point();
//        }
    }
}
