Console.WriteLine("Are you coming or leaving? (in/out):");
string userCoice = Console.ReadLine();

if (userCoice == "in")
{

    PrintHello();
}
else
{
    PrintGoodBye();
}



static void PrintHello()
{
    Console.WriteLine("Hello, word!");
}
  
static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}