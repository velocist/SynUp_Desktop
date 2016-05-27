using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model.pojo;
using System.Diagnostics;
using System.Security.Cryptography;
using SynUp_Desktop.utilities;

namespace SynUp_Desktop.model.dao
{
    public static class EmployeeConnection
    {
        //private static synupEntities database = new synupEntities();

        /* DELETED METHOD - No used.
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
        */

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges(synupEntities _database)
        {
            //The saveChanges will be called under a trycatch instruction. If the command is completed succesfully it will return a true.
            try
            {
                _database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                //We write the error in the Debug window of the system console.
                Debug.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Inserts in the database the given employee by parameter. Checks if the employee already exists.
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
        /// Given the code, it is searched in the database and will return the first employee found with the given code.
        /// </summary>
        /// <param name="pNif">Nif, Code key of the employee</param>
        /// <param name="_database">Context of the connection</param>
        /// <returns>If the code is already on the database it will return the Employee, otherwise it will return a null.</returns>
        public static pojo.Employee readEmployee(String _pNif, synupEntities _database)
        {
            var query = from employee in _database.Employees
                        where employee.nif == _pNif
                        select employee;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first employee found with the given code. 
        /// </summary>
        /// <param name="_pNif">Nif, Code key of the employee</param>
        /// <returns>If the code is already on the database it will return the Employee, otherwise it will return a null.</returns>
        public static pojo.Employee readEmployee(String _pNif)
        {
            var query = from employee in new synupEntities().Employees
                        where employee.nif == _pNif
                        select employee;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Receives the employee that is meant to be updated and updates it.
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
        /// Deletes a given employee if it is found in the database. It will leave all the tasks given to it as ABANDONED.
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
                    if (checkRelations(_oEmployee)) //Checks the employee foreign keys and performs an update. If the update is succesfull it will step in the next code block.
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
        /// Retrieves all the employees of the database.
        /// </summary>
        /// <returns>List of all the employees found.</returns>
        public static List<pojo.Employee> readAllEmployees()
        {
            return (from employee in new synupEntities().Employees select employee).ToList();
        }

        /// <summary>
        /// Checks the Employee foreign keys and performs an update on their values.
        /// </summary>
        /// <param name="_employee">The employee object we want to check</param>
        /// <returns>Returns a boolean with the outcome of the update operation</returns>
        public static bool checkRelations(Employee _employee)
        {
            using (var context = new synupEntities())
            {
                //Finds all the Teams the employee is in.
                var query = from th in context.TeamHistories
                            where th.id_employee.Equals(_employee.nif)
                            select th;

                //Deletes all the relations with teams the employee might have.
                foreach (var member in query)
                {
                    if (TeamHistoryConnection.deleteTeamHistory(member.id_employee, member.id_team) == null) return false;
                }

                //Finds all the tasks the employee has been given.
                //If the task is not finished, it will be abandonned. If the task is ongoing, it will be abandonned and therefore given a finishdate.
                var query2 = from th in context.TaskHistories
                            where th.id_employee.Equals(_employee.nif) && (th.isFinished == 0 || th.finishDate == null)
                            select th;

                //For each TaskHistories register found.
                foreach(var q in query2)
                {
                    //It will find the tasks tied to it.
                    var qu = from task in context.Tasks
                             where task.code.Equals(q.id_task)
                             select task;

                    //Will update the state of the found tasks to ABANDONNED.
                    foreach (var ta in qu)
                    {
                        ta.state = (int)TaskState.ABANDONED;
                        TaskConnection.updateTask(ta);
                    }

                    //Will set the finish date to todays date.
                    q.finishDate = DateTime.Now;

                                       
                }

                //Returns whether the update has been done sucesfully or not.
                return commitChanges(context);
            }
        }

        /// <summary>
        /// Attachs employees to the current session so it can be updated.
        /// </summary>
        /// <param name="pContext">The session the operation will be performed under.</param>
        /// <param name="pEmployee">The object which were attachs</param>
        private static void tryAttach(synupEntities pContext, pojo.Employee pEmployee)
        {
            var entry = pContext.Entry(pEmployee);
            if (entry.State == System.Data.Entity.EntityState.Detached) pContext.Employees.Attach(pEmployee);
        }

        /// <summary>
        /// MD5 Encryptation. Given the string it will be encripted using the MD5 Hash and returned as an ecnrypted String.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
