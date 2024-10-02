// See https://aka.ms/new-console-template for more information

using ChanOfResponsibility;

var firstClass = new FirstClassReward();

firstClass
    .SetNext(new SecondClassReward())
    .SetNext(new ThirdClassReward());


var list = new List<Customer>
{
    new Customer{ FirstName="Saeed", LastName="Shiri", Score = 85 },
    new Customer{ FirstName="Iliya", LastName="Shiri", Score = 45 },
    new Customer{ FirstName="Arta", LastName="Shiri", Score = 100 },
    new Customer{ FirstName="Ali", LastName="Shiri", Score = 70 },
    new Customer{ FirstName="Amir", LastName="Amiri", Score = 170 },

};

foreach (var customer in list)
{
    var result = firstClass
    .HandleReward(customer) as string;

    Console.WriteLine(result);
}
Console.WriteLine("Hello, World!");
