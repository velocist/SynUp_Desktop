using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model;
using SynUp_Desktop.model.pojo;

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
        /// Creates a given task.
        /// </summary>
        /// <param name="t">Receives the object Task that will be inserted in the database</param>
        /// <returns>Returns a boolean depending in the outcome of the insert - true if it is successfull</returns>
        public static bool createTask(pojo.Task t)
        {
            pojo.Task foundTask = readTask(t.code); //Finds the received task in the database.

            if (foundTask == null) database.Tasks.Add(t); //If the task doesn't exist already in the database, it will be inserted.

            return commitChanges();
        }

        /// <summary>
        /// Deletes a given task.
        /// </summary>
        /// <param name="t">Receives the task that is meant to be deleted.</param>
        /// <returns>Returns the task that has been deleted.</returns>
        public static pojo.Task deleteTask(pojo.Task t)
        {
            pojo.Task foundTask = readTask(t.code); //Finds the received task in the database.

            if (foundTask != null) //If the task has been found - meaning that it exists:
            {
                database.Tasks.Remove(foundTask); //Will be deleted.
            }

            if (commitChanges()) return foundTask; //If the changes are commited succesfully it will return the deleted Task.
            else return null;
        }

        /// <summary>
        /// Updates a given task with the new parameters of it.
        /// </summary>
        /// <param name="t">Receives the task that will be updated.</param>
        /// <returns>Returns a boolean whether the task has been updated succesfully or not.</returns>
        public static bool updateTask(pojo.Task t)
        {
            pojo.Task modifiedTask;

            modifiedTask = readTask(t.code);

            modifiedTask.code = t.code;
            modifiedTask.description = t.description;
            modifiedTask.id_team = t.id_team;
            modifiedTask.localization = t.localization;
            modifiedTask.name = t.name;
            modifiedTask.priorityDate = t.priorityDate;
            modifiedTask.project = t.project;

            return commitChanges();
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="code">Code key of the task.</param>
        /// <returns>If the code is already on the database it will return the Task, otherwise it will return a null.</returns>
        public static pojo.Task readTask(String code)
        {
            var query = from task in database.Tasks
                        where task.code == code
                        select task;

            return query.SingleOrDefault();
        }

        public static List<pojo.Task> readAllTasks()
        {
            return (from task in database.Tasks select task).ToList();
        }



    }
}
