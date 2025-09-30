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
    public class SINHVIEN_BLL
    {
        SINHVIEN_DAL sv_dal = new SINHVIEN_DAL();
        public DataTable load_sv()
        {
            return sv_dal.load_sv();
        }
        public int insert_sv(SINHVIEN_PUBLIC sv_public)
        {
            return sv_dal.insert_sv(sv_public);
        }
        public int update_sv(SINHVIEN_PUBLIC sv_public)
        {
            return sv_dal.update_sv(sv_public);
        }
        public int delete_sv(SINHVIEN_PUBLIC sv_public)
        {
            return sv_dal.delete_sv(sv_public);
        }
    }
}
