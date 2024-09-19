namespace Fociwebapp.Models
{
    public class Csapatadatai
    {
        public Csapatadatai(int helyezes)
        {
            Helyezes = helyezes;
        }

        public Csapatadatai(string nev, int gyozelmek, int dontetlenek, int veresegek, int lott, int kapott, int pontok)
        {
            Nev = nev;
            Gyozelmek = gyozelmek;
            Dontetlenek = dontetlenek;
            Veresegek = veresegek;
            Lott = lott;
            Kapott = kapott;
            Pontok = pontok;
        }

        public int Helyezes { get; set; }
        public string? Nev { get; set; }
        public int Gyozelmek { get; set; }
        public int Dontetlenek { get; set; }
        public int Veresegek { get; set; }
        public int Lott { get; set; }
        public int Kapott { get; set; }
        public int Pontok { get; set; }

    }
}
