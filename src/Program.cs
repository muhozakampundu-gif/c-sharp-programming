// LibraryKiosk — Unit 01: .NET Ecosystem & C# Fundamentals
//
// No classes yet — Unit 02 introduces those. Everything below lives right
// in this file, using nothing but variables, operators, and control flow.

var mode = args.Length > 0 ? args[0].ToLowerInvariant() : "capstone";

switch (mode)
{
    case "l1":
        RunL1();
        break;
    case "l2":
        RunL2();
        break;
    case "capstone":
        RunCapstone();
        break;
    default:
        Console.WriteLine("Usage: dotnet run -- [L1|L2|capstone]");
        break;
}

void RunL1()
{
Console.WriteLine("=== L1: Your First Console App ===");
// TODO 1: Print a 3-line welcome banner for the Kigali Campus Library
//   kiosk (anything you like, as long as it's 3 separate WriteLine calls).


Console.WriteLine("happy birthday my sister");

Console.WriteLine("this is your day");

Console.WriteLine("i have special gift for you");

// TODO 2: Console.Write a prompt for the user's name, then

Console.Write("what is your name?");

// Console.ReadLine() it into a string variable.

Console.Write("what is your name?");

string name = Console.ReadLine();

// TODO 3: Print a personalized greeting using the name you just read.
Console.WriteLine($"hello {name}");

}

void RunL2()
{
    Console.WriteLine("=== L2: Types, Variables & Operators ===");
// TODO 1: Declare three variables for one book: a string title, an
//   int pageCount, and a decimal price.
    string title = "Something";
    int   pageCount=100;
    decimal  price =50000;

    // TODO 2: Compute a 10%-off price from price and store it in a new
    //   decimal variable.
    decimal discountedprice= price*0.9m;

    // TODO 3: Print title, pageCount, price, and the discounted price in //   ONE interpolated string.
Console.WriteLine($"title: {title}, pages: {pageCount}, price: {price}, discounted price: {discountedprice}");
    
}

void RunCapstone()
{
    Console.WriteLine("=== Capstone: Kigali Campus Library Kiosk — Day One ===");
    // TODO 1: Declare loose variables for one Book: title (string),
    //   isbn (string), pages (int).
    string title="oop foundamentals" ;
    string isbn="2376-h5";
    decimal price =400 ;

// TODO 2: Declare loose variables for one Member: name (string),
//   maxBooks (int, e.g. 3), booksCheckedOut (int, starting at 0).
string name = "C# Fundamentals";
int maxBooks = 3;
int booksCheckedOut = 0;

    // TODO 3: Write an if/else: if booksCheckedOut < maxBooks, increment
    //   booksCheckedOut and print a checkout confirmation mentioning name
    //   and title; otherwise print that the limit has been reached.
void Checkout()
{
    if (booksCheckedOut < maxBooks)
    {
        booksCheckedOut++;
        Console.WriteLine($"Checkout confirmation: {name} checked out {title}.");
    }
    else
    {
        Console.WriteLine("The limit has been reached.");
    }
}
    // TODO 4: Call whatever you wrote for TODO 3 four times in a row (more
    //   than maxBooks) and confirm the limit message appears at least once.
    //   A for loop is the natural way to do this — see Part 04.
   for (int i = 0; i < 4; i++)
{
    Checkout();
}
}

