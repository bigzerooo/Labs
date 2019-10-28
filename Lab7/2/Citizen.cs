using System;
class Citizen:IPerson,IIdentifiable, IBirthable
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }
    public string Birthdate { get; set; }
    public Citizen(string name,int age,string id, string birthdate)
    {
        Name = name;
        Age = age;
        ID = id;
        Birthdate = birthdate;
    }
}
