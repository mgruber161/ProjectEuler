var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int result = 0;
for (int i = 0; i < 1000; i++)
	for (int j = 0; j < 1000; j++)
		result = CheckPalindrome((i*j).ToString()) && (i*j)>result ? i * j : result;
watch.Stop();
Console.WriteLine($"Result: {result}, ElapsedMilliseconds: {watch.ElapsedMilliseconds}"); //53ms

bool CheckPalindrome(string v)
{
	int j = v.Length - 1;
	for (int i = 0; i < v.Length / 2; i++)
	{
		if (v[i] != v[j])
			return false;
		j--;
	}
	return true;
}