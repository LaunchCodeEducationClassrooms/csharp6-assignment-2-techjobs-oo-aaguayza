﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public abstract class JobField
    {
        public string Value { get; set; }
        public int Id { get; }
        private static int nextId = 1;
        public JobField() {
                Id = nextId;
                nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
