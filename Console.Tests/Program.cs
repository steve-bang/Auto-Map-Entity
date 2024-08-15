// See https://aka.ms/new-console-template for more information
using Steve.AutoMapEntity;
using Steve.AutoMapEntity.Generator;

Console.WriteLine("Hello, World!");

User user = new User();

var typeUser = user.GetType();

GeneratorFactory generatorFactory = GeneratorFactory.Builder(Styles.SnakeCase);
generatorFactory.OriginStyle = Styles.CamelCase;

var dictionary = generatorFactory.Handle(typeUser);

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

