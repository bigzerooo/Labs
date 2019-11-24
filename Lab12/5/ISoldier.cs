using System;
using System.Collections.Generic;
using System.Text;
public delegate void MyKingAttackedEventHandler(object sender);
public delegate void DiedEventHandler(ISoldier sender);
public interface ISoldier
{
    string Name { get; set; }
    event MyKingAttackedEventHandler MyKingAttacked;
    event DiedEventHandler Died;
    void KingAttacked();
    void TryKill();
    void Die();
    int HP { get; set; }

}

