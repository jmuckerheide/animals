using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Pet, ITalkable
    {
    private bool friendly;

    public Dog(bool friendly, String name) : base(name)
        {
        this.friendly = friendly;
    }

    public bool isFriendly()
    {
        return friendly;
    }

   
    public string talk()
    {
        return "Bark";
    }

    
    public string toString()
    {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }


}
}
