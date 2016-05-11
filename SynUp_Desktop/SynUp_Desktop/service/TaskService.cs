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
    /// 
    /// </summary>
    public class TaskService
    {
        /// <summary>
        /// Creates a task given it's atributes.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="priorityDate"></param>
        /// <param name="description"></param>
        /// <param name="localization"></param>
        /// <param name="project"></param>
        /// <author>Pablo A.</author>
        /// <returns>Whether if the task has been correctly created or not</returns>
        public bool createTask(String code, String name, DateTime priorityDate, String description, String localization, String project, String team)
        {
            Task newTask = new Task
            {
                code = code,
                id_team = team,
                name = name,
                priorityDate = priorityDate,
                description = description,
                localization = localization,
                project = project
            };
            

            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(name) && priorityDate != null)
            {
                return TaskConnection.createTask(newTask);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Updates a task.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="priorityDate"></param>
        /// <param name="description"></param>
        /// <param name="localization"></param>
        /// <param name="project"></param>
        /// <returns>Whether if the task has been correctly updated or not</returns>
        public bool updateTask(String code, String name, DateTime priorityDate, String description, String localization, String project, String team)
        {
            Task newTask = new Task
            {
                code = code,
                name = name,
                id_team = team,
                priorityDate = priorityDate,
                description = description,
                localization = localization,
                project = project
            };

            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(name) && priorityDate != null)
            {
                return TaskConnection.updateTask(newTask);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method that returns the Task if it found
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public Task readTask(String pCode)
        {
            return TaskConnection.readTask(pCode);
        }

        /// <summary>
        /// Method that returns a Task if it exists
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public Task deleteTask(Task pTask)
        {
            return TaskConnection.deleteTask(pTask);
        }

        public List<Task> getAllTasks()
        {
            return TaskConnection.readAllTasks();
        }

        //DELETE - Pablo Ardèvol - Method moved to the statistics service
        //public List<Task> getTasksByDate(DateTime begin, DateTime end)
        //{
        //    return TaskConnection.readTasksByDate(begin, end);
        //}
    }
}
