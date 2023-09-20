using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManagementApp
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentsDataSet.Student);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentBindingSource.AddNew();
        }
    }
}
