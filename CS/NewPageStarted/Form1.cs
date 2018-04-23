using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace NewPageStarted {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}