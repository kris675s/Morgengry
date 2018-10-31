﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
        private string name;
        private int durationInMinutes;
        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int DurationInMinutes
        {
            get => durationInMinutes;
            set { durationInMinutes = value; }
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        public Course(string name) : this (name, 0)
        {

        }

        public override string ToString()
        {
            return ("Name: " + name + ", Duration in Minutes: " + durationInMinutes);
        }
    }
}