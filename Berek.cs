namespace berek2020
{
    internal class Berek
    {
        public string nev { get; set; }
        public string neme { get; set; }
        public string reszleg { get; set; }
        public int belepes { get; set; }
        public int ber { get; set; }

        public override string ToString() =>   
            $"\n\tNév: {nev}\n\tNem: {neme}\n\tBelépés: {belepes}\n\tBér: {ber}";

        public Berek(string sor)
        {
            string[] b = sor.Split(';');
            nev = b[0];
            neme = b[1];
            reszleg = b[2];
            belepes = int.Parse(b[3]);
            ber = int.Parse(b[4]);
        }
    }
}
