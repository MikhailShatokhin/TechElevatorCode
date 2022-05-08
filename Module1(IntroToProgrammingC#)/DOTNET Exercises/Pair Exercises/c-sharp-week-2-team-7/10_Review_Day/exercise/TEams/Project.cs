﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Project
    { //Proprties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public List<Employee> TeamMembers { get; set; } = new List<Employee>();

        //Constructor
        public Project (string name, string description, DateTime startDate, DateTime dueDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            DueDate = dueDate;

        }
    }
}
