using System;
using System.Windows.Forms;

namespace WinFormsCarTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RandomPositionButton_Click(object sender, EventArgs e)
        {
            var random = new Random(DateTime.Now.Millisecond);
            gForceVisualizerControl1.XGforce = (float) (-2 + random.NextDouble() * 4);
            gForceVisualizerControl1.YGforce = (float) (-2 + random.NextDouble() * 4);
        }
    }
}
