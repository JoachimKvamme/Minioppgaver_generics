using Generics.Classes;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");




        ExampleGenerics<int> genericValueInt = new ExampleGenerics<int>();
        genericValueInt.Value = 3;
        ExampleGenerics<string> exampleGenericsString = new ExampleGenerics<string>();
        exampleGenericsString.Value = "Joachim"; 

        // Koden under printer typen til Value-egenskapen i Generics-klassen. Selv om man bruker samme klasse og samme egenskap, 
        // tillater det at klassen er en generisk klasse, meg å gi egenskapen forskjellige typer i hvert tilfelle.
        Console.WriteLine(genericValueInt.Value.GetType());
        Console.WriteLine(genericValueInt.Value);
        Console.WriteLine(exampleGenericsString.Value.GetType());
        Console.WriteLine(exampleGenericsString.Value);

        // Dersom man velger å anvende de forskjellige instansene av Generics-klassen, vil man få forskjellige utfall.

        // Addering med ExampleGenerics<int>:
        ExampleGenerics<int> secondInt = new();
        secondInt.Value = 10; 

        Console.WriteLine(genericValueInt.Value + secondInt.Value);

        // Konkatenering med ExampleGenerics<string>:

        ExampleGenerics<string> stringTwo = new();
        stringTwo.Value = "Kvamme";
        Console.WriteLine($"{exampleGenericsString.Value} {stringTwo.Value}");

        // Generics lar oss, som (noenlunde) vist, tilpasse klasser til de typene man trenger, ettersom man trenger dem. List<T>-klassen er et (bedre) eksempel på
        // på dette: List<T> klassen lar oss på løpende bånd initialisere ulike lister, hvor List-logikken følger med uavhengig av hvilke typer List-en inneholder.
    }
}
