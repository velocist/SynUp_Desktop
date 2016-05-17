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
        /// Method that creates a employee given it's atributes
        /// </summary>
        /// <param name="nif">Employee nif</param>
        /// <param name="name">Employee name</param>
        /// <param name="surname">Employee surname</param>
        /// <param name="phone">Employee phone</param>
        /// <param name="email">Employee email</param>
        /// <param name="adress">Employee adress</param>
        /// <returns>Whether if the employee has been correctly created or not</returns>
        public bool createEmployee(String pNif, String pName, String pSurname, String pPhone, String pEmail, String pAdress)
        {
            Employee newEmployee = new Employee
            {
                nif = pNif,
                name = pName,
                surname = pSurname,
                phone = pPhone,
                email = pEmail,
                adress = pAdress
            };

            return EmployeeConnection.createEmployee(newEmployee);
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
        public bool updateEmployee(String pNif, String pName, String pSurname, String pPhone, String pEmail, String pAdress)
        {
            Employee newEmployee = new Employee
            {
                nif = pNif,
                name = pName,
                surname = pSurname,
                phone = pPhone,
                email = pEmail,
                adress = pAdress
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
            return this.returnWithoutSpaces(EmployeeConnection.readEmployee(pCode)); ;
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
            List<Employee> _lstEmployee = EmployeeConnection.readAllEmployees();
            foreach (Employee _oEmployeeItem in _lstEmployee)
            {
                this.returnWithoutSpaces(_oEmployeeItem);
            }
            return _lstEmployee;
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

        /// <summary>
        /// Method that returns the strings without spaces
        /// </summary>
        /// <param name="pEmployee">The object Employee we want to remove the spaces</param>
        /// <returns>Returns de object Employee</returns>
        private Employee returnWithoutSpaces(Employee pEmployee)
        {
            if (pEmployee != null)
            {
                if (pEmployee.nif != null) pEmployee.nif = pEmployee.nif.Trim();
                if (pEmployee.name != null) pEmployee.name = pEmployee.name.Trim();
                if (pEmployee.surname != null) pEmployee.surname = pEmployee.surname.Trim();
                if (pEmployee.phone != null) pEmployee.phone = pEmployee.phone.Trim();
                if (pEmployee.email != null) pEmployee.email = pEmployee.email.Trim();
                if (pEmployee.adress != null) pEmployee.adress = pEmployee.adress.Trim();
            }
            return pEmployee;
        }
    }
}
