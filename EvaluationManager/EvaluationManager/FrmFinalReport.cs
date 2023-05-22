using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {
    public partial class FrmFinalReport : Form {
        public FrmFinalReport() {
            InitializeComponent();
        }

        private List<StudentReportView> GenerateStudentReport() {
            var allStudents = StudentRepository.GetStudents();
            List<StudentReportView> examReports = new List<StudentReportView>();

            foreach (var student in allStudents) {
                if (student.HasSignature()) {
                    var examReport = new StudentReportView(student);
                    examReports.Add(examReport);
                }
            }
            return examReports;
        }

        private void FrmFinalReport_Load(object sender, EventArgs e) {


            var results = GenerateStudentReport();
            dgvResults.DataSource = results;


        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
