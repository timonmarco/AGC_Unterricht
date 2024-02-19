using System;
using Uebung3A_Wartezimmer;

public class Program
{
    public static void Main(string[] args)
    {
        Wartezimmer wartezimmer = new Wartezimmer();

        Patient patient1 = new Patient("Anna");
        Patient patient2 = new Patient("Ben");
        Patient patient3 = new Patient("Chris");
        wartezimmer.PatientAnmelden(patient1);
        wartezimmer.PatientAnmelden(patient2);
        wartezimmer.PatientAnmelden(patient3);

        Console.WriteLine($"Anzahl Patienten: {wartezimmer.AnzahlPatienten()}");

        Patient patientAmZug = wartezimmer.NaechstenPatientenAufrufen();
        Console.WriteLine($"{patientAmZug.Name} ist dran!");

        Console.WriteLine($"Wartezimmer leer? {wartezimmer.IstLeer()}");

        while (!wartezimmer.IstLeer())
        {
            patientAmZug = wartezimmer.NaechstenPatientenAufrufen();
            Console.WriteLine($"{patientAmZug.Name} ist dran!");
        }
    }
}
