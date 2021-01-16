using System;
using System.Linq;
using System.Windows.Forms;
using WinForm_With_EFCore.DAL;

namespace WinForm_With_EFCore
{
    public partial class Main : Form
    {
        EmployeeContext empContext = new EmployeeContext();
        public Main()
        {
            InitializeComponent();
        }

        public void LoadDGV()
        {
            using EmployeeContext db = new EmployeeContext();
            DGVEmployees.DataSource = db.Employees.ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EmployeeRepo emp = new EmployeeRepo(empContext);
            string firstName = TxtFirstName.Text.Trim();
            string lastName = TxtLastName.Text.Trim();
            string address = TxtAddress.Text.Trim();
            string phone = TxtHomePhone.Text.Trim();
            string mobile = TxtMobile.Text.Trim();            
            emp.Create(firstName, lastName, address, phone, mobile);
            LoadDGV();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
