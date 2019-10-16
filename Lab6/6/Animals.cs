using System;
abstract class Animal
{
    string name;
    int age;
    string gender;
    string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == "" || value == " ")
                throw new Exception("Invalid input");
            else
                name = value;
        }
    }
    int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value>0)
                age = value;            
            else
                throw new Exception("Invalid input!");
        }
    }
    string Gender
    {
        get
        {
            return gender;
        }
        set
        {
            if (value == "" || value == " ")
                throw new Exception("Invalid input!");
            else
                gender = value;
        }
    }
    public virtual void ProduceSound()
    {
        Console.WriteLine("Sound!");
    }
    public void Display()
    {
        Console.WriteLine(this.GetType().Name);
        Console.WriteLine($"{Name} {Age} {Gender}");
        ProduceSound();
    }
    public Animal(string name,int age,string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
    
}
class Dog:Animal
{
    public Dog(string name,int age,string gender) : base(name, age, gender)
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
}
class Frog : Animal
{
    public Frog(string name,int age,string gender):base(name, age, gender)
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("Ribbit!");
    }
}
class Cat : Animal
{
    public Cat(string name,int age,string gender) : base(name, age, gender)
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("Meow meow");
    }
}
class Kitten:Cat
{
    public Kitten(string name,int age) : base(name, age, "Female")
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
}
class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age, "Male")
    {

    }
    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}