using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using PUBLIC;
using System.Data;
namespace BLL
{
    public class LOP_BLL
    {
        LOP_DAL lop_dal = new LOP_DAL();
        public DataTable load_lop()
        {
            return lop_dal.load_lop();
        }
        public int insert_lop(LOP_PUBLIC lop_public)
        {
            return lop_dal.insert_lop(lop_public);
        }
        public int update_lop(LOP_PUBLIC lop_public)
        {
            return lop_dal.update_lop(lop_public);
        }
        public int delete_lop(LOP_PUBLIC lop_public)
        {
            return lop_dal.delete_lop(lop_public);
        }
    }
}
