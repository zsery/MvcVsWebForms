namespace EXL
{
    using System.Data;
    using System.Linq;

    using ExternalLayer.Mapping;

    using Utils;

    public class Debtors : IDebtors
    {
        public DataTable Items { get; }

        public Debtors(int pripadId)
        {
            Items = Utils.ToDataTable(new DataClasses1DataContext().DLUZNIKs.Where(p=>p.pripadid==pripadId));
        }
    }
}