string[] input = "75\r\n95 64\r\n17 47 82\r\n18 35 87 10\r\n20 04 82 47 65\r\n19 01 23 75 03 34\r\n88 02 77 73 07 63 67\r\n99 65 04 28 06 16 70 92\r\n41 41 26 56 83 40 80 70 33\r\n41 48 72 33 47 32 37 16 94 29\r\n53 71 44 65 25 43 91 52 97 51 14\r\n70 11 33 28 77 73 17 78 39 68 17 57\r\n91 71 52 38 17 14 91 43 58 50 27 29 48\r\n63 66 04 68 89 53 67 30 73 16 69 87 40 31\r\n04 62 98 27 23 09 70 98 73 93 38 53 60 04 23".Split("\r\n");
List<int[]> triangle = new List<int[]>();
Random random = new Random(DateTime.UtcNow.Second);
foreach (string line in input)
    triangle.Add(line.Split(" ").Select(n => int.Parse(n)).ToArray());
int biggestSum = 0, sum = 0, index = 0;
while (true)
{
    for (int i = 0; i < triangle.Count; i++)
    {
        index = random.Next(index, index + 2);
        if (index >= triangle[i].Length) index--;
        sum += triangle[i][index];
    }
    index = 0;
    if (sum > biggestSum) biggestSum = sum;
    sum = 0;
    Console.WriteLine(biggestSum);
}