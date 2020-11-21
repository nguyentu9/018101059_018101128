using _018101059_018101128.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018101059_018101128
{
    public partial class CrystalReportSinhvien : Form
    {
        public CrystalReportSinhvien()
        {
            InitializeComponent();
        }

       
        private void CrystalReportSinhvien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SinhvienDAO.Thongtin_SV1(SinhvienDAO.tenkhoa);
            CrystalReportSV cry = new CrystalReportSV();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}

