using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
 public   class ImageProductDAO
    {
        MOCK db = null;
        public ImageProductDAO()
        {
            db = new MOCK();

        }
        public IMAGEPRODUCT Imagepro(string id)
        {

            return db.IMAGEPRODUCTs.Find(id);
        }
    }
}
