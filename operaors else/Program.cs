Console.WriteLine("Please specify your age");
int age = Int32.Parse(Console.ReadLine());


if (age > 18)
{
    Console.WriteLine("Go party in the club");
}
else if(age == 18)
{
    Console.WriteLine("you can still party in the school ");
}
else
{
    Console.WriteLine("Stay at home");
}
