int count = 0;
for (int i = 1; i < 1001; i++)
    count += GetNumberString(i).Replace(" ", "").Length;
Console.WriteLine(count);
string GetNumberString(int i)
{
    switch (i.ToString().Length)
    {
        case 1: return GetSingleNumberString(i);
        case 2:
            if (i / 10 != 1) return GetTensPlaceString(i / 10) + " " + GetSingleNumberString(i % 10);
            else return GetTeensString(i);
        case 3:
            if (i % 100 == 0) return GetSingleNumberString(i / 100) + " hundred";
            else return GetSingleNumberString(i / 100) + " hundred and " + GetNumberString(i % 100);
        case 4: return "one thousand";
        default: return string.Empty;
    }
}
string GetTeensString(int i)
{
    switch (i)
    {
        case 10: return "ten ";
        case 11: return "eleven ";
        case 12: return "twelve ";
        case 13: return "thirteen ";
        case 14: return "fourteen ";
        case 15: return "fifteen ";
        case 16: return "sixteen ";
        case 17: return "seventeen ";
        case 18: return "eighteen ";
        case 19: return "nineteen ";
        default: return string.Empty;
    }
}
string GetTensPlaceString(int v)
{
    switch (v)
    {
        case 2: return "twenty ";
        case 3: return "thirty ";
        case 4: return "fourty ";
        case 5: return "fifty ";
        case 6: return "sixty ";
        case 7: return "seventy ";
        case 8: return "eighty ";
        case 9: return "ninety ";
        default: return string.Empty;
    }
}
string GetSingleNumberString(int v)
{
    switch (v)
    {
        case 1: return "one ";
        case 2: return "two ";
        case 3: return "three ";
        case 4: return "four ";
        case 5: return "five ";
        case 6: return "six ";
        case 7: return "seven ";
        case 8: return "eight ";
        case 9: return "nine ";
        default: return string.Empty;
    }
}