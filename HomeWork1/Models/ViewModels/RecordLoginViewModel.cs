using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork1.Models.ViewModels
{
    public class RecordLoginViewModel
    {
        public int RowSeq { get; set; }

        public string Rec_type { get; set; }

        public DateTime Rec_date { get; set; }

        public int Rec_money { get; set; }

        public RecordLoginViewModel() { }

        public RecordLoginViewModel(int no, string type, DateTime date, int money)
        {
            this.RowSeq = no;
            this.Rec_type = type;
            this.Rec_date = date;
            this.Rec_money = money;
        }
    }
}