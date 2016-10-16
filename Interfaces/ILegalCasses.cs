namespace Interfaces
{
    using System.ComponentModel;

    public interface ILegalCasses
    {
        int stavid { get; set; }

        string stav_nazev { get; set; }

        string stav_popis { get; set; }

        string popisnawebu { get; set; }

        event PropertyChangingEventHandler PropertyChanging;

        event PropertyChangedEventHandler PropertyChanged;
    }
}