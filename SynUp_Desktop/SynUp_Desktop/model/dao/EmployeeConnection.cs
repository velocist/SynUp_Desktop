﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model.pojo;
using System.Diagnostics;
using System.Security.Cryptography;

namespace SynUp_Desktop.model.dao
{
    public static class EmployeeConnection
    {
        //private static synupEntities database = new synupEntities();

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges()
        {
            try
            {
                new synupEntities().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges(synupEntities _database)
        {
            try
            {
                _database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
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

            if (_oEmployee == null)
            {
                using (var context = new synupEntities())
                {
                    pEmployee.password = MD5Hash(pEmployee.password);

                    context.Employees.Add(pEmployee); //If the employee doesn't exist already in the database, it will be inserted.
                    return commitChanges(context);
                }

            }

            return false;
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="pNif">Code key of the employee</param>
        /// <returns>If the code is already on the database it will return the Employee, otherwise it will return a null.</returns>
        public static pojo.Employee readEmployee(String _pNif, synupEntities _database)
        {
            var query = from employee in _database.Employees
                        where employee.nif == _pNif
                        select employee;

            return query.SingleOrDefault();
        }

        public static pojo.Employee readEmployee(String _pNif)
        {
            var query = from employee in new synupEntities().Employees
                        where employee.nif == _pNif
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
            using (var context = new synupEntities())
            {
                pojo.Employee _oEmployee = readEmployee(pEmployee.nif, context);

                if (_oEmployee != null)
                {
                    _oEmployee.name = pEmployee.name;
                    _oEmployee.surname = pEmployee.surname;
                    _oEmployee.phone = pEmployee.phone;
                    _oEmployee.email = pEmployee.email;
                    _oEmployee.adress = pEmployee.adress;
                    _oEmployee.username = pEmployee.username;
                    _oEmployee.password = _oEmployee.password;

                    return commitChanges(context);
                }
            }

            return false;
        }

        /// <summary>
        /// Deletes a given employee.
        /// </summary>
        /// <param name="pEmployee">Receives the employee that is meant to be deleted</param>
        /// <returns></returns>
        public static pojo.Employee deleteEmployee(pojo.Employee pEmployee)
        {
            using (var context = new synupEntities())
            {
                pojo.Employee _oEmployee = readEmployee(pEmployee.nif, context); //Finds the received employee in the database.

                if (_oEmployee != null) //If the employee has been found - meaning that it exists:
                {
                    if (checkRelations(_oEmployee))
                    {
                        tryAttach(context, _oEmployee);
                        context.Employees.Remove(_oEmployee); //Will be deleted.
                        if (commitChanges(context)) return _oEmployee; //If the changes are commited succesfully it will return the deleted Employee.
                        else return null;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<pojo.Employee> readAllEmployees()
        {
            return (from employee in new synupEntities().Employees select employee).ToList();
        }


        public static bool checkRelations(Employee _employee)
        {
            using (var context = new synupEntities())
            {
                var query = from th in context.TeamHistories
                            where th.id_employee.Equals(_employee.nif)
                            select th;

                foreach (var member in query)
                {
                    if (TeamHistoryConnection.deleteTeamHistory(member.id_employee, member.id_team) == null) return false;
                }

                return commitChanges(context);
            }
        }

        /// <summary>
        /// Attachs employees
        /// </summary>
        /// <param name="pContext"></param>
        /// <param name="pEmployee">The object which were attachs</param>
        private static void tryAttach(synupEntities pContext, pojo.Employee pEmployee)
        {
            var entry = pContext.Entry(pEmployee);
            if (entry.State == System.Data.Entity.EntityState.Detached) pContext.Employees.Attach(pEmployee);
        }

        public static string MD5Hash(string text)
        {
            MD5 _md5 = new MD5CryptoServiceProvider();
            byte[] result;

            _md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(text));
            result = _md5.Hash;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }
            return sb.ToString();
        }

    }
}
