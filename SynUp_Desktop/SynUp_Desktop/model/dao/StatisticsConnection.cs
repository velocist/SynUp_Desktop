using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.model.dao
{
    /// <summary>
    /// Connection for the statistics form. 
    /// All the methods will retrieve data from the database given the filters in the view.
    /// </summary>
    /// <author></author>
    class StatisticsConnection
    {
        private static synupEntities database = new synupEntities();

        public static List<pojo.Task> readTasksByDate(DateTime _dateStartPeriod, DateTime _dateFinishPeriod)
        {
            ///Check from TaskHistory the tasks that are active given the period of time. 
            ///The tasks can't be finished in the given period.
            return database.spGetByDate(_dateStartPeriod, _dateFinishPeriod).ToList();
        }

        public static List<pojo.spGetRankingTeam_Result> readRankingTeams(DateTime _dateStartPeriod, DateTime _dateFinishPeriod)
        {
            return database.spGetRankingTeam(_dateStartPeriod, _dateFinishPeriod).ToList();
        }

        public static List<pojo.spGetRankingEmployee_Result> readRankingEmployee(DateTime _dateStartPeriod, DateTime _dateFinishPeriod)
        {
            return database.spGetRankingEmployee(_dateStartPeriod, _dateFinishPeriod).ToList();
        }

        public static List<pojo.Task> readTasksByEmployee(String _nif)
        {
            //pojo.Employee empFound = EmployeeConnection.readEmployee(_nif);

            //Returns all the tasks an employee has had. 
            var query = from record in database.TaskHistories
                        join task in database.Tasks on record.id_task equals task.code
                        where record.id_employee.Equals(_nif)
                        select task;

            return query.ToList();
        }

        public static List<pojo.Task> readTasksByTeam(String _code)
        {
            var query = from  task in database.Tasks
                        where task.id_team.Equals(_code) 
                        select task;
            return query.ToList();
        }

        public static List<pojo.Task> readUnselectedTasks()
        {
            var query = from task in database.Tasks
                        join th in database.TaskHistories on task.code equals th.id_task
                        where th.startDate == null
                        select task;
            return query.ToList();
        }

        public static List<pojo.Task> readOngoingTasks()
        {
            var query = from task in database.Tasks
                        join th in database.TaskHistories on task.code equals th.id_task
                        where th.startDate != null && th.isFinished != 0
                        select task;
            return query.ToList();
        }

        public static List<pojo.Task> readFinishedTasks()
        {
            var query = from task in database.Tasks
                        join th in database.TaskHistories on task.code equals th.id_task
                        where th.isFinished == 1
                        select task;
            return query.ToList();
        }

        public static List<pojo.Task> readAbandonnedTasks()
        {
            var query = from task in database.Tasks
                        join th in database.TaskHistories on task.code equals th.id_task
                        where th.finishDate != null && th.isFinished != 0
                        select task;
            return query.ToList();
        }



    }
}
