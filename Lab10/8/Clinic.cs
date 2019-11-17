using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _8
{
    class Clinic
    {
        string _name;
        public List<Room> Rooms;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool good = true;
                for (int i = 0; i < value.Length; i++)
                    if (char.IsLetter(value[i]) == false)
                    {
                        good = false;
                        break;
                    }
                if (value.Length < 1 || value.Length > 50)
                    good = false;
                if (good)
                    _name = value;
                else
                    throw new Exception("Invalid Name!");
            }
        }
        public Clinic(string name,int roomNumber)
        {
            if (roomNumber % 2 == 1)
            {
                Name = name;
                Rooms = new List<Room>();
                for (int i = 1; i <= roomNumber; i++)
                {
                    Room t = new Room(i);
                    Rooms.Add(t);
                }
            }
            else
                throw new Exception("Invalid room number! Must be odd.");                            
        }
        public IEnumerable Enumerator1()
        {
            int c = Rooms.Count / 2;
            for(int i = 0; i <=c;i++)
            {
                if(i==0)
                yield return Rooms[c];
                else
                {
                    yield return Rooms[c-i];
                    yield return Rooms[c + i];
                }

            }

        }
        public IEnumerable Enumerator2()
        {
            int c = Rooms.Count / 2;
            for (int i = c; i < Rooms.Count; i++)
                yield return Rooms[i];
            for (int i = 0; i < c; i++)
                yield return Rooms[i];
        }
        public bool Add(Pet pet)
        {
            bool added = false;
            foreach(Room room in Enumerator1())
            {
                if (room.IsEmpty())
                { 
                    room.Add(pet);
                    added = true;
                    break;
                }
            }
            return added;
        }
        public void Print()
        {
            foreach(Room room in Rooms)
            {
                room.Print();
            }
        }
        public bool Release()
        {
            bool released = false;
            foreach(Room room in Enumerator2())
            {
                if (room.IsEmpty() == false)
                { 
                    room.Remove();
                    released = true;
                    break;  
                }
            }
            return released;
        }
        public bool HasEmptyRooms()
        {
            bool empty = false;
            foreach(Room room in Rooms)
                if(room.IsEmpty())
                {
                    empty = true;
                    break;
                }
            return empty;
        }
    }
    
}
