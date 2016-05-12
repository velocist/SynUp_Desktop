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

        //public static List<pojo.Task> readTasks
    }
}
