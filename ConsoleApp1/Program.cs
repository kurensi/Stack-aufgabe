var karten = new Stack<string>();
karten.Push("Herz 2");
karten.Push("Karo 3");
karten.Push("Pik 10");
karten.Push("Pik 5");
karten.Push("Kreuz Dame");

foreach (var x in karten)
{
    Console.WriteLine($"Oben steht {x}");
}

for (int i = karten.Count; i > 0; i--)
    if (karten.Peek().Equals("Pik 10"))
    {
        break;
    }
    else
    {
        karten.Pop();
    }

Console.WriteLine($"\n---------- Die restlichen Karten----------");

foreach (var x in karten)
{
    Console.WriteLine($"Oben steht {x}");
}

