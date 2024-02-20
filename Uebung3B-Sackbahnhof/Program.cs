using Uebung3B_Sackbahnhof;

public class Program
{
    static void Main(string[] args)
    {
        Sackbahnhof bahnhof = new Sackbahnhof();

        bahnhof.WagonHinzufügen(new Wagon("A"), "S2");
        bahnhof.WagonHinzufügen(new Wagon("B"), "S2");
        bahnhof.WagonHinzufügen(new Wagon("A"), "S2");
        bahnhof.WagonHinzufügen(new Wagon("B"), "S2");
        bahnhof.WagonHinzufügen(new Wagon("A"), "S3");
        bahnhof.WagonHinzufügen(new Wagon("A"), "S3");
        bahnhof.WagonHinzufügen(new Wagon("B"), "S3");
        bahnhof.WagonHinzufügen(new Wagon("B"), "S3");
        bahnhof.WagonHinzufügen(new Wagon("A"), "S3");


        bahnhof.Umordnen();

        bahnhof.PrintGleise();
    }
}
