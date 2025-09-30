using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PUBLIC;
namespace DAL
{
    public class LOP_DAL
    {
        KETNOI kn = new KETNOI();
        public DataTable load_lop()
        {
            string sql = ("load_lop");
            return kn.laydulieu(sql);
        }
        public int insert_lop(LOP_PUBLIC lop_public)
        {
            int parameter = 3;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MALOP";
            name[1] = "@TENLOP";
            name[2] = "@MAKHOA";
            values[0]=lop_public.MALOP;
            values[1]=lop_public.TENLOP;
            values[2]=lop_public.MAKHOA;
            string sql=("insert_lop");
            return kn.thuchien(sql,name,values,parameter);
        }
        public int update_lop(LOP_PUBLIC lop_public)
        {
            int parameter = 4;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MALOP";
            name[1] = "@TENLOP";
            name[2] = "@MAKHOA";
            name[3] = "@MALOPCU";
            values[0] = lop_public.MALOP;
            values[1] = lop_public.TENLOP;
            values[2] = lop_public.MAKHOA;
            values[3] = lop_public.MALOPCU;
            string sql = ("update_lop");
            return kn.thuchien(sql, name, values, parameter);
        }
        public int delete_lop(LOP_PUBLIC lop_public)
        {
            int parameter = 1;
            string[] name = new string[parameter];
            object[] values = new object[parameter];
            name[0] = "@MALOP";
            values[0] = lop_public.MALOP;
            string sql=("delete_lop");
            return kn.thuchien(sql,name,values,parameter);
        }
    }
}
