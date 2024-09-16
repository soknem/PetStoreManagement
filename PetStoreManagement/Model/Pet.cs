﻿namespace PetStoreManagement.Model
{
    internal class Pet
    {

        //just sample
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
