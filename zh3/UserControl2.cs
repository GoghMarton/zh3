using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh3
{
    public partial class UserControl2 : UserControl
    {
        Models.StudiesContext studiesContext = new Models.StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = studiesContext.Instructor.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                Models.Instructor instructor = new Models.Instructor();
                //instructor.Name = f2.textBoxName.Text;
                //instructor.Salutation = f2.textBoxSalutation.Text;

                studiesContext.Add(instructor);

                try
                {
                    studiesContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                instructorBindingSource.DataSource = studiesContext.Instructor.ToList();
            }
        }
    }
}
