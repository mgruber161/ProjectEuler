var names = File.ReadAllText(@"D:\repos\csharp\ProjectEuler\001-099\022\names.txt").Replace("\"", "").Split(',').OrderBy(n => n).ToArray();
int sum = 0, score = 0;
for(int i = 0; i < names.Length; i++)
{
    for (int j = 0; j < names[i].Length; j++)
        score += (int)names[i][j] - 64;
    sum += score * (i+1);
    score = 0;
}
Console.WriteLine(sum);    