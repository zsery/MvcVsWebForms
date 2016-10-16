namespace BLL
{

    using DBL.Mapping;
    using System.Data;

    public class LegalCaseStates
    {
        public LegalCaseStates()
        {
            var dbItems = new DataClasses1DataContext().STAVPRIPADUs;

            this.Items = Utils.Utils.ToDataTable(dbItems);
        }

        public DataTable Items;
    }
}