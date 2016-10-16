namespace TEST
{
    using BLL;
    using System;
    using Utils;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = new LegalCase();
                var LegalCaseStates = new LegalCaseStates().Items;
                var Events = new Events(false).Items;
            }
            catch (ValidationException validationException)
            {
            }

            catch (Exception e)
            {
            }
        }
    }
}
