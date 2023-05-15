using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager
{
    public partial class FrmEvaluation : Form
    {
        private Student selectedStudent = null;
        public FrmEvaluation(Student selectedStudent)
        {
            this.selectedStudent = selectedStudent;
            InitializeComponent();
        }

        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            SetFormTitle();
            PopulateActivities();

        }

        private void SetFormTitle()
        {
            this.Text = $"{selectedStudent.FirstName} {selectedStudent.LastName}";
        }


        private void PopulateActivities()
        {
            cboActivities.DataSource = ActivityRepository.GetActivities();
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity selectedActivity = cboActivities.SelectedItem as Activity;
            if (selectedActivity != null)
            {
                txtActivityDescription.Text = selectedActivity.Description;
                txtMinForGrade.Text = selectedActivity.MinPointsForGrade + " / "
                    + selectedActivity.MaxPoints;
                txtMinForSignature.Text = selectedActivity.MinPointsForSignature + " / "
                    + selectedActivity.MaxPoints;

                numPoints.Minimum = 0;
                numPoints.Maximum = selectedActivity.MaxPoints;

                var evaluation = EvaluationRepository.GetEvaluation(selectedStudent, selectedActivity);
                if(evaluation != null)
                {
                    txtTeacher.Text = evaluation.Evaluator.ToString();
                    txtEvaluationDate.Text = evaluation.EvaluationDate.ToString();
                    numPoints.Value = evaluation.Points;
                }
                else
                {
                    txtTeacher.Text = FrmLogin.LoggedTeacher.ToString();
                    txtEvaluationDate.Text = "-";
                    numPoints.Value = 0;
                }
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var activity = cboActivities.SelectedItem as Activity;
            var teacher = FrmLogin.LoggedTeacher;
            int points = (int)numPoints.Value;

            teacher.PerformEvaluation(selectedStudent, activity, points);
            Close();
        }
    }
}
