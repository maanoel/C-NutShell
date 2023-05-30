//1- We can use namespace like this in C# 10
// It is called file-scoped namespace

namespace ConsoleApp1.Entities;

internal class GeralTests
{
  //index
  /// <summary>
  /// //JUST A TEST CLASS GENERAL TEST C#
  /// </summary>
  class BaseClass
  {
    public virtual void Foo()
    {
      Console.WriteLine("From base class");
    }
  }

  class Overrider : BaseClass
  {
    public override void Foo()
    {
      Console.WriteLine("Override");
    }
  }

  class Hider : BaseClass
  {
    //I can over with new too
    public new void Foo()
    {
      Console.WriteLine("New keyword in method");
    }
  }



  public class Teste
  {
    public void Testes()
    {
      Overrider over = new Overrider();
      Hider hider = new Hider();

      BaseClass b1 = over;
      BaseClass b2 = hider;
      b1.Foo();
      b2.Foo();
    }
  }

  class Sentence
  {
    string[] words = "Olá mundo".Split();

    public string this[int wordNum]
    {
      get => words[wordNum];
      set => words[wordNum] = value;
    }
  }

  class Bunny
  {
    //PARAMETERLESS CONSTRUCTOR
    public bool LikeCarrots { get; set; }
    public bool LikeHumans { get; set; }

    void Teste()
    {
      var teste = new Bunny { LikeCarrots = true, LikeHumans = true };
    }
  }

  public class Pedido
  {
    decimal Valor { get; }

    public Pedido(decimal valor)
    {
      Valor = valor;
    }

    public void Desconstruct(out decimal valor)
    {
      valor = Valor;
    }
  }

  public class TestePedido
  {
    void Teste()
    {
      var pedido = new Pedido(100);
      pedido.Desconstruct(out decimal valor);
      Console.WriteLine(valor);
    }
  }


  public void ExternalAlias()
  {
    //extern alias W1;
  }

  public void NameParams(int x, int y)
  {
    NameParams(x: 10, y: 20);
    Console.WriteLine($"{x}-{y}");
  }

  public void ParamsMethods()
  {
    Teste(new int[] { 1, 2, 3, 4, 5 });
    Teste(1, 2, 3, 4, 5);

    void Teste(params int[] testeParams)
    {
      for (int i = 0; i < testeParams.Length; i++)
      {
        Console.WriteLine(testeParams[i]);
      }
    }
  }

  public void Discard()
  {
    //Caveat, if I declare a variable 
    //_ the discard will no exists because of variable

    void Split(out string first, out string second)
    {
      first = "Olá";
      second = "Então irmão";
    }

    Split(out string teste, out _);

    Console.WriteLine(teste);

  }

  public void IsNotANumber()
  {
    var teste = double.IsNaN(0.0 / 0.0);
  }

  public void DoubleSpecialValue()
  {
    double infinite = double.PositiveInfinity;
    double inifiteNegative = double.NegativeInfinity;

    double notNumber = double.NaN;
  }

  public void uncheckedOperation()
  {
    int value = int.MinValue;
    int maxValue = --value;

    Console.WriteLine(maxValue == int.MaxValue);

    //uncheked not throw error in compiler time
    int valueMin = int.MaxValue;
    valueMin = unchecked(valueMin + 1);
  }
  public void TheNameOfOperator()
  {
    //O nameof evita que ao modificar algo que referencie o nome da variável 
    // não faça quebrar o projeto posteriormente
    //
    string teste = "10";

    string nameOf = nameof(teste);

    Console.WriteLine(nameOf);
  }

  public void TuplesUsing()
  {
    var tuple = (10, 20);
    Console.WriteLine(tuple.Item1);
    Console.WriteLine(tuple.Item2);

    var namedTuple = (age: 10, name: "Vitor");

    Console.WriteLine(namedTuple.age);
    Console.WriteLine(namedTuple.name);


    (int row, int column) GetPosition() => (10, 12);

    var teste = GetPosition();

    Console.WriteLine(teste.column);

    (int row, int column) = GetPosition();

    Console.WriteLine(row);
  }

  public void LocalMethods()
  {
    Console.WriteLine(Cube(2));
    Console.WriteLine(Cube(2));
    int Cube(int value) => value * value * value;
    int Raiz(int value) => value * value;
  }

  public void NameTuples()
  {
    decimal number = default;
    var now = DateTime.Now;
    var tuple = (Hour: now.Hour, Minute: now.Minute, Second: now.Second);
    Console.WriteLine(DateTime.Now);
    Console.WriteLine(tuple.Hour);
    Console.WriteLine(tuple.Minute);
    Console.WriteLine(tuple.Second);
  }

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
    var divide = double (int y, int x) => x / y;

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

  //public void Teste(string teste)
  //{
  //  //Target-Typed new Expressions

  //  Teste(new("teste"));

  //  StringBuilder sb = new("Olá mundo");
  //  StringBuilder sb2 = new();
  //}

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

  public void TestSwitchExpression()
  {
    int cadNumber = 10;

    string cardNarme = cadNumber switch
    {
      12 => "Rei",
      13 => "Rainha",
      14 => "isso daqui realmente é top demais",
    };

  }

  public void TestDefaultInterfaceMembers()
  {
    //Implements always go throug interface
    ((ILogger)new Logger()).Log("Olá");

    var loggerTeste = ((ILogger)new Logger());

    var teste = ILogger.Prefix;
    var testeobj = ILogger.Teste;

  }
  public void TesteNewInMethod()
  {
    Overrider over = new Overrider();
    Hider hider = new Hider();

    BaseClass base1 = over;
    BaseClass base2 = hider;

    base1.Foo();
    base2.Foo();
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


  public void NullCoalescing()
  {
    //Null - coalescing assignment
    var s = "";

    if (s == null) s = "OI";

    s ??= "OPA";

    s ??= "carai o C# ta ficando igual perl? kkk";
  }

  public void TestTupleAssignVariables()
  {
    var (numero, texto) = (10, "OI");

    var numeroTexto = (numero, texto) switch
    {
      (10, "OI") => "Número 10 oi",
      _ => "Valor default" //underscore for discard symbol, it runs like a default switch
    };
  }

  public void PositionalPatterns()
  {
    string obj = "Olá mundo";

    if (obj is string { Length: 4 })
    {
      Console.Write("Teste de propriedade");
    }
  }

  public void TestType()
  {
    int teste = 10;
    object testeobj = "10";

    Console.WriteLine(teste.GetType());
    Console.WriteLine(testeobj.GetType());
    Console.WriteLine(typeof(Product).Name);
  }

  public void Contravariance()
  {
    IPushable<Animal> animals = new Stack<Animal>();
    IPushable<Bear> bears = animals;

    IPoppable<Bear> bearsTwo = new Stack<Bear>();
    IPoppable<Animal> animalTwo = bearsTwo;
  }

  public void Compare()
  {
    var teste = Comparer<object>.Default;
    IComparer<string> stringComparer = teste;

    int testeDois = stringComparer.Compare("teste", "teste");
  }

  public void ExceptionWithoutDeclare()
  {
    try
    {
      int.TryParse("0", out int teste);
    }
    catch
    {
      Console.WriteLine("OK");
    }
  }

  public void ThrowIfIsNull()
  {

    //Caveat to test if a value is null
    var name = "name fo test";
    ArgumentNullException.ThrowIfNull(name);
  }

  public void DictionaryTestsInit()
  {
    Dictionary<int, string> teste = new Dictionary<int, string>
    {
      [3] = "Vitor",
      [4] = "Mundo"
    };

    Dictionary<int, string> secondTeste = new Dictionary<int, string>
    {

        {3, "vitor"},
        {4, "Teste"}
    };
  }
}

public static class StringHelper
{
  public static bool IsCaptalized(this string s)
  {
    if (string.IsNullOrEmpty(s)) return false;
    return Char.IsUpper(s[0]);
  }
}
public interface IPushable<in T>
{
  void Push(T obj);
}


public interface IPoppable<out T>
{
  T Pop();
}
public class Stack<T> : IPushable<T>, IPoppable<T>
{
  public void Push(T obj)
  {
    
  }

  public T Pop()
  {
    return default;
  }
}
class Animal { }
class Bear: Animal { }
class Product { }

record Point(int x, int y)
{
  //When we use parameters the assign occurs automatically
  bool HasSameValuesParameters() {
    return x.Equals(y);
  }
}

interface ILogger
{
  static string Prefix = "Oi";
  static object Teste = new object();
  void Log(string text) => Console.Write(Prefix + text);
}

public class Logger : ILogger
{

}
