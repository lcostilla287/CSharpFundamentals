using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : Ifruit
    {
        //constructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name  //prop
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled { get; private set; } //prop

        public string Peel() //class method
        {
            IsPeeled = true;
            return "You peeled the banana";
        }
    }

    public class Orange : Ifruit
    {
        //Constructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        //use the same interface method but bodies can diff as long as return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "you peeled the orange";
            }
        }

        //classes that use interfaces can still have unique properties and methods.
        public string Squeeze()
        {
            return "You squeeze the orange, and juice comes out";
        }
    }

    public class Grape : Ifruit
    {
        public string Name
        {
            get
            {
                return "Grape";
            }
        }

        //Hardsetting property as false,  why would you peel a grape?
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "Who peels grapes?";
        }
    }

    //Make apple class inheriting from Ifruit challenge

    public class Apple : Ifruit
    {
        public string Name // can put => "Apple"; called a lambda function. shorthand and write the below code in one line
        {
            get
            {
                return "Apple";
            }
        }

        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            return "I prefer my apples not to be peeled";
        }
        public bool IsSliced { get; private set; }

        public string Sliced()
        {
            if (IsSliced)
            {
                return "The apple is already sliced";
            }
            else
            {
                IsSliced = true;
                return "You sliced the apple";
            }
        }
    }
}
