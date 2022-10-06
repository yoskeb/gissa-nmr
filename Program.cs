

Console.WriteLine("Hello welcome to Guess the number");
Console.WriteLine("Please guess a number, good luck");

int nr;
string strNr;
Random randomerare = new Random();
int slump_tal = randomerare.Next(1, 101);
strNr = Console.ReadLine();
nr = Convert.ToInt32(strNr);
int guess = 1;


do
{


    guess++;


    if (nr > slump_tal)
    {
        Console.WriteLine("förlåt din gissning var fel");
        Console.WriteLine("försök ett lägre nummer");
        strNr = Console.ReadLine();
        nr = Convert.ToInt32(strNr);
    }
    else if (nr < slump_tal)
    {
        Console.WriteLine("förlåt din gissning var fel");
        Console.WriteLine("försök med högre nummer");
        strNr = Console.ReadLine();
        nr = Convert.ToInt32(strNr);
    }

    if (nr == slump_tal)
    {
        Console.WriteLine("grattis du gissade rät nummer " + guess + " try/s ");
        Console.ReadLine();


    }

} while (nr != slump_tal);