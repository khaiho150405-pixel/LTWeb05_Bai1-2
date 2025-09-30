using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing.Printing;

namespace LTWeb05_Bai01.Models
{
    public class DuLieu
    {
        static string strcon = "Data Source=DESKTOP-D213BRB; database=QL_NhanSu; User ID=sa; Password=123";
        SqlConnection con = new SqlConnection(strcon);

        public List<Employee> dsNV = new List<Employee>();
        public List<Department> dsPB = new List<Department>();

        public DuLieu()
        {
            ThietLap_DSNV();
            ThietLap_DSPB();
        }

        public void ThietLap_DSNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Employee", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                var em = new Employee();
                em.MaNV = int.Parse(dr["Id"].ToString());
                em.Ten = dr["Tennv"].ToString();
                em.GioiTinh = dr["Gender"].ToString();
                em.Tinh = dr["City"].ToString();
                em.MaPg = int.Parse(dr["DeptId"].ToString());
                dsNV.Add(em);
            }
        }

        public void ThietLap_DSPB()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Department", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                var pb = new Department();
                pb.MaPhong = int.Parse(dr["DeptId"].ToString());
                pb.TenPhong = dr["Ten"].ToString();
                dsPB.Add(pb);
            }
        }

        public Department ChiTietPhongBan(int maPhong)
        {
            Department department = new Department();
            string sqlScript = String.Format("SELECT * FROM tbl_Department WHERE DeptID = {0}", maPhong);
            SqlDataAdapter da = new SqlDataAdapter(sqlScript, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            department.MaPhong = int.Parse(dt.Rows[0]["DeptID"].ToString());
            department.TenPhong = dt.Rows[0]["Ten"].ToString();

            return department;
        }

        public List<Employee> DanhSachNhanVienTheoMaPhong(int maPhong)
        {
            List<Employee> employees = new List<Employee>();
            string sqlScript = String.Format("SELECT * FROM tbl_Employee WHERE DeptID = {0}", maPhong);
            SqlDataAdapter da = new SqlDataAdapter(sqlScript, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                var em = new Employee();
                em.MaNV = int.Parse(dr["ID"].ToString());
                em.Ten = dr["Tennv"].ToString();
                em.GioiTinh = dr["Gender"].ToString();
                em.Tinh = dr["City"].ToString(); 
                em.MaPg = int.Parse(dr["DeptId"].ToString());

                employees.Add(em);
            }

            return employees;
        }
    }

}