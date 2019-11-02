using System;
using System.Collections.Generic;
interface IEngineer:ISpecialisedSoldier
{
    List<Repair> SetOfRepairs { get; set; }
}