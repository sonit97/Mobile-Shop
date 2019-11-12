using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
  public  class PRODUCTTYPEDAO
    {
        MOCK db = null;
        public PRODUCTTYPEDAO()
        {
            db = new MOCK();

        }
        public List<PRODUCTSTYPE> listtype()
        {
            return db.PRODUCTSTYPEs.OrderBy(x => x.ProductTypeName).ToList();

        }
    }
}
