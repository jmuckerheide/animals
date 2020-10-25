using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Pet
    {
        protected String name;

        public Pet(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
    }
}
