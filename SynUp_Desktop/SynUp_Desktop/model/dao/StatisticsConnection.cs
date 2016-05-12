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
    class StatisticsConnection
    {
        private static synupEntities database = new synupEntities();

        public static List<pojo.Task> readTasksByDate(DateTime _dateStartPeriod, DateTime _dateFinishPeriod)
        {
            ///Check from TaskHistory the tasks that are active given the period of time. 
            ///The tasks can't be finished in the given period.
            return database.spGetByDate(_dateStartPeriod, _dateFinishPeriod).ToList();
        }

        public static List<pojo.Task> readTasksByEmployee(String _nif)
        {
            //pojo.Employee empFound = EmployeeConnection.readEmployee(_nif);

            //Returns all the tasks an employee has had. 
            var query = from record in database.TaskHistories
                        join task in database.Tasks on record.id_task equals task.code
                        where record.id_employee.Equals(_nif) && /*record.isFinished == 0 ||*/ record.finishDate == null
                        select task;

            return query.ToList();
        }

        public static List<pojo.Task> readTasksByTeam(String _code)
        {
            var query = from record in database.TaskHistories
                        join task in database.Tasks on record.id_task equals task.code
                        // --> THERE MUST BE ADDED A FIELD 'id_team' in the TaskHistory table to know in which team was an employee when the task was being done.
                        //where record.id_employee.Equals(_code) && /*record.isFinished == 0 ||*/ record.finishDate == null
                        select task;
            return query.ToList();
        }

        public static List<pojo.Task> readTaskByState(String state)
        {
            return null;
        }



    }
}
