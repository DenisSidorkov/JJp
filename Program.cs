using System;

namespace ConsoleApp1
{
  public class Person
  {
    public string first_name, second_name;
    public int age;
    public bool sex;

    public void Read(){
      Console.Write("First name: ");
      this.first_name = Console.ReadLine();
      Console.Write("Second name: ");
      this.second_name = Console.ReadLine();

      Console.Write("Age: ");
      this.age = Int32.Parse(Console.ReadLine());
      Console.Write("Sex?:");
      this.sex = bool.Parse(Console.ReadLine());
    }

    public void Print(){
      Console.WriteLine("First name: {0} ", this.first_name);
      Console.WriteLine("Second name: {0} ", this.second_name);
      Console.WriteLine("Age: {0} ", this.age);
      Console.WriteLine("Sex: {0} ", this.sex);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person();

      p.Read();
      p.Print();
    }
  }
}
