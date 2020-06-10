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
    public partial class Formreport : Form
    {
        public Formreport()
        {
            InitializeComponent();
        }
        public string SoPhieu;
        private void Formreport_Load(object sender, EventArgs e)
        {
            var query = "SELECT CTDATBAO.SoPhieu, CTDATBAO.ThangBD, CTDATBAO.ThangKT, CTDATBAO.SoLuong, KHACHHANG.TenKH, KHACHHANG.DiaChi, KHACHHANG.DienThoai, TAPCHI.DonGiaThang, TAPCHI.TenTC, PHIEUDATBAO.NgayDat, "+
                  "(TAPCHI.DonGiaThang * CTDATBAO.SoLuong) * (CTDATBAO.ThangKT - CTDATBAO.ThangBD + 1) AS ThanhTien"+
                 " FROM CTDATBAO INNER JOIN "+
                 " PHIEUDATBAO ON CTDATBAO.SoPhieu = PHIEUDATBAO.SoPhieu INNER JOIN "+
                 " KHACHHANG ON PHIEUDATBAO.MaKH = KHACHHANG.MaKH INNER JOIN "+
                 " TAPCHI ON CTDATBAO.MaTC = TAPCHI.MaTC INNER JOIN "+
                 " LOAITC ON TAPCHI.MaLTC = LOAITC.MaLTC "+
                 "where CTDATBAO.SoPhieu= '" + SoPhieu + "'";
            SqlDataAdapter da = new SqlDataAdapter(query,model.cnn);
            SqlCommandBuilder cmmd = new SqlCommandBuilder(da);
            try
            {
                DataTable tbl = new DataTable();
                da.Fill(tbl);
                pdb rpt = new pdb();
                rpt.SetDataSource(tbl);
                crydatbao.ReportSource = rpt;
               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());            }

        }
    }

}
