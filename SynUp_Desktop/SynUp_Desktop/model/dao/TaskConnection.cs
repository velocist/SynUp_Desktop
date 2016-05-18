using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model;
using SynUp_Desktop.model.pojo;
using System.Diagnostics;

namespace SynUp_Desktop.model.dao
{
    ///<summary>
    ///Data Access Object Class that will access the database and interact directly with it. 
    ///</summary>
    ///<Author>Pablo Ardèvol</Author>
    ///<Version>0.01</Version>
    ///<Date>04/05/2016_1713</Date>
    public static class TaskConnection
    {
        

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges()
        {
            try
            {
                //database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

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
        /// Creates a given task.
        /// </summary>
        /// <param name="t">Receives the object Task that will be inserted in the database</param>
        /// <returns>Returns a boolean depending in the outcome of the insert - true if it is successfull</returns>
        public static bool createTask(pojo.Task t)
        {
            pojo.Task foundTask = readTask(t.code); //Finds the received task in the database.

            if (foundTask == null)
            {
                //database.Tasks.Add(t); //If the task doesn't exist already in the database, it will be inserted.
                using (var context = new synupEntities())
                {
                    context.Tasks.Add(t);
                    return commitChanges(context);
                }
            }

            return false;
        }

        /// <summary>
        /// Deletes a given task.
        /// </summary>
        /// <param name="t">Receives the task that is meant to be deleted.</param>
        /// <returns>Returns the task that has been deleted.</returns>
        public static pojo.Task deleteTask(pojo.Task t)
        {
            using (var context = new synupEntities())
            {
                pojo.Task foundTask = readTask(t.code, context); //Finds the received task in the database.

                if (foundTask != null) //If the task has been found - meaning that it exists:
                {
                    tryAttach(context, foundTask);

                    context.Tasks.Remove(foundTask);
                    if (commitChanges(context)) return foundTask;
                    else return null;
                }
            }

            return null;
        }

        private static void tryAttach(synupEntities _context, pojo.Task _task)
        {
            var entry = _context.Entry(_task);
            if (entry.State == System.Data.Entity.EntityState.Detached) _context.Tasks.Attach(_task);
        }

        /// <summary>
        /// Updates a given task with the new parameters of it.
        /// </summary>
        /// <param name="t">Receives the task that will be updated.</param>
        /// <returns>Returns a boolean whether the task has been updated succesfully or not.</returns>
        public static bool updateTask(pojo.Task t)
        {
            using (var context = new synupEntities())
            {
                pojo.Task modifiedTask = readTask(t.code, context);

                if (modifiedTask != null)
                {
                    //tryAttach(context, modifiedTask);
                    //modifiedTask.code = t.code;
                    modifiedTask.description = t.description;
                    modifiedTask.id_team = t.id_team;
                    modifiedTask.localization = t.localization;
                    modifiedTask.name = t.name;
                    modifiedTask.priorityDate = t.priorityDate;
                    modifiedTask.project = t.project;

                    return commitChanges(context);
                }
            }

            return false;
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="code">Code key of the task.</param>
        /// <returns>If the code is already on the database it will return the Task, otherwise it will return a null.</returns>
        public static pojo.Task readTask(String code)
        {
            var query = from task in new synupEntities().Tasks
                        where task.code == code
                        select task;

            return query.SingleOrDefault();
        }

        public static pojo.Task readTask(String code, synupEntities database)
        {
            var query = from task in database.Tasks
                        where task.code == code
                        select task;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<pojo.Task> readAllTasks()
        {

            return (from task in new synupEntities().Tasks select task).ToList();
        }

        //DELETE - Pablo Ardèvol 11/5/16 - Method moved to the Statistics connection object.
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="_date"></param>
        ///// <returns></returns>
        //public static List<pojo.Task> readTasksByDate(DateTime _dateStartPeriod, DateTime _dateFinishPeriod)
        //{
        //    ///Check from TaskHistory the tasks that are active given the period of time. 
        //    ///The tasks can't be finished in the given period.
        //    return database.spGetByDate(_dateStartPeriod, _dateFinishPeriod).ToList();
        //}



    }
}
