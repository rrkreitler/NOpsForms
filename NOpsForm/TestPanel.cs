using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOpsForm
{
    public partial class TestPanel : UserControl
    {
        private string title;

        public TestPanel()
        {
            InitializeComponent();
            title = "";
            
        }

        public TestPanel(string title)
        {
            InitializeComponent();
            this.title = title;
            
        }

        private void TestPanel_Load(object sender, EventArgs e)
        {
            TestPanelName.Text = title;
        }

        public void TestPanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
        }

        private void TestPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
        }

        private void TestPanelName_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(new EventArgs());
        }
    }
}
