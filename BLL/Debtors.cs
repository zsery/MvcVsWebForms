using System.Data;

namespace BLL
{
    using EXL;
    public class Debtors : IDebtors
    {
        public Debtors(int pripadId)
        {
            this.Items = new EXL.Debtors(pripadId).Items;
        }

        public DataTable Items { get; }
    }
}