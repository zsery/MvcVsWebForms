using System;

namespace BLL
{


    using DBL.Mapping;
    using System.Linq;
    using Utils;

    /// <summary>
    /// LegalCase
    /// </summary>
    public class LegalCase
    {
        public string Sign { get; }

        public DateTime? RecordSavedAt { get; }

        public string State { get; }

        public DateTime? LegalCaseIniatedAt { get; }

        public DateTime? LegalCaseResolvedAt { get; }

        public string RiskCode { get; }



        public LegalCase():this(new DataClasses1DataContext().PRIPADs.ToList()[new Random().Next(new DataClasses1DataContext().PRIPADs.Count())].pripadid)
        {}
        public LegalCase(int pripadid)
        {
            var dbLegalCases = new DataClasses1DataContext().PRIPADs;
            int count = dbLegalCases.Count();
            int index = new Random().Next(count);
            var legalCase = dbLegalCases.ToList().Where(i=>i.pripadid==pripadid).FirstOrDefault();
            this.Sign = legalCase.spis_znacka;
            this.RecordSavedAt = legalCase.ulozeno;
            this.State = new LegalCaseStates().Items.Select("stavid=" + legalCase.stavid)[0]["stav_popis"].ToString()+" ("+
                new LegalCaseStates().Items.Select("stavid=" + legalCase.stavid)[0]["popisnawebu"].ToString()+")";
            this.LegalCaseIniatedAt = legalCase.pripad_start;
            LegalCaseResolvedAt = legalCase.pripad_konec;
            this.RiskCode = string.Empty;
            int exception = new Random().Next(100);
            if (exception > 95)
            {
                throw new ValidationException("Test LegalCase exception error", ValidationExceptionType.Error);
            }
            else
            {
                if (exception > 90)
                {
                    throw new ValidationException("Test LegalCase exception warning", ValidationExceptionType.Warning);
                }
                else
                {
                    if (exception > 85)
                    {
                        throw new ValidationException("Test LegalCase exception information", ValidationExceptionType.Information);
                    }
                }
            }
        }

   
    }
}
