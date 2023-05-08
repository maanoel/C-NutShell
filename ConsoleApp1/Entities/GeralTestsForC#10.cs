//1- We can use namespace like this in C# 10
// It is called file-scoped namespace

namespace ConsoleApp1.Entities;

internal class GeralTests
{
  public void TesteWithOperator()
  {
    var a1 = new { A = 1, B = 2, C = 3 };

    var a2 = a1 with { C = 5 };

    var a3 = new { Sanday = 1, Monday = 2 };

    Console.WriteLine(a2);
  }

  public void TestingDesconstructionWithTuples()
  {
    var point = (3, 4);
    double x = 0;
    (x, double y) = point;

    Console.WriteLine(y);
    Console.WriteLine(x);

    Console.WriteLine(point.GetType());
  }

  public void TestingFuncDeclarations()
  {
    var teste = () => "oi";

    //Specify a return 
    var sum = int (int x, int y) => x + y;

    Console.WriteLine(teste());
    Console.WriteLine(sum(1, 2));

  }

  public void TesteDelegate(Delegate x)
  {
  }

  public void TestTry()
  {
    string teste = "10";

    int.TryParse(teste, out var x);
  }

  public void TestRecordWith()
  {
    var point = new Point(1, 2);
    var pointWith = point with { y = 5 };
    Console.WriteLine(pointWith);
  }

  public void TestTernarie() 
  {
    bool IsLetter(char c) => c is >= 'A' and <= 'z';
  }

  public void Teste(string teste)
  {
    //Target-Typed new Expressions

    Teste(new("teste"));

    StringBuilder sb = new("Olá mundo");
    StringBuilder sb2 = new();
  }

  public void TestIndices()
  {
    //Indices
    //Permite acessar um array a partir do final usando ^

    char[] vowels = { 'a', 'b', 'c' };

    char charLastElement = vowels[^1];
    char penultimate = vowels[^2];

    Console.WriteLine(charLastElement);
    Console.WriteLine(penultimate);

    Index last = ^1; //Index type

  }

  public void TestRanges()
  {
    //Permite criar um range do array usando  ..

    char[] vowels = { 'a', 'b', 'c' };

    char[] firstTwo = vowels[..2];
    char[] lastThree = vowels[2..];
    char[] middleOne = vowels[2..3];
    char[] lastTwo = vowels[^2..];

    Console.WriteLine("firstTwo" + firstTwo.ToString());
    Console.WriteLine("lastThree" + lastThree.ToString());
    Console.WriteLine("middleOne" + middleOne.ToString());
    Console.WriteLine("lastTwo" + lastTwo.ToString());

    Range firstTwoRange = ..2; //Range Type
  }
}

record struct Point(int x, int y)
{

}
