using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homepage
{
    public class Purchased_package
    {
        public int Memberid { get; set; }
        public string Packagename { get; set; }

        public Purchased_package(int memberid, string packagename)
        {
            Memberid = memberid;
            Packagename = packagename;
        }

        public Member Member_Purchases
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Package_line Package_line_for_packages
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }


    }
}