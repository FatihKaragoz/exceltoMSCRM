using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToMSCRMImport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            OrganizationDefine orgDefFrm = new OrganizationDefine();
            orgDefFrm.MdiParent = this;
            orgDefFrm.Show();
            //this.Hide();
            //this.Visible = false;
            //MainForm abcform = new MainForm();
            //abcform.Show();
        }
    }
}
