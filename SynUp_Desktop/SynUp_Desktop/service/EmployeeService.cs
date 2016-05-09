using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.model.dao;

namespace SynUp_Desktop.service
{
    public class EmployeeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="adress"></param>
        /// <returns></returns>
        public bool createEmployee(String nif, String name, String surname, String phone, String email, String adress)
        {

            Employee newEmployee = new Employee
            {
                nif = nif,
                name = name,
                surname = surname,
                phone = phone,
                email = email,
                adress = adress
            };

            return false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="adress"></param>
        /// <returns></returns>
        public bool updateEmployee(String nif, String name, String surname, String phone, String email, String adress)
        {
            Employee newEmployee = new Employee
            {
                nif = nif,
                name = name,
                surname = surname,
                phone = phone,
                email = email,
                adress = adress
            };

            return EmployeeConnection.updateEmployee(newEmployee);
        }

        /// <summary>
        /// Method that returns the Employee if it found
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public Employee readEmployee(String pCode)
        {
            return EmployeeConnection.readEmployee(pCode);
        }

        /// <summary>
        /// Method that returns a Employee if it exists
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public Employee deleteEmployee(Employee pEmployee)
        {
            return EmployeeConnection.deleteEmployee(pEmployee);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Employee> getAllEmployees()
        {
            return EmployeeConnection.readAllEmployees();
        }

        /// <summary>
        /// Method that returns a boolean if the employee is updated
        /// </summary>
        /// <param name="pEmployee"></param>
        /// <returns></returns>
        public bool updateEmployee(Employee pEmployee)
        {
            return EmployeeConnection.updateEmployee(pEmployee);
        }
    }
}
