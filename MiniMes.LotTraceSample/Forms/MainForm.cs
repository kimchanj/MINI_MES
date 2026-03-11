using System;
using DevExpress.XtraEditors;

namespace MiniMes.LotTraceSample.Forms
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenLotTrace_Click(object sender, EventArgs e)
        {
            using (LotTraceForm lotTraceForm = new LotTraceForm())
            {
                lotTraceForm.ShowDialog(this);
            }
        }
    }
}
