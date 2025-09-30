using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class KHOA_DAL
    {
        KETNOI kn = new KETNOI();
        public DataTable load_khoa()
        {
            string sql=("load_khoa");
            return kn.laydulieu(sql);
        }
        public int insert_khoa(KHOA_PUBLIC khoa_public)
        {
            int parameter = 2;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAKHOA";
            name[1] = "@TENKHOA";
            values[0] = khoa_public.MAKHOAMOI;
            values[1] = khoa_public.TENKHOA;
            string sql = ("insert_khoa");
            return kn.thuchien(sql, name, values, parameter);
        }
        public int update_khoa(KHOA_PUBLIC khoa_public)
        {
            int parameter = 3;            
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAKHOAMOI";
            name[1] = "@MAKHOACU";
            name[2] = "@TENKHOA";
            values[0] = khoa_public.MAKHOAMOI;
            values[1] = khoa_public.MAKHOACU;
            values[2] = khoa_public.TENKHOA;
            string sql = ("update_khoa");
            return kn.thuchien(sql, name, values, parameter);
        }
        public int delete_khoa(KHOA_PUBLIC khoa_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MAKHOA";
            values[0] = khoa_public.MAKHOAMOI;
            string sql=("delete_khoa");
            return kn.thuchien(sql,name,values,parameter);
        }
    }
}
