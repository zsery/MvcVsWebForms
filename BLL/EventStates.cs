namespace BLL
{
    using DBL.Mapping;
    using System.Data;
    using System.Linq;
    using System.Security.Permissions;

    public class EventStates
    {
        public DataTable Items { get; }

        public EventStates()
        {
            this.Items = Utils.Utils.ToDataTable(new DataClasses1DataContext().C_EVENT_STATEs);
        }

        public EventStates(int event_state_id)
        {
            this.Items = Utils.Utils.ToDataTable(new DataClasses1DataContext().C_EVENT_STATEs.Where(e=>e.event_state_id== event_state_id));
        }
    }
}