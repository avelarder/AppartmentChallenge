using System;
using System.Collections.Generic;

namespace AppartmentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] req = { "gym", "school", "store" };

            BlockItem[] blocks = {
                new BlockItem { gym = false, school = true, store = false },
                new BlockItem { gym = true, school = false, store = false },
                new BlockItem { gym = true, school = true, store = false },
                new BlockItem { gym = false, school = true, store = false },
                new BlockItem { gym = false, school = true, store = true },
            };

            //Your Code here...
        }
    }



    public struct BlockItem
    {
        public bool gym;
        public bool school;
        public bool store;
    }
}

