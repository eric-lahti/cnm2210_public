namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string msg = "ID: std" + studentId + "\n" +
                         "First Name: " + firstName + "\n" +
                         "Last Name: " + lastName;

            MessageBox.Show(msg, "Student Information");
        }
    }
}
