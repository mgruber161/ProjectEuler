Queue<int> numbers = new Queue<int>(new int[] {1,2});
int sum = 0;
while(numbers.Peek() < 4_000_000)
{
    if (numbers.Peek() % 2 == 0)
        sum += numbers.Peek();
    numbers.Enqueue(numbers.Dequeue() + numbers.Peek());
}
Console.WriteLine(sum);