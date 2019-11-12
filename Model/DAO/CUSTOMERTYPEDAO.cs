using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CUSTOMERTYPEDAO
    {
        MOCK db = null;
        public CUSTOMERTYPEDAO()
        {
            db = new MOCK();

        }
        public List<CUSTOMERTYPE> listall()
        {

            return db.CUSTOMERTYPEs.ToList();
        }
       
    }
}
