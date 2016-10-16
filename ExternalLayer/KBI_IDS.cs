namespace EXL
{
    using ExternalLayer.Mapping;
    using Utils;
    using System.Data;
    using System.Linq;
    using Interfaces;
    using System;

    public class KBI_IDS : IKBI_IDS
    {
        public DataTable Items { get; }

        public KBI_IDS(DataTable debtors)
        {
            if (debtors.Rows.Count > 0) { 
                int dluzikId = debtors.AsEnumerable().Select(r => r.Field<int>("dluznikid")).ToList()[0];
                string dluznikName = debtors.AsEnumerable().Select(r => r.Field<string>("nazev")).ToList()[0];
                Items =
                    Utils.ToDataTable(
                        new DataClasses1DataContext().KBI_IDs.Where(i => i.dluznikid == dluzikId)
                            .Select(
                                d =>
                                new
                                    {
                                        Dlužník = dluznikName,
                                        KBI_ID = d.kbi_id1,
                                        Název_KBI_ID = d.general_name,
                                        Typ_klienta = d.legal_type_id,
                                        RČ_IČO = d.identification_no,
                                        AVR_GREC = "Ano",
                                        Safes = "Ne",
                                        Zadáno = d.zadano,
                                        Zadal = d.zadal,
                                        Akce = 0
                                    }));
            }
        }
    }
}