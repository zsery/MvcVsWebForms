namespace BLL
{
    using System;

    using DBL.Mapping;
    using System.Data;
    using System.Linq;

    using Utils;
    using System.Collections.Generic;
    using System.Collections;
    using System.Runtime.InteropServices.WindowsRuntime;

    public class Events
    {
        private void Normalize()
        {
            DataTable etl = this.Items.Clone();
            etl.Columns["EventStateId"].DataType = typeof(string);
            int columns = etl.Columns.Count;
            foreach (DataRow row in this.Items.Rows)
            {
                var newRow = etl.NewRow();
                for (int i = 0; i < columns; i++)
                {
                    newRow[i] = row[i];
                }

                int esi = int.Parse(newRow["EventStateId"].ToString());
                newRow["EventStateId"] = new EventStates(esi).Items.Rows[0]["name"];
                etl.Rows.Add(newRow);
            }
            this.Items = etl;
        }
        //Random event for simulating call from parant page
        public Events(bool simulate)
        {
            var dbItems = new DataClasses1DataContext().EVENTs;
            if (simulate)
            {
                int count = dbItems.Count();
                int index = new Random().Next(count);
                var item = dbItems.ToList()[index];
                var list = dbItems.ToList();
                list.Clear();
                list.Add(item);
                this.Items = list.AsEnumerable().ToDataTable();
                //this.Items = Utils.ConvertToDataTable(list);
                //this.Items = Utils.ToDataTable<DBL.Mapping.EVENT>(list);
                this.Normalize();
            }
            else
            {
                this.Items = Utils.ToDataTable(dbItems);
            }
            int exception = new Random().Next(100);
            if (exception > 95)
            {
                throw new ValidationException("Test Events exception error", ValidationExceptionType.Error);
            }
            else
            {
                if (exception > 90)
                {
                    throw new ValidationException("Test Events exception warning", ValidationExceptionType.Warning);
                }
                else
                {
                    if (exception > 85)
                    {
                        throw new ValidationException("Test Events exception information", ValidationExceptionType.Information);
                    }
                }
            }
        }
        // Specific event
        public Events(int eventid)
        {
            var dbItems = new DataClasses1DataContext().EVENTs.Where(i=>i.EventId==eventid);
            this.Items = Utils.ToDataTable(dbItems);
            this.Normalize();
            int exception = new Random().Next(100);
            if (exception > 95)
            {
                throw new ValidationException("Test Events exception error", ValidationExceptionType.Error);
            }
            else
            {
                if (exception > 90)
                {
                    throw new ValidationException("Test Events exception warning", ValidationExceptionType.Warning);
                }
                else
                {
                    if (exception > 85)
                    {
                        throw new ValidationException("Test Events exception information", ValidationExceptionType.Information);
                    }
                }
            }
        }

        //Events for specific lecalCase
        public Events(int legalCaseId, bool nothing)
        {
            var dbItems = new DataClasses1DataContext().EVENTs.Where(i => i.CaseId == legalCaseId).Take(5);
            ItemsFiltered = dbItems.Select(
                i => new { eventId=i.EventId, Název_události = i.EventTypDescription, Zveřejněno =i.PublishedAt,
                    Zpracováno =i.ResolvedAt, Zpracoval=i.Resolver, Zkontrolováno=i.VerifiedAt, Zkontroloval=i.VerifiedBy }).AsEnumerable().ToDataTable();
            this.Items = Utils.ToDataTable(dbItems);
            this.Normalize();
            int exception = new Random().Next(100);
            if (exception > 95)
            {
                throw new ValidationException("Test Events exception error", ValidationExceptionType.Error);
            }
            else
            {
                if (exception > 90)
                {
                    throw new ValidationException("Test Events exception warning", ValidationExceptionType.Warning);
                }
                else
                {
                    if (exception > 85)
                    {
                        throw new ValidationException("Test Events exception information", ValidationExceptionType.Information);
                    }
                }
            }
        }
        //Navázané udalosti
        public DataTable Items { get; private set; }
        //Souvisejici udalosti/akce
        public DataTable ItemsFiltered { get; private set; }
    }
}
