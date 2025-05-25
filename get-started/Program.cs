List<int> fibonacciNumbers = [1, 2];

var prev = 1;
var prev2 = 2;

for (int i = 3; i <= 20; i++)
{
    var next = prev + prev2;
    fibonacciNumbers.Add(next);
    prev = prev2;
    prev2 = next;
}

Console.WriteLine(fibonacciNumbers[^1]);