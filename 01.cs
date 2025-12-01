

// read lines from local text file
var filePath = @"c:\Git\AOF2025\01.txt";
var lines = await File.ReadAllLinesAsync(filePath);
Console.WriteLine($"Read {lines.Length} lines from {filePath}");
foreach (var line in lines)
{
    Console.WriteLine(line);
    // process the line here
}



