using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mainPanel_Resize_1(mainPanel, EventArgs.Empty);
            descriptionTextBox.Rtf = @"{\rtf1\ansi This is \b bold\b0  and this is \i italic\i0 .\line
{\field{\*\fldinst{HYPERLINK ""https://www.example.com""}}{\fldrslt{Click here}}}
}";
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Resize_1(object sender, EventArgs e)
        {
            int usedHeight = 0;

            foreach (Control ctrl in mainPanel.Controls)
            {
                if (ctrl != tabControl && ctrl.Visible)
                {
                    usedHeight += ctrl.Height + ctrl.Margin.Top + ctrl.Margin.Bottom;
                }
            }

            // Set the TabControl's height to fill the remaining space
            tabControl.Width = Math.Max(0, mainPanel.ClientSize.Width - tabControl.Margin.Left - tabControl.Margin.Right);
            tabControl.Height = Math.Max(0, mainPanel.ClientSize.Height - usedHeight - tabControl.Margin.Top - tabControl.Margin.Bottom);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
