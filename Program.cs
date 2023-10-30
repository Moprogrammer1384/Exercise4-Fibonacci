//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 4
//***********************************

while (true)
{
    int Seq1 = 0, Seq2 = 1, Seq3 = 0;
    Console.Write("Please enter the number of fibonacci sequence: ");
    string Input = Console.ReadLine();
    int Number;
    if (IsInt(Input))
    {
        Number = Convert.ToInt32(Input);
    }
    else
    {
        Console.WriteLine("Please enter a correct number!!!");
        continue;
    }
    if(Number == 2)
    {
        Console.WriteLine(1);
        continue;
    }
    for (int i = 2; i < Number; i++)
    {
        Seq3 = Seq1 + Seq2;
        Seq1 = Seq2;
        Seq2 = Seq3;
    }
    Console.WriteLine(Seq3);
    Console.Write("Do you want to continue?if yes enter (y): ");
    if (Console.ReadLine() == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}

static bool IsInt(string input)
{
    foreach (char c in input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}