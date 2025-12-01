
var keyboard = new Dictionary<char, (int row, int col)>
{
    {'1', (0, 0)}, {'2', (0, 1)}, {'3', (0, 2)},
    {'4', (1, 0)}, {'5', (1, 1)}, {'6', (1, 2)},
    {'7', (2, 0)}, {'8', (2, 1)}, {'9', (2, 2)},
};


// read lines from local text file
var filePath = @"c:\Git\AOF2025\01.txt";
var lines = await File.ReadAllLinesAsync(filePath);
Console.WriteLine($"Read {lines.Length} lines from {filePath}");
foreach (var line in lines)
{
    Console.WriteLine(line);
    // process the line here
}



var pos = keyboard['5'];

Console.WriteLine("startPos: " + pos);
pos = Move(pos, 'U');
pos = Move(pos, 'L');


static (int, int) Move((int row, int col) pos, char dir)
{
    var result = dir switch
    {
        'L' => (pos.row, Math.Max(0, pos.col - 1)),
        'R' => (pos.row, Math.Min(2, pos.col + 1)),
        'U' => (Math.Max(0, pos.row - 1), pos.col),
        'D' => (Math.Min(2, pos.row + 1), pos.col),
        _ => pos
    };

    Console.WriteLine("Going: " + dir + ". New position:" + result);
    return result;
}
