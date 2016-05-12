using SynUp_Desktop.model.dao;
using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynUp_Desktop.service
{
    class StatisticsService
    {
        public List<Task> getTasksByDate(DateTime begin, DateTime end)
        {
            return StatisticsConnection.readTasksByDate(begin, end);
        }

        public List<Task> getTasksbyTeam(String code)
        {
            return StatisticsConnection.readTasksByTeam(code);
        }
    }
}
