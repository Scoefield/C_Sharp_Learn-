using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kaldidict
{
    public static class data
    {
        private static List<cmudict> cmudictlist {
            get {
                string sql = string.Format("select * from cmudict");
                return MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<cmudict>();
            }
        }


        //public static  cmudictlist = data.cmudictlist.ToLookup(a => a.dictword.ToUpper(), a => a);

        public static ILookup<string, cmudict> Cmudictlist {
            get {
                return cmudictlist.ToLookup(a => a.dictword.ToUpper(), a => a);
            }
        }


        private static List<kaldidict> kaldidictlist
        {
            get
            {
                string sql = string.Format("select * from kaldidict");
                return MySqlHelper.GetDataSetnew(sql).Tables[0].ToModels<kaldidict>();
            }
        }


        //public static  cmudictlist = data.cmudictlist.ToLookup(a => a.dictword.ToUpper(), a => a);

        public static ILookup<string, kaldidict> Kaldidictlist
        {
            get
            {
                return kaldidictlist.ToLookup(a => a.dictword.ToUpper(), a => a);
            }
        }

    }
}
