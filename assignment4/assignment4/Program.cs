// See https://aka.ms/new-console-template for more information
using assignment4;

Console.WriteLine("Hello, World!");


MyList<String> animalList = new MyList<String>();
animalList.Add("turtle");
animalList.Add("bird");
animalList.Add("monkey");
animalList.Remove(1);
foreach(String animal in animalList)
{
    Console.Write(animal + " ");
}

Console.WriteLine("\nBelow will contain result of My stack implementation!");
MyStack<int> numsStack = new MyStack<int>();
numsStack.Push(5);
numsStack.Push(6);
numsStack.Push(11);
Console.WriteLine("Pop from my stack: " + numsStack.Pop());

Console.WriteLine("\nBelow will contain result of my repository implementation!");
Entity entity = new Entity();
entity.Id = "abcdeasda";
Entity entity1 = new Entity();
entity1.Id = "asdahsfds";

GenericRepository<Entity> genRepo = new GenericRepository<Entity>();
genRepo.Add(entity);
genRepo.Add(entity1);
genRepo.GetById("asdahsfds");


Console.Read();