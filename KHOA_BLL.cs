using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using PUBLIC;
namespace BLL
{
    public class KHOA_BLL
    {
        KHOA_DAL khoa_dal = new KHOA_DAL();
        public DataTable load_khoa()
        {
            return khoa_dal.load_khoa();
        }
        public int insert_khoa(KHOA_PUBLIC khoa_public)
        {
            return khoa_dal.insert_khoa(khoa_public);
        }
        public int update_khoa(KHOA_PUBLIC khoa_public)
        {
            return khoa_dal.update_khoa(khoa_public);
        }
        public int delete_khoa(KHOA_PUBLIC khoa_public)
        {
            return khoa_dal.delete_khoa(khoa_public);
        }
    }
}
