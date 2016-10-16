using System.Data;

namespace BLL
{
    using System;
    using Interfaces;
    public class KBI_IDS :IKBI_IDS
    {
        public KBI_IDS(DataTable debtors)
        {
            this.Items = new EXL.KBI_IDS(debtors).Items;
        }

        public DataTable Items { get; }
    }
}