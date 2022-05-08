﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class UserInterface
    {
        //instance variable / class varaible
        public List<Department> departments = new List<Department>();

        public List<Employee> employees = new List<Employee>();

        public Dictionary<string, Project> projects = new Dictionary<string, Project>();

        public void Run()
        {
            // create some departments
            CreateDepartments();
            
            // print each department by name
            PrintDepartments();
            
            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
            int[] departmentId = { 1, 2, 3 };
            string[] name = { "Marketing", "Sales", "Engineering" };

            for (int i = 0; i < departmentId.Length; i++)
            {
                Department department = new Department(departmentId[i], name[i]);
                departments.Add(department);
            }
        }
        private Department GetDepartmentByName(string desiredDepartment)
        {
            Department result =null;
            foreach (Department d in departments)
            {
                if (desiredDepartment == d.Name)
                {
                    result = d;
                    break;
                }
                else { result=null; }
            } return result; 
        }  

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            for (int i=0; i<departments.Count; i++)
            {
                Console.WriteLine(departments[i].Name);
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {
            DateTime today = DateTime.Today;
            Employee employee1 = new Employee();
            employee1.FirstName = "Dean";
            employee1.LastName = "Johnson";
            employee1.Email = "djohnson@teams.com";
            employee1.Salary = 60000;
            employee1.Department = GetDepartmentByName("Engineering");
            employee1.HireDate = today;
            Employee employee2 = new Employee(2, "Angie", "Smith", "asmith@teams.com", GetDepartmentByName("Engineering"), today);
            Employee employee3 = new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", GetDepartmentByName("Marketing"), today);
            employee2.RaiseSalary(10);
            
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            for (int people = 0; people < employees.Count; people++)
            {
                Console.WriteLine(employees[people].FullName + " (" + employees[people].Salary.ToString("C2") +") " + employees[people].Department.Name);
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {
            Project project1 = new Project("TEams", "Project Management Software", DateTime.Today, DateTime.Today.AddDays(30));
            //project1.TeamMembers = employees;
            projects[project1.Name] = project1;
            foreach (Employee n in employees)
            {
                if (n.Department.Name == "Engineering")
                {
                    project1.TeamMembers.Add(n);
                    //return; this is what was causing out project employee count output to be wrong. Stops the loop right after the first employee
                }
            }
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {
            DateTime startDate = DateTime.Today.AddDays(31);
            Project project2 = new Project("Marketing Landing Page", "Lead Capture Landing Page For Marketing", startDate, startDate.AddDays(7));
           //project2.TeamMembers = employees;
           projects[project2.Name] = project2;
            foreach (Employee n in employees)
            {
                if (n.Department.Name == "Marketing")
                {
                    project2.TeamMembers.Add(n);
                    //return; this is what was causing out project employee count output to be wrong. Stops the loop right after the first employee
                }
            }
        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            foreach(Project p in projects.Values)
            { 
                Console.WriteLine($"{p.Name}: {p.TeamMembers.Count}");
            }
        }
    } 
}
