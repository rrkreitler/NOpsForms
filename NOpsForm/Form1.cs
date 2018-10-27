using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOpsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mainMenuStrip.BackColor = Color.Black;
            //mainMenuStrip.ForeColor = Color.AntiqueWhite;
            //newToolStripMenuItem.BackColor=Color.Black;
            //newToolStripMenuItem.ForeColor = Color.AntiqueWhite;
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            mainMenuStrip.ForeColor=Color.AntiqueWhite;
            newToolStripMenuItem.ForeColor = Color.AntiqueWhite;
            exitToolStripMenuItem.ForeColor = Color.AntiqueWhite;

            for (var n = 0; n < 100; n++)
            {
                var p = new TestPanel("TestPanel" + n);
                
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

    public class TestColorTable : ProfessionalColorTable
    {
        public Color ForeColor
        {
            get { return Color.AntiqueWhite; }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.AntiqueWhite;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.AntiqueWhite;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.DimGray;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.DimGray;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.DimGray;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Black;
            }
        }
    }
}
    

