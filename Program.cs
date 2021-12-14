var spellFile = Environment.GetCommandLineArgs()[1];

Dictionary<char, string> ReadSpellFile(string spellFile)
{
    return File.ReadAllText(spellFile).Split('\n')
        .Select(_ => _.Trim())
        .Select(_ => _.Split('\t'))
        .ToDictionary(_ => Char.ToUpper(_[0][0]), _ => _[1]);
}

var spelling = ReadSpellFile(spellFile);

while (true)
{
    var line = Console.ReadLine();
    if (line is null) { break; }
    foreach (var c in line)
    {
        if (spelling.TryGetValue(Char.ToUpper(c), out var text))
        {
            Console.Write(text); Console.Write(" ");
        }
    }
    Console.WriteLine();
}
