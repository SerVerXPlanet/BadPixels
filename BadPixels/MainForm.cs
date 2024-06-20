/*
 * Created by SharpDevelop.
 * User: SerVer
 * Date: 14.06.2024
 * Time: 9:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace BadPixels
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Color[] colors = new Color[] { Color.Gray, Color.Black, Color. White, Color.Red, Color.Lime, Color.Blue, Color.Yellow, Color.Cyan, Color.Magenta };
        int currentIndex = 1;
        
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        void MainFormMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ChangeColor();
            else
                Application.Exit();
        }
        
        
        void ChangeColor()
        {
            int count = colors.Length;
            Color currentColor = colors[currentIndex % count];
            currentIndex = (currentIndex + 1) % count;
            this.BackColor = currentColor;
        }
        
        
        void BtnStartClick(object sender, EventArgs e)
        {
            Start();
        }
        
        
        void Start()
        {
            group.Enabled = false;
            group.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            var screen = Screen.FromControl(this).Bounds;
            this.Width = screen.Width;
            this.Height = screen.Height;
            this.Location = new Point();
            this.BackColor = Color.Gray;            
        }
        
        
    }
}
