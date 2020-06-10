using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baitaptuan3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tbkhachhang, tbphieudatbao, tbctdatbao, tbtapchi;
        SqlDataAdapter dakhachhang, daphieudatbao, dactdatbao, datapchi;
        BindingManagerBase CTDB, PDB;
        bool capnhat;
        private void cbsodienthoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbsodienthoai.SelectedIndex;
            if (index >= 0)
            {
                tbxtenkhachhang.Text = tbkhachhang.Rows[index]["TenKH"].ToString();
                tbxdiachi.Text = tbkhachhang.Rows[index]["DiaChi"].ToString();

            }
            else
            {
                tbxtenkhachhang.Text = "";
                tbxdiachi.Text = "";


            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            tbkhachhang = new DataTable();
            dakhachhang = new SqlDataAdapter("Select * from KHACHHANG", model.cnnsttring);
            tbphieudatbao = new DataTable();
            daphieudatbao = new SqlDataAdapter("Select * from PHIEUDATBAO", model.cnnsttring);
            tbctdatbao = new DataTable();
            dactdatbao = new SqlDataAdapter("Select  * from CTDATBAO", model.cnnsttring);
            tbtapchi = new DataTable();
            datapchi = new SqlDataAdapter("Select * from TAPCHI", model.cnnsttring);
            try
            {
                SqlCommandBuilder cmdPDB = new SqlCommandBuilder(daphieudatbao);
                SqlCommandBuilder cmdCTDB = new SqlCommandBuilder(dactdatbao);
                dakhachhang.Fill(tbkhachhang);
                daphieudatbao.Fill(tbphieudatbao);
                dactdatbao.Fill(tbctdatbao);
                datapchi.Fill(tbtapchi);

            }
            catch (SqlException ex)
            {


                MessageBox.Show(ex.ToString());


            }
            loadcbSDT();
            loadtapchi();
            addtbctdatbao();
            loadctdb();
            loadphieudatbao();
            bdpdb_PositionChanged(sender, e);
            capnhat = false;
            ennablebutton();
        }

        private void dgvctdb_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvctdb.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PDB.Position = 0;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(PDB.Position>0)
            {
                PDB.Position -= 1;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if ( PDB.Position< PDB.Count-1)
            {
                PDB.Position += 1;
            }
        }
    

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PDB.Position = PDB.Count - 1;
        }

        private void btexit1_Click(object sender, EventArgs e)
        {
            int index=CTDB.Position;
            if (index >= 0)
            {
                CTDB.RemoveAt(index);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (cbtapchi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tạp chí !!!");
                return;
            }
            int count = tbctdatbao.Select("SoPhieu = '" + tbxsophieu.Text + "' and MaTC= '" + cbtapchi.SelectedValue + "'").Count();
            if (count > 0)
            {
                MessageBox.Show("Tạp chí này đã tồn tại . chọn tạp chí khác");

                return;
            }
            DataRow r = tbctdatbao.NewRow();
            r["MaTC"] = cbtapchi.SelectedValue;
            r["SoPhieu"] = tbxsophieu.Text;
            r["SoLuong"] = numericUpDown1.Value;
            r["ThangBD"] = numericUpDown2.Value;
            r["ThangKT"] = numericUpDown3.Value;
            tbctdatbao.Rows.Add(r);
            bdpdb_PositionChanged(sender, e);


        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            CTDB.EndCurrentEdit();
            tbctdatbao.RejectChanges();
            PDB.EndCurrentEdit();
            tbphieudatbao.RejectChanges();
            bdpdb_PositionChanged(sender, e);
            capnhat = false;
            ennablebutton();

        }

        private void btnew_Click(object sender, EventArgs e)
        {
            PDB.AddNew();
            dtpngaydat.Value = DateTime.Now;
            try
            {
                SqlCommand cmm = new SqlCommand("Select  dbo.fn_CreateMaPDB()", model.cnn);
                model.cnn.Open();
                tbxsophieu.Text = cmm.ExecuteScalar().ToString();
                capnhat = true;
                ennablebutton();
               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            model.cnn.Close(); ;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if(cbsodienthoai.SelectedIndex==-1)
            {
                MessageBox.Show("Chưa chọn Khách hàng ");
            }
            try
            {
                PDB.EndCurrentEdit();
                daphieudatbao.Update(tbphieudatbao);
                tbphieudatbao.AcceptChanges();
                CTDB.EndCurrentEdit();
                dactdatbao.Update(tbctdatbao);
                tbctdatbao.AcceptChanges();
                MessageBox.Show("Bạn cập nhật thành công!!!");
                capnhat = false;
                ennablebutton();

            }
            catch(Exception ex )
            {
                tbphieudatbao.RejectChanges();
                tbctdatbao.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            capnhat = true;
            ennablebutton();

        }

        private void btdeleted_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = tbctdatbao.Select("SoPhieu='" + tbxsophieu.Text + "'");
                foreach (DataRow r in rows)
                {
                    r.Delete();
                    dactdatbao.Update(tbctdatbao);
                    tbctdatbao.AcceptChanges();
                }
                    PDB.RemoveAt(PDB.Position);
                    daphieudatbao.Update(tbphieudatbao);
                    tbphieudatbao.AcceptChanges();
                    MessageBox.Show("Xóa thành công");
                
            }
            catch (Exception ex)
            {
             
                tbctdatbao.RejectChanges();
                tbphieudatbao.RejectChanges();
                MessageBox.Show(ex.ToString());

            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Formreport f = new Formreport();
            f.SoPhieu = tbxsophieu.Text;
            f.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;

       
            
            
        }

        private void loadcbSDT()
        {
            cbsodienthoai.DataSource = tbkhachhang;
            cbsodienthoai.DisplayMember = "DienThoai";
            cbsodienthoai.ValueMember = "MaKH";
            cbsodienthoai.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbsodienthoai.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void loadtapchi()
        {
            cbtapchi.DataSource = tbtapchi;
            cbtapchi.DisplayMember = "TenTC";
            cbtapchi.ValueMember = "MaTC";
            cbtapchi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbtapchi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbtapchi.SelectedIndex = -1;


        }
        private void addtbctdatbao()
        {
            DataSet dts = new DataSet();
            dts.Tables.AddRange(new DataTable[] { tbtapchi, tbctdatbao });
            DataRelation qhtc_ctdb = new DataRelation("FRK_TAPCHI_CTDATBAO", tbtapchi.Columns["MaTC"], tbctdatbao.Columns["MaTC"]);
            dts.Relations.Add(qhtc_ctdb);
            DataColumn cot_Tentc = new DataColumn("TenTC", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).TenTC");
            DataColumn cot_dongiathang = new DataColumn("DonGiaThang", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang");
            DataColumn cot_thanhtien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).DonGiaThang*SoLuong*(ThangKT-ThangBD+1)");
            tbctdatbao.Columns.Add(cot_Tentc);
            tbctdatbao.Columns.Add(cot_dongiathang);
            tbctdatbao.Columns.Add(cot_thanhtien);


        }
        private void loadctdb()

        {
            CTDB = this.BindingContext[tbctdatbao];
            dgvctdb.AutoGenerateColumns = false;
            dgvctdb.DataSource = tbctdatbao;
           

        }
        private void bdpdb_PositionChanged(object sender, EventArgs e)
        {
            tbctdatbao.DefaultView.RowFilter = "SoPhieu ='" + tbxsophieu.Text + "'";
            int s = 0;
            foreach (DataRowView r in tbctdatbao.DefaultView)
                s += int.Parse(r["ThanhTien"].ToString());
            tbxtong.Text = s.ToString();

        }
        private void loadphieudatbao()
        {
            tbxsophieu.DataBindings.Add("text", tbphieudatbao, "SoPhieu", true);
            cbsodienthoai.DataBindings.Add("Selectedvalue", tbphieudatbao, "MaKH", true);
            dtpngaydat.DataBindings.Add("value", tbphieudatbao, "NgayDat", true);
            PDB = this.BindingContext[tbphieudatbao];
            PDB.PositionChanged += new EventHandler(bdpdb_PositionChanged);



        }
        private void ennablebutton()
        {
            btnew.Enabled = !capnhat;
            btupdate.Enabled = !capnhat;
            btdeleted.Enabled = !capnhat;
            btCancel.Enabled = capnhat;
            btexit.Enabled = !capnhat;
            btadd.Enabled = capnhat;
            bde.Enabled = capnhat;
            dgvctdb.Enabled = capnhat;

        }



    }
}
