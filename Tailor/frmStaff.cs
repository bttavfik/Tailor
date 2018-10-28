using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Tailor.Model;

namespace Tailor
{
    public partial class frmStaff : Form
    {
        TailorEntities db = new TailorEntities();
        public int id = -1;
        public bool edit = false;
        public frmStaffView staffView = null;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //Load gender from database 
            var gender = db.Genders.ToList();
            cboGender.DataSource = gender;
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "Id";

            //Load Position from database
            var position = db.Positions
                .Where(p => p.IsActive == true)
                .Select(p => new { ID = p.Id, Description = p.Description });

            cboSkill.DataSource = position.ToList();
            cboSkill.DisplayMember = "Description";
            cboSkill.ValueMember = "Id";

            //ComboBox defualt selection
            cboGender.SelectedIndex = -1;
            cboSkill.SelectedIndex = -1;

            if (edit)
            {
                var staff = db.Staffs.Find(id);
                txtNameKh.Text = staff.NameKh;
                cboGender.SelectedValue = staff.GenderId;
                dtpBirthDate.Value = staff.DateOfBirth.Value;
                cboSkill.SelectedValue = staff.PositionId;
                txtBirthPlace.Text = staff.PlaceOfBirth;
                txtNameEn.Text = staff.NameEn;
                txtNationalId.Text = staff.NationalId;
                txtPhone.Text = staff.Phone;
                txtBasicSalary.Text = staff.BasicSalary.ToString();
                txtCurrentAddress.Text = staff.CurrentAddress;
                btnSave.Text = "កែប្រែ";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameKh.Text.Trim()))
            {
                txtNameKh.Focus();
                error.SetError(txtNameKh, "បញ្ជូលឈ្មោះ");
                return;
            }

            if (cboGender.SelectedIndex < 0)
            {
                cboGender.Focus();
                error.SetError(cboGender, "ជ្រើសរើសភេទ");
                return;
            }

            if (dtpBirthDate.Value == null)
            {
                dtpBirthDate.Focus();
                SendKeys.Send("{%DOWN}");
                error.SetError(dtpBirthDate, "ជ្រើសរើសថ្ងៃខែឆ្នាំកំណើត");
                return;
            }

            if (cboSkill.SelectedIndex < 0)
            {
                cboSkill.Focus();
                error.SetError(cboSkill, "ជ្រើសរើសជំនាញ");
                return;
            }

            if (string.IsNullOrEmpty(txtBirthPlace.Text.Trim()))
            {
                txtBirthPlace.Focus();
                error.SetError(txtBirthPlace, "បញ្ជូលទីកន្លែកកំណើត");
                return;
            }

            if (string.IsNullOrEmpty(txtNameEn.Text.Trim()))
            {
                txtNameEn.Focus();
                error.SetError(txtNameEn, "បញ្ជូលឈ្មោះជាភាសារអង់គ្លេស");
                return;
            }

            if (string.IsNullOrEmpty(txtNationalId.Text.Trim()))
            {
                txtNationalId.Focus();
                error.SetError(txtNationalId, "បញ្ជូលលេខអត្តសញ្ញាណប័ណ្ណ");
                return;
            }

            if (string.IsNullOrEmpty(txtBasicSalary.Text.Trim()))
            {
                txtBasicSalary.Focus();
                error.SetError(txtBasicSalary, "បញ្ជូលប្រាក់ខែគោល");
                return;
            }

            if (string.IsNullOrEmpty(txtCurrentAddress.Text.Trim()))
            {
                txtCurrentAddress.Focus();
                error.SetError(txtCurrentAddress, "បញ្ជូលអាស័យដ្ឋាន្នបច្ចុប្បន្ន");
                return;
            }

            //Convert currency to decimal
            var salary = Decimal.Parse(txtBasicSalary.Text, NumberStyles.Currency);

            if (edit)
            {
                //frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
                //confirm.label1.Text = "តើអ្នកចង់កែប្រែទិន្នន័យមែនទេ?";
                //confirm.btnOkClick = true;
                //confirm.ShowDialog();
                //if (confirm.btnOkClick)
                //{
                //    try
                //    {
                //        //Update staff 
                //        var staff = db.Staffs.Find(id);
                //        staff.NameKh = txtNameKh.Text;
                //        staff.NameEn = txtNameEn.Text;
                //        staff.GenderId = Convert.ToInt32(cboGender.SelectedValue.ToString());
                //        staff.NationalId = txtNationalId.Text;
                //        staff.DateOfBirth = dtpBirthDate.Value;
                //        staff.PlaceOfBirth = txtBirthPlace.Text;
                //        staff.CurrentAddress = txtCurrentAddress.Text;
                //        staff.Phone = txtPhone.Text;
                //        staff.PositionId = Convert.ToInt32(cboSkill.SelectedValue.ToString());
                //        staff.BasicSalary = salary;
                //        staff.IsActive = true;
                //        int action = db.SaveChanges();
                //        if (action >= 1)
                //        {
                //            frmMessageBoxSuccessfull message = new frmMessageBoxSuccessfull();
                //            message.ShowDialog();
                //            this.Close();
                //        }
                //    }
                //    catch (Exception)
                //    {
                //        frmMessageBoxFail message = new frmMessageBoxFail();
                //        message.ShowDialog();
                //    }
                //}
            }
            else
            {
                //frmMessageBoxQuestion confirm = new frmMessageBoxQuestion();
                //confirm.label1.Text = "តើអ្នកចង់រក្សាទុក្ខទិន្នន័យមែនទេ?";
                //confirm.btnOkClick = true;
                //confirm.ShowDialog();

                //if (confirm.btnOkClick)
                //{
                //    try
                //    {
                //        //Insert new staff
                //        Staff staff = new Staff()
                //        {
                //            NameKh = txtNameKh.Text,
                //            NameEn = txtNameEn.Text,
                //            GenderId = Convert.ToInt32(cboGender.SelectedValue.ToString()),
                //            NationalId = txtNationalId.Text,
                //            DateOfBirth = dtpBirthDate.Value,
                //            PlaceOfBirth = txtBirthPlace.Text,
                //            CurrentAddress = txtCurrentAddress.Text,
                //            Phone = txtPhone.Text,
                //            PositionId = Convert.ToInt32(cboSkill.SelectedValue.ToString()),
                //            BasicSalary = salary,
                //            IsActive = true
                //        };
                //        db.Staffs.Add(staff);
                //        int action = db.SaveChanges();
                //        if (action >= 1)
                //        {
                //            ClearData();
                //            frmMessageBoxSuccessfull message = new frmMessageBoxSuccessfull();
                //            message.ShowDialog();
                //        }

                //    }
                //    catch (Exception)
                //    {
                //        frmMessageBoxFail message = new frmMessageBoxFail();
                //        message.ShowDialog();
                //    }
                //}
            }

            if (staffView != null)
            {
                staffView.LoadData();
                staffView.LoadInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtNameEn.Text = "";
            txtNameKh.Text = "";
            txtBirthPlace.Text = "";
            txtCurrentAddress.Text = "";
            txtNationalId.Text = "";
            txtPhone.Text = "";
            txtBasicSalary.Text = "";
            dtpBirthDate.Value = DateTime.Now;
            cboGender.SelectedIndex = -1;
            cboSkill.SelectedIndex = -1;
            txtNameKh.Focus();
        }

        private void txtBasicSalary_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBasicSalary.Text.Trim()))
                txtBasicSalary.Text = string.Format("{0:C}", decimal.Parse(txtBasicSalary.Text));
        }

        private void txtBasicSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBasicSalary.Text.Trim()))
            {
                var s = decimal.Parse(txtBasicSalary.Text, NumberStyles.Currency);
                txtBasicSalary.Text = s.ToString();
            }
        }

        private void txtNameEn_Leave(object sender, EventArgs e)
        {
            TextInfo textFormat = new CultureInfo("en-US", false).TextInfo;
            txtNameEn.Text = textFormat.ToTitleCase(txtNameEn.Text);
        }

        private void txtNationalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtNameEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' || !Decimal.TryParse(txtBasicSalary.Text + e.KeyChar, out x))
                e.Handled = true;
        }
    }
}
