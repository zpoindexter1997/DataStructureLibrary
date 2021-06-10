using System;

namespace DataStructureLibrary
{
    //<T> to hold a generic data type (everything in this property will be this type)
    public class Item<T>
    {
        //Creating a property to hold the datatype (generic T)
        public T t { get; set; }
        //Next and Prev our default to -1 for when they aren't pointing to anything
        //Next will move the pointer forward in our array to the NEXT top of stack if there is a pull
        public int Next { get; set; } = -1;
        //Prev will move the pointer backwards in our array to the PREV top of stack if there is a pull
        public int Prev { get; set; } = -1;

        //this method sets our t class to the type entered into Item constructor
        //if we do Item(int 5), our t propery is set to the datatype of 5 (int)
        public Item (T t)
        {
            this.t = t;
        }
    }
}
