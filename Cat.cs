using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
        public class Cat: Pet, ITalkable
        {
         private int mousesKilled;

        public Cat(int mousesKilled, String name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled()
        {
            return mousesKilled;
        }

        public void addMouse()
        {
            mousesKilled++;
        }

    public string talk()
        {
            return "Meow";
        }
    public string toString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }

}
