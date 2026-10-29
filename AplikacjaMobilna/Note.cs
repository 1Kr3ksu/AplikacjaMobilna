public class Note {
    public string Tytul {get; set;}
    public string Tresc {get; set;}
    public bool CzyWazna {get; set;}
    public DateTime DataDodania { get; set; }

    public Note(string tytul, string tresc, bool czyWazna)
    {
        Tytul = tytul;
        Tresc = tresc;
        CzyWazna = czyWazna;
        DataDodania = DateTime.Now;
    }

    public Note(string tytul)
    {
        Tytul = tytul;
        Tresc = "";
        CzyWazna = false;
        DataDodania = DateTime.Now;
    }
    public void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {Tytul}");
    Console.WriteLine($"Treść: {Tresc}");
    Console.WriteLine($"Ważna: {CzyWazna}");
    Console.WriteLine($"Data dodania: {DataDodania:dd.MM.yyyy}");
    }
}
