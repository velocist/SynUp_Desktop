using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynUp_Desktop.model;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.model.dao;

namespace SynUp_Desktop.service
{
    /// <summary>
    /// The class TaskService
    /// </summary>
    /// <CreationDate>07/05/2016</Creation>
    public class TaskService
    {
        /// <summary>
        /// Creates a task given it's atributes.
        /// </summary>
        /// <param name="code">The code task to create</param>
        /// <param name="name">The name task to create</param>
        /// <param name="priorityDate">The priority date task to create</param>
        /// <param name="description">The description task to create</param>
        /// <param name="localization">The localization task to create</param>
        /// <param name="project">The project name task to create</param>
        /// <author>Pablo A.</author>
        /// <returns>Whether if the task has been correctly created or not</returns>
        public bool createTask(String code, String name, DateTime priorityDate, String description, String localization, String project, String team, int importance)
        {
            Task newTask = new Task
            {
                code = code.Trim(),
                id_team = team,
                name = name.Trim(),
                priorityDate = priorityDate,
                description = description.Trim(),
                localization = localization.Trim(),
                project = project.Trim(),
                priority = importance,
                state = 0
            };
            return TaskConnection.createTask(newTask);
        }

        /// <summary>
        /// Updates a task.
        /// </summary>
        /// <param name="code">The code task to update</param>
        /// <param name="name">The name task to update</param>
        /// <param name="priorityDate">The priority date task to update</param>
        /// <param name="description">The description task to update</param>
        /// <param name="localization">The localization task to update</param>
        /// <param name="project">The project name task to update</param>
        /// <returns>Whether if the task has been correctly updated or not</returns>
        public bool updateTask(String code, String name, DateTime priorityDate, String description, String localization, String project, String team, int importance)
        {
            Task newTask = new Task
            {
                code = code,
                name = name,
                id_team = team,
                priorityDate = priorityDate,
                description = description,
                localization = localization,
                project = project,
                priority = importance
            };

            return TaskConnection.updateTask(newTask);
        }

        /// <summary>
        /// Method that returns the Task if it found
        /// </summary>
        /// <param name="pCode">The code task to search</param>
        /// <returns>Returns the Task if it found</returns>
        public Task readTask(String pCode)
        {
            Task tReturn = TaskConnection.readTask(pCode);
            return returnWithoutSpaces(tReturn);
        }

        /// <summary>
        /// Method that deletes a Task if it exists
        /// </summary>
        /// <param name="pCode">The code task to search</param>
        /// <returns>Returns the Task if it has been remove</returns>
        public Task deleteTask(Task pTask)
        {
            return TaskConnection.deleteTask(pTask);
        }

        /// <summary>
        /// Method that returns all Tasks 
        /// </summary>
        /// <returns>Return a list of Tasks</returns>
        public List<Task> getAllTasks()
        {
            List<Task> taskList = TaskConnection.readAllTasks();
            foreach (Task _t in taskList)
            {
                returnWithoutSpaces(_t);
            }
            return taskList;
        }

        //DELETE - Pablo Ardèvol - Method moved to the statistics service
        //public List<Task> getTasksByDate(DateTime begin, DateTime end)
        //{
        //    return TaskConnection.readTasksByDate(begin, end);
        //}

        /// <summary>
        /// Method that returns the strings without spaces
        /// </summary>
        /// <param name="pTask">The object Task we want to remove the spaces</param>
        /// <returns>Returns the object Task</returns>
        private Task returnWithoutSpaces(Task pTask)
        {
            if (pTask != null)
            {
                if (pTask.code != null) pTask.code = pTask.code.Trim();
                if (pTask.name != null) pTask.name = pTask.name.Trim();
                if (pTask.description != null) pTask.description = pTask.description.Trim();
                if (pTask.id_team != null) pTask.id_team = pTask.id_team.Trim();
                if (pTask.localization != null) pTask.localization = pTask.localization.Trim();
                if (pTask.project != null) pTask.project = pTask.project.Trim();
            }
            return pTask;
        }
    }
}
