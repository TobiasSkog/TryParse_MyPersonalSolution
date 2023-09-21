namespace TryParse_MyPersonalSolution
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Exempel4("Skriv ett heltal: ");
    }


    //Detta är bara ett sätt att lösa detta och hur jag gjorde!
    //Dela gärna med dig av din kod så får jag se hur du löste det!
    public static void Exempel4(string question)
    {
      while (true)
      {
        Console.Write(question);

        if (int.TryParse(Console.ReadLine(), out int validInteger))
        {
          Console.WriteLine($"{validInteger} är en bra siffra!");
          break;
        }
        else
        {
          Console.WriteLine("Nä det där var ingen siffra!");
        }
      }
    }
  }
}