using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tstTreeView
{
    public partial class FrmDialog : Form
    {
        [DefaultValue("")]
        public string InputValue { get; set; } = "";
        [DefaultValue("")]
        public string InputName { get; set; } = "";
        public FrmDialog()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            InputName = TextBoxInputName.Text;
            InputValue = TextBoxInputValue.Text;
            Close();
        }
    }
}
