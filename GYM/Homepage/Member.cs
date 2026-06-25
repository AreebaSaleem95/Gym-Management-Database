using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homepage
{
    public class Member
    {
        public int Memberid { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Father_name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Weight { get; set; }
        public int Height_Ft { get; set; }
        public int Height_IN { get; set; }
        public string Purpose { get; set; }
        public double Admission_fee { get; set; }
        public string Dateof_joining { get; set; }
        public string Gender { get; set; }

        public Member(int memberid, string category, string name, string father_name, string contact, string address, string weight, int height_Ft, int height_IN, string purpose, double admission_fee, string dateof_joining, string gender)
        {
            Memberid = memberid;
            Category = category;
            Name = name;
            Father_name = father_name;
            Contact = contact;
            Address = address;
            Weight = weight;
            Height_Ft = height_Ft;
            Height_IN = height_IN;
            Purpose = purpose;
            Admission_fee = admission_fee;
            Dateof_joining = dateof_joining;
            Gender = gender;
        }
        public Member(int memberid)
        {
            Memberid = memberid;
        }
        public Member(string name)
        {
            Name = name;
        }

    }
}