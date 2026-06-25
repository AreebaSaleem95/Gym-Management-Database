using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homepage
{
    public class Fee
    {
        public int Memberid { get; set; }
        public string Date_paid { get; set; }
        public string Amount_paid { get; set; }
        public string Served_by { get; set; }
        public string Amount_due { get; set; }
        public string Date_paid_first { get; set; }
        public string Date_paid_last { get; set; }

        public Member Member_pay
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        public Fee(string date_paid_first, string date_paid_last)
        {
            Date_paid_first = date_paid_first;
            Date_paid_last = date_paid_last;
        }
        public Fee(int memberid)
        {
            Memberid = memberid;
        }
        public Fee(int memberid, string date_paid, string amount_paid, string served_by, string amount_due)
        {
            Memberid = memberid;
            Date_paid = date_paid;
            Amount_paid = amount_paid;
            Served_by = served_by;
            Amount_due = amount_due;
        }

    }
}