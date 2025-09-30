using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBLIC;
using System.Data;
namespace DAL
{
    public class SINHVIEN_DAL
    {
        KETNOI kn = new KETNOI();
        public DataTable load_sv()
        {
            string sql=("load_sv");
            return kn.laydulieu(sql);
        }
        public int insert_sv(SINHVIEN_PUBLIC sv_public)
        {
            int parameter = 6;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0]="@MASV";
            name[1]="@TENSV";
            name[2]="@GIOITINH";
            name[3]="@NGAYSINH";
            name[4]="@DIACHI";
            name[5]="@MALOP";
            values[0]=sv_public.MASV;
            values[1]=sv_public.TENSV;
            values[2]=sv_public.GIOITINH;
            values[3]=sv_public.NGAYSINH;
            values[4]=sv_public.DIACHI;
            values[5]=sv_public.MALOP;
            string sql=("insert_sv");
            return kn.thuchien(sql, name, values, parameter);
        }
        public int update_sv(SINHVIEN_PUBLIC sv_public)
        {
            int parameter = 7;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASV";
            name[1] = "@TENSV";
            name[2] = "@GIOITINH";
            name[3] = "@NGAYSINH";
            name[4] = "@DIACHI";
            name[5] = "@MALOP";
            name[6] = "@MASVCU";
            values[0] = sv_public.MASV;
            values[1] = sv_public.TENSV;
            values[2] = sv_public.GIOITINH;
            values[3] = sv_public.NGAYSINH;
            values[4] = sv_public.DIACHI;
            values[5] = sv_public.MALOP;
            values[6] = sv_public.MASVCU;
            string sql = ("update_sv");
            return kn.thuchien(sql, name, values, parameter);
        }
        public int delete_sv(SINHVIEN_PUBLIC sv_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MASV";
            values[0]=sv_public.MASV;
            string sql=("delete_sv");
            return kn.thuchien(sql,name,values,parameter);
        }
    }
}
