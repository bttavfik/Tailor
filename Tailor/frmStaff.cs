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
using Tailor.Services;

namespace Tailor
{
    public partial class frmStaff : Form
    {
        public string code;
        public bool edit = false;
        public frmStaffView staffView = null;
        private int countRow;
        private int id;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadPosition();

            //ComboBox defualt selection
            cboGender.SelectedIndex = -1;
            cboSkill.SelectedIndex = -1;

            lblFinished.Visible = false;
            lblCode.Visible = false;

            if (edit)
            {
                this.Edit();
            }
        }
        
        private void LoadGender()
        {
            using(var db = new TailorEntities())
            {
                //Load gender from database 
                var gender = db.Genders.ToList();
                cboGender.DataSource = gender;
                cboGender.DisplayMember = "Description";
                cboGender.ValueMember = "Id";
            }
        }

        private void LoadPosition()
        {
            using (var db = new TailorEntities())
            {
                //Load Position from database
                var position = db.Positions.Where(p => p.IsActive);
                cboSkill.DataSource = position.ToList();
                cboSkill.DisplayMember = "Description";
                cboSkill.ValueMember = "Id";
            }
        }

        private void Edit()
        {
            using (var db = new TailorEntities())
            {
                var staff = db.Staffs.SingleOrDefault(s => s.Code == code);
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
                lblCode.Visible = true;
                lblCode.Text += "  " + code;
                btnSave.Text = "កែប្រែ";
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameKh.Text.Trim()))
            {
                txtNameKh.Focus();
                error.SetError(txtNameKh, null);
                return;
            }

            if (cboGender.SelectedIndex < 0)
            {
                cboGender.Focus();
                error.SetError(cboGender, null);
                return;
            }

            if (cboSkill.SelectedIndex < 0)
            {
                cboSkill.Focus();
                error.SetError(cboSkill, null);
                return;
            }

            if (string.IsNullOrEmpty(txtNationalId.Text.Trim()))
            {
                txtNationalId.Focus();
                error.SetError(txtNationalId,null);
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                txtPhone.Focus();
                error.SetError(txtPhone,null);
                return;
            }

            if (string.IsNullOrEmpty(txtBasicSalary.Text.Trim()))
            {
                txtBasicSalary.Focus();
                error.SetError(txtBasicSalary,null);
                return;
            }
            
            if (edit)
            {
                using(var db = new TailorEntities())
                {
                    DialogResult dr = TailorMessage.Show("Are you sure you want to update data?", "Update", TailorMessageIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        var staff = db.Staffs.SingleOrDefault(s => s.Code == code);
                        staff.NameKh = txtNameKh.Text;
                        staff.NameEn = txtNameEn.Text;
                        staff.GenderId = int.Parse(cboGender.SelectedValue.ToString());
                        staff.NationalId = txtNationalId.Text;
                        staff.DateOfBirth = dtpBirthDate.Value;
                        staff.PlaceOfBirth = txtBirthPlace.Text;
                        staff.CurrentAddress = txtCurrentAddress.Text;
                        staff.Phone = txtPhone.Text;
                        staff.PositionId = int.Parse(cboSkill.SelectedValue.ToString());
                        staff.BasicSalary = decimal.Parse(txtBasicSalary.Text);
                        staff.IsActive = true;
                        int action = db.SaveChanges();
                        if (action >= 1)
                        {
                            lblFinished.Visible = true;
                            lblFinished.Visible = true;
                        }
                    }
                }
            }
            else
            {
                id = int.Parse(cboSkill.SelectedValue.ToString());
                using (var db = new TailorEntities())
                {
                    var position = db.Positions.FirstOrDefault(p => p.Id == id);
                    code = position.Abbreviation;

                    var staff = db.Staffs.Count();
                    countRow = staff;
                    countRow++;
                }

                using (var db = new TailorEntities())
                {
                    DialogResult dr = TailorMessage.Show("Are you sure you want to add data?", "Save", TailorMessageIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Staff staff = new Staff()
                        {
                            Code = code + countRow,
                            NameKh = txtNameKh.Text,
                            NameEn = txtNameEn.Text,
                            GenderId = int.Parse(cboGender.SelectedValue.ToString()),
                            NationalId = txtNationalId.Text,
                            DateOfBirth = dtpBirthDate.Value,
                            PlaceOfBirth = txtBirthPlace.Text,
                            CurrentAddress = txtCurrentAddress.Text,
                            Phone = txtPhone.Text,
                            PositionId = int.Parse(cboSkill.SelectedValue.ToString()),
                            BasicSalary = decimal.Parse(txtBasicSalary.Text),
                            IsActive = true
                        };
                        staff =  db.Staffs.Add(staff);
                        int action = db.SaveChanges();
                        if (action >= 1)
                        {
                            lblFinished.Visible = true;
                            lblCode.Text += " " + staff.Code;
                            lblCode.Visible = true;
                            code = staff.Code;
                            edit = true;
                        }
                    }
                }
            }

            if (staffView != null)
            {
                staffView.LoadData();
                staffView.LoadInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
