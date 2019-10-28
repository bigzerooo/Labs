using System;
class Ferrari:ICar
{
    public string Model { get; set; }
    public string DriversName { get; set; }
    public void Brakes() => Console.Write("Brakes!");
    public void GasPedal() => Console.Write("Zadu6avam sA!");
    public void Info()
    {
        Console.Write(Model);
        Console.Write("/");
        Brakes();
        Console.Write("/");
        GasPedal();
        Console.Write("/");
        Console.WriteLine(DriversName);

    }    
    public Ferrari(string model,string driversName)
    {
        Model = model;
        DriversName = driversName;
    }
    public Ferrari(string driversName) : this("488-Spider", driversName)
    {

    }

}