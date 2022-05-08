using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee;", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> employeenames = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                
                if (firstNameSearch == "" && lastNameSearch == "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = CreateEmployeeFromReader(reader);
                        employeenames.Add(employee);
                    }
                }
                else if (firstNameSearch != "" && lastNameSearch == "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee " +
                                                    "WHERE (first_name = @first_name);", conn);


                    cmd.Parameters.AddWithValue("@first_name", firstNameSearch);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = CreateEmployeeFromReader(reader);
                        employeenames.Add(employee);
                    }
                }
                else if (firstNameSearch == "" && lastNameSearch != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee " +
                                                    "WHERE (last_name = @last_name);",conn);


                    cmd.Parameters.AddWithValue("@last_name", lastNameSearch);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = CreateEmployeeFromReader(reader);
                        employeenames.Add(employee);
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee " +
                                                                        "WHERE (first_name = @first_name AND last_name = @last_name) " +
                                                                        "OR (first_name LIKE '%' + @first_name + '%' AND last_name LIKE '%' + @last_name + '%');", conn);


                    cmd.Parameters.AddWithValue("@first_name", firstNameSearch);
                    cmd.Parameters.AddWithValue("@last_name", lastNameSearch);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = CreateEmployeeFromReader(reader);
                        employeenames.Add(employee);
                    }
                }
                return employeenames;

                //return new List<Employee>() { new Employee() };
            }
        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT e.employee_id, department_id, first_name, last_name, birth_date, hire_date FROM employee e " +
                                                "JOIN project_employee pe ON e.employee_id = pe.employee_id " +
                                                "WHERE project_id = @project_id;", conn);

                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }
            }
            return employees;
            //return new List<Employee>();
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO project_employee (project_id, employee_id) VALUES (@project_id, @employee_id);", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();
            }
        }

            public void RemoveEmployeeFromProject(int projectId, int employeeId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;", conn);
                    cmd.Parameters.AddWithValue("@project_id", projectId);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);

                    cmd.ExecuteNonQuery();
                }
            }

            public IList<Employee> GetEmployeesWithoutProjects()
            {
                IList<Employee> employees = new List<Employee>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT e.employee_id, department_id, first_name, last_name, birth_date, hire_date " +
                                                    "FROM employee e LEFT OUTER JOIN project_employee pe ON e.employee_id = pe.employee_id " +
                                                    "WHERE pe.project_id IS NULL;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = CreateEmployeeFromReader(reader);
                        employees.Add(employee);
                    }
                }
                return employees;
            }

            private Employee CreateEmployeeFromReader(SqlDataReader reader)
            {
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
                employee.FirstName = Convert.ToString(reader["first_name"]);
                employee.LastName = Convert.ToString(reader["last_name"]);
                employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

                return employee;
            }
        }
    }

