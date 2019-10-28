using System;
interface ICar
{
    string Model { get; set; }
    string DriversName { get; set; }
    void Brakes();
    void GasPedal();
}