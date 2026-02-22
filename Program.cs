using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Conjunto de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 75 vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 75 vacunados con AstraZeneca
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 51; i <= 125; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // Ambas dosis (Intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // Unión de vacunados
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        // No vacunados
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        Console.WriteLine("Total ciudadanos: " + ciudadanos.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
    }
}