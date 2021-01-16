using System;
using System.Linq;
using System.Windows.Forms;
using WinForm_With_EFCore.DAL;

namespace WinForm_With_EFCore
{
    public partial class Main : Form
    {
        private static EmployeeContext empContext = new EmployeeContext();
        readonly Employee emp = new Employee();
        readonly EmployeeRepo empRepo = new EmployeeRepo(empContext);
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
            empRepo.Create(GetEmployee());
            LoadDGV();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            empRepo.Update(GetEmployee());
            LoadDGV();
        }

        private Employee GetEmployee()
        {
            emp.FirstName = TxtFirstName.Text.Trim();
            emp.LastName = TxtLastName.Text.Trim();
            emp.Address = TxtAddress.Text.Trim();
            emp.HomePhone = TxtHomePhone.Text.Trim();
            emp.Mobile = TxtMobile.Text.Trim();
            return emp;
        }

        private void DGVEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            emp.Id = Convert.ToInt32(DGVEmployees.SelectedRows[0].Cells[0].Value.ToString());
            label6.Text = emp.Id.ToString();
            //emp.FirstName = DGVEmployees.SelectedRows[0].Cells[1].Value.ToString();
            //emp.LastName = DGVEmployees.SelectedRows[0].Cells[2].Value.ToString();
            //emp.Address = DGVEmployees.SelectedRows[0].Cells[3].Value.ToString();
            //emp.HomePhone = DGVEmployees.SelectedRows[0].Cells[4].Value.ToString();
            //emp.Mobile = DGVEmployees.SelectedRows[0].Cells[5].Value.ToString();
            TxtFirstName.Text = emp.FirstName = DGVEmployees.SelectedRows[0].Cells[1].Value.ToString(); 
            TxtLastName.Text = emp.LastName = DGVEmployees.SelectedRows[0].Cells[2].Value.ToString();
            TxtAddress.Text = emp.Address = DGVEmployees.SelectedRows[0].Cells[3].Value.ToString();
            TxtHomePhone.Text = emp.HomePhone = DGVEmployees.SelectedRows[0].Cells[4].Value.ToString(); 
            TxtMobile.Text = emp.Mobile = DGVEmployees.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var emp = GetEmployee();
            empRepo.Delete(emp);
            LoadDGV();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
