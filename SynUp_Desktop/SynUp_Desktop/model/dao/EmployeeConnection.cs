﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model.pojo;

namespace SynUp_Desktop.model.dao
{
    public static class EmployeeConnection
    {
        private static synupEntities database = new synupEntities();

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges()
        {
            try
            {
                database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates a given employee.
        /// </summary>
        /// <param name="pEmployee">Receives the object Employee that will be inserted in the database.</param>
        /// <returns>Returns a boolean depending in the outcome of the insert - true if it is successfull</returns>
        public static bool createEmployee(pojo.Employee pEmployee)
        {
            pojo.Employee _oEmployee = readEmployee(pEmployee.nif); //Finds the received employee in the database. 

            if (_oEmployee == null) database.Employees.Add(pEmployee); //If the employee doesn't exist already in the database, it will be inserted.

            return commitChanges();
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="pCode">Code key of the employee</param>
        /// <returns>If the code is already on the database it will return the Employee, otherwise it will return a null.</returns>
        public static pojo.Employee readEmployee(String pCode)
        {
            var query = from employee in database.Employees
                        where employee.nif == pCode
                        select employee;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Receives the employee that is meant to be updated
        /// </summary>
        /// <param name="pEmployee">Receives the employee that will be updated</param>
        /// <returns>Returns a boolean whether the employee has been updated succesfully or not.</returns>
        public static bool updateEmployee(pojo.Employee pEmployee)
        {
            pojo.Employee _oEmployee = readEmployee(pEmployee.nif);

            _oEmployee = pEmployee;

            return commitChanges();
        }

        /// <summary>
        /// Deletes a given employee.
        /// </summary>
        /// <param name="pEmployee">Receives the employee that is meant to be deleted</param>
        /// <returns></returns>
        public static pojo.Employee deleteEmployee(pojo.Employee pEmployee)
        {
            pojo.Employee _oEmployee = readEmployee(pEmployee.nif); //Finds the received employee in the database.

            if (_oEmployee != null) //If the employee has been found - meaning that it exists:
            {
                database.Employees.Remove(_oEmployee); //Will be deleted.
            }

            if (commitChanges()) return _oEmployee; //If the changes are commited succesfully it will return the deleted Team.
            else return null;
        }

        public static List<pojo.Employee> readAllEmployees()
        {
            return (from employee in database.Employees select employee).ToList();
        }

    }
}