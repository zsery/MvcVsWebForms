namespace BLL
{
    using System.Collections.Generic;
    public class LegalCases:List<LegalCase>
    {
        public LegalCases()
        {
            this.Add(new LegalCase());
        }

        public LegalCases(int idPripadu)
        {
            this.Add(new LegalCase(idPripadu));
        }
    }
}