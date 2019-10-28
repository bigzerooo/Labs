using System;
interface IIdentificable
{
    string ID { get; set; }
    bool Check(string lastDigits);
}