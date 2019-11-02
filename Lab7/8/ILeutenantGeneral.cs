using System;
using System.Collections.Generic;
interface ILeutenantGeneral:IPrivate
{
    List<Private> SetOfPrivates { get; set; }//Неправильно
}