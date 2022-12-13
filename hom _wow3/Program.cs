int number = new Random().Next(1, 100); // 1 2 3 4 ... 100
Console.WriteLine(number);

if (number % 2 == 1)
{
    Console.WriteLine("ODD");
}
else
{
    Console.WriteLine("EVEN");
};
