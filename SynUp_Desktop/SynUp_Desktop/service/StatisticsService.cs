using SynUp_Desktop.model.dao;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.utilities;
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
            int _state = -1;

            switch (state)
            {
                case "not selected":
                    _state = (int)TaskState.UNSELECTED;
                    break;
                case "ongoing":
                    _state = (int)TaskState.ONGOING;
                    break;
                case "finished":
                    _state = (int)TaskState.FINISHED;
                    break;
                case "abandoned":
                    _state = (int)TaskState.ABANDONED;
                    break;
                case "cancelled":
                    _state = (int)TaskState.CANCELLED;
                    break;
            }

            return StatisticsConnection.readStatusTasks(_state);
        }
    }
}
