namespace TryParse_MyPersonalSolution
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int userWantThisInteger = Exempel4("Skriv ett heltal: ");
       Console.WriteLine($"{userWantThisInteger} är ett bra heltal!");
    }


    //Detta är bara ett sätt att lösa detta och hur jag gjorde!
    //Dela gärna med dig av din kod så får jag se hur du löste det!
    public static int Exempel4(string question)
    {
      while (true)
      {
        Console.Write(question);

        if (int.TryParse(Console.ReadLine(), out int validInteger))
        {
          return validInteger;
        }
        else
        {
          Console.WriteLine("Nä det där var ingen siffra!");
        }
      }
    }
  }
}
