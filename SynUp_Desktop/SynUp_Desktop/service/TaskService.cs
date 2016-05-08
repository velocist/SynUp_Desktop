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
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="priorityDate"></param>
        /// <param name="description"></param>
        /// <param name="localization"></param>
        /// <param name="project"></param>
        public static bool createTask(String code, String name, DateTime priorityDate, String description, String localization, String project)
        {
            Task newTask = new Task
            {
                code = code,
                name = name,
                priorityDate = priorityDate,
                description = description,
                localization = localization,
                project = project
            };

            return TaskConnection.createTask(newTask);
        }

        /// <summary>
        /// Method that returns the Task if it found
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public static Task readTask(String pCode)
        {
            return TaskConnection.readTask(pCode);
        }

        /// <summary>
        /// Method that returns a Task if it exists
        /// </summary>
        /// <param name="pCode"></param>
        /// <returns></returns>
        public static Task deleteTask(Task pTask)
        {
            return TaskConnection.deleteTask(pTask);
        }

        public List<Task> getAllTasks()
        {
            return TaskConnection.readAllTasks();
        }

        /// <summary>
        /// Method that returns a boolean if the task is updated
        /// </summary>
        /// <param name="pTask"></param>
        /// <returns></returns>
        public static bool updateTask(Task pTask)
        {
            return TaskConnection.updateTask(pTask);
        }
    }
}
