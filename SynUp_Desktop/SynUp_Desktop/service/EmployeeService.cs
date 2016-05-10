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

        private Employee returnWithoutSpaces(Employee pEmployee)
        {            
            if (pEmployee != null)
            {
                pEmployee.nif = pEmployee.nif.Trim();
                    pEmployee.name = pEmployee.name.Trim();
                pEmployee.surname = pEmployee.surname.Trim();
                pEmployee.phone = pEmployee.phone.Trim();
                pEmployee.email = pEmployee.email.Trim();
                pEmployee.adress = pEmployee.adress.Trim();               
            }
            return pEmployee;
        }
    }
}
