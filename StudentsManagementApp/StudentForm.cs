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

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            studentBindingSource.AddNew();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsDataSet_.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentsDataSet_.Student);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            studentTableAdapter.Update(studentsDataSet_.Student);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentBindingSource.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            studentBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            studentBindingSource.MoveNext();
        }
    }
}
