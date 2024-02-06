
using Operators;
using System.Data;

var animals = new Animal?[]
{
    new Cat {Name= "karen" , Born= new(year:2022, month: 8, day: 23), Legs= 4, IsDomestic= true},
    null,
    new Cat {Name= "Mufasa" , Born = new(year:1994, 6,12)},
    new Spider {Name = "Sid Vicious",  Born = DateTime.Today, IsPoisonous= true},
    new Spider {Name= "Captain Furry" , Born= DateTime.Today}
};

foreach (Animal? animal in animals)
{
    string message;

    switch(animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs== 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {wildCat.Name}";
            break;
        case Cat cat:
            message = $"the cat is name {cat.Name}";
            break;
        default:
            message = $"{animal.Name} is a {animal.GetType().Name}";
            break;

        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is Posonous . RUN!";
            break;

        case null:
            message = "The animal is null";
            break;
    }

    Console.WriteLine($"Switch Statement: {message}");
}