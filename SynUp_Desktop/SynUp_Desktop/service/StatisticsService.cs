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

        public List<Task> getTasksByTeam(String code)
        {
            return StatisticsConnection.readTasksByTeam(code);
        }

        public List<Task> getTasksByEmployee(String dni)
        {
            return StatisticsConnection.readTasksByEmployee(dni);
        }

        public List<spGetRankingTeam_Result> getRankingTeams(DateTime begin, DateTime end)
        {
            return StatisticsConnection.readRankingTeams(begin, end);
        }

        public List<spGetRankingEmployee_Result> getRankingEmployees(DateTime begin, DateTime end)
        {
            return StatisticsConnection.readRankingEmployee(begin, end);
        }

        public List<Task> getTasksByState(String state)
        {
            state = state.ToLower().Trim();
            List<Task> _resultList = null;

            switch (state)
            {
                case "not selected":
                    _resultList = StatisticsConnection.readUnselectedTasks();
                    break;
                case "ongoing":
                    _resultList = StatisticsConnection.readOngoingTasks();
                    break;
                case "finished":
                    _resultList = StatisticsConnection.readFinishedTasks();
                    break;
                case "abandonned":
                    _resultList = StatisticsConnection.readAbandonnedTasks();
                    break;
            }

            return _resultList;
        }
    }
}
