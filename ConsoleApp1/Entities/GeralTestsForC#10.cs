//1- We can use namespace like this in C# 10
// It is called file-scoped namespace

using System.ComponentModel.DataAnnotations;
using System.Text;

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
    Teste(new("teste"));

    StringBuilder sb = new("Olá mundo");
    StringBuilder sb2 = new();
  }
}

record struct Point(int x, int y)
{

}