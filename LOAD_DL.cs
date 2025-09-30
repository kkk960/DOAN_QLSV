using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using PUBLIC;
namespace BLL
{
    public class LOAD_DL 
    {
        KETNOI kn = new KETNOI();
        public DataTable laydulieu_treeview(string sql)
        {
            return kn.laydulieu_treeview(sql);
        }
    }
}
