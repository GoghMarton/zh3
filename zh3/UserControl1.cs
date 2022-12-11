using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3.Models;

namespace zh3
{

    public partial class UserControl1 : UserControl
    {
        StudiesContext studiesContext = new StudiesContext();

        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TanárokSzűrés();
        }

        private void TanárokSzűrés()
        {
            var tanárok = from x in studiesContext.Instructor
                          where x.Name.Contains(textBox1.Text)
                          select x;

            listBox1.DisplayMember = "Name";
            listBox1.DataSource = tanárok.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor kiválasztottTanárok = (Instructor)listBox1.SelectedItem;

            var órák = from x in studiesContext.Lesson
                       where x.InstructorFk == kiválasztottTanárok.InstructorSk
                       select new OraClass
                       {
                           KurzusNév = x.CourseFkNavigation.Name,
                           NapNév = x.DayFkNavigation.Name,
                           Idősáv = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name
                       };

            oraClassBindingSource.DataSource = órák.ToList();
        }
    }
}
