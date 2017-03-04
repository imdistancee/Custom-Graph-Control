using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Graph_Control.Testing
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();

            myGraphControl.lineType = GraphControl.Graph.LineType.CURVE;
            myGraphControl.graphColor = Color.Green;
            myGraphControl.lineSize = 2;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            if (txtX.Text != string.Empty && txtY.Text != string.Empty)
            {
                if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y))
                {
                    myGraphControl.AddPoint(x, y);
                    myGraphControl.Refresh();
                }
            }
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            comboLines.Items.AddRange(new string[]
            {
                "curved line",
                "straight line"
            });
        }

        private void comboLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboLines.SelectedIndex;
            myGraphControl.lineType = (GraphControl.Graph.LineType)index;
            myGraphControl.Refresh();
        }

        private void numericLineSize_ValueChanged(object sender, EventArgs e)
        {
            myGraphControl.lineSize = (int)numericLineSize.Value;
            myGraphControl.Refresh();
        }
    }
}
