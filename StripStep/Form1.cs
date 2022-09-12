using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StripStep
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem currentStep;
        private int itemStep = 2;
        private int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            
            if (step == 1) currentStep = toolStripMenuItem1;

            ToolStripMenuItem new_item = new ToolStripMenuItem();

            new_item.Name = ($"toolStripMenuItem{itemStep++}");
            new_item.Text = (step++).ToString();
            new_item.Click += toolStripMenuItem1_MouseHover;
            currentStep.DropDownItems.Add(new_item);
            currentStep = new_item;
        }
    }
}
