using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true) this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxSalutation_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxSalutation, "");
        }

        private void textBoxSalutation_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex("[A-Z{1}]");

            if (!reg.IsMatch(textBoxSalutation.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSalutation, "Státusz kell");
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "Nem lehet üres");
            }

        }
    }
}
