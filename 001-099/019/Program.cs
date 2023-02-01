var dt = new DateTime(1901, 01, 01);
int count = 0;
while(dt.Year < 2001)
{
    if(dt.DayOfWeek== DayOfWeek.Sunday && dt.Day == 1) count++; 
    dt = dt.AddMonths(1);
}
Console.WriteLine(count);