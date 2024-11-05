using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapSINHVIENKETQUA
{
    public partial class Form1 : Form
    {
        msQLSV ds = new msQLSV();
        msQLSVTableAdapters.SINHVIENTableAdapter adpSinhVien = new msQLSVTableAdapters.SINHVIENTableAdapter();
        msQLSVTableAdapters.KETQUATableAdapter adpKetQua = new msQLSVTableAdapters.KETQUATableAdapter();
        msQLSVTableAdapters.MONHOCTableAdapter adpMonHoc = new msQLSVTableAdapters.MONHOCTableAdapter();
        msQLSVTableAdapters.KHOATableAdapter adpKhoa = new msQLSVTableAdapters.KHOATableAdapter();
        BindingSource bsSV = new BindingSource();
        BindingSource bsKQ = new BindingSource();
        int stt = -1;
        public Form1()
        {
            InitializeComponent();
            bsSV.CurrentChanged += BsSV_CurrentChanged;
        }

        private void BsSV_CurrentChanged(object sender, EventArgs e)
        {
            bdnSinhVien.BindingSource = bsSV;
            lblSTT.Text = bsSV.Position + 1 + "/" + bsSV.Count;
            if (bsSV.Current != null)
            {
                if (bsSV.Current is DataRowView rowView)
                {
                    string maSV = rowView["MaSV"].ToString();
                    txtMaSV.Text = maSV;

                    txtTongDiem.Text = TinhTongDiem(maSV).ToString();
                }
            }
            btnTruoc.Enabled = bsSV.Position > 0;
            btnSau.Enabled = bsSV.Position < bsSV.Count - 1;
        }

        private object TinhTongDiem(string maSV)
        {
            double kq;
            Object tssv = ds.Tables["KETQUA"].Compute("sum(Diem)", "MaSV='" + maSV + "'");
            if (tssv == DBNull.Value)
                kq = 0;
            else
                kq = Convert.ToInt32(tssv);
            return kq;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Doc_Du_Lieu();
            Lien_Ket_Dieu_Khien();
        }

        private void Doc_Du_Lieu()
        {
            // 1. Nạp dữ liệu cho các Datatable
            adpKhoa.Fill(ds.KHOA);
            adpSinhVien.Fill(ds.SINHVIEN);
            adpKetQua.Fill(ds.KETQUA);
            adpMonHoc.Fill(ds.MONHOC);

            // 2. Nạp dữ liệu cho ComboBoxKhoa
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = ds.KHOA;

            // 3. Nạp nguồn cho BindingSource bsSV
            bsSV.DataSource = ds.SINHVIEN;

            // 4. Nạp nguồn cho BindingSource bsKQ
            bsKQ.DataSource = bsSV;
            bsKQ.DataMember = "SINHVIENKETQUA";

            // 5. Gán nguồn cho lưới
            dgvKetQua.DataSource = bsKQ;

            // 6. Không hiển thị cột MaSV trong lưới
            dgvKetQua.Columns["MaSV"].Visible = false;
        }

        private void Lien_Ket_Dieu_Khien()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Name != "txtTongDiem")
                {
                    control.DataBindings.Add("text", bsSV, control.Name.Substring(3), true);
                }
                else if (control is CheckBox)
                {
                    control.DataBindings.Add("checked", bsSV, control.Name.Substring(3), true);
                }
                else if (control is DateTimePicker)
                {
                    control.DataBindings.Add("value", bsSV, control.Name.Substring(3), true);
                }
                else if (control is ComboBox)
                {
                    control.DataBindings.Add("SelectedValue", bsSV, control.Name.Substring(3), true);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            stt = bsSV.Position;
            bsSV.AddNew();
            txtMaSV.Focus();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bsSV.MovePrevious();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            bsSV.MoveNext();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            msQLSV.SINHVIENRow msSV = (bsSV.Current as DataRowView).Row as msQLSV.SINHVIENRow;
            if (msSV.GetKETQUARows().Length > 0)
            {
                MessageBox.Show("Bạn không thể huỷ vì sinh viên đã kết quả thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn huỷ sinh viên:" + "\r\n" +
                " + MaSV: " + txtMaSV.Text + "\r\n" +
                " + Họ và tên: " + txtHoSV.Text + ' ' + txtTenSV.Text + "\r\n" +
                "này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                bsSV.RemoveCurrent();
                int n = adpSinhVien.Update(ds.SINHVIEN);
                if (n > 0)
                {
                    MessageBox.Show("Huỷ sinh viên thành công!");
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.ReadOnly == false)
            {
                msQLSV.SINHVIENRow mSV = ds.SINHVIEN.FindByMaSV(txtMaSV.Text);
                if (mSV != null)
                {
                    MessageBox.Show("Mã SV bị trùng. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaSV.Clear();
                    txtMaSV.Focus();
                    return;
                }
            }
            txtMaSV.ReadOnly = true;
            bsSV.EndEdit();
            int n = adpSinhVien.Update(ds.SINHVIEN);
            if (n > 0)
            {
                MessageBox.Show("Cập nhật THÊM/SỬA thành công");
            }
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            bsSV.CancelEdit();
            txtMaSV.ReadOnly = true;
            bsSV.Position = stt;
        }

        private void dgvKetQua_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvKetQua.CurrentRow.IsNewRow == true) return;

            if (dgvKetQua.IsCurrentRowDirty == true)
            {
                if ((dgvKetQua.CurrentRow.DataBoundItem as DataRowView).IsNew == true)
                {
                    if (ds.KETQUA.FindByMaSVMaMH(dgvKetQua.CurrentRow.Cells["MaSV"].Value.ToString(), dgvKetQua.CurrentRow.Cells["colMaMon"].Value.ToString()) != null)
                    {
                        MessageBox.Show("Môn học này sinh viên đã thi. Vui lòng chọn môn học khác", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        dgvKetQua.CurrentCell = dgvKetQua.CurrentRow.Cells["colMaMon"];

                        dgvKetQua.CurrentRow.Cells["colMaMon"].Value = null;

                        dgvKetQua.CurrentCell = dgvKetQua.CurrentRow.Cells["colMaMon"];
                        return;
                    }
                }
                (dgvKetQua.CurrentRow.DataBoundItem as DataRowView).EndEdit();
                int n = adpKetQua.Update(ds.KETQUA);
                if (n > 0)
                {
                    MessageBox.Show("Cập nhật điểm thi cho sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvKetQua_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int n = adpKetQua.Update(ds.KETQUA);
            if (n > 0)
            {
                MessageBox.Show("Huỷ sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
