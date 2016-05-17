using SynUp_Desktop.model.dao;
using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;

namespace SynUp_Desktop.service
{
    public class TeamHistoryService
    {
        /// <summary>
        /// Method that returns the TeamHistory if it found
        /// </summary>
        /// <param name="pNif">The nif employee to search</param>
        /// <param name="pCode">The code team to search</param>
        /// <returns>Returns the TeamHistory if it found</returns>
        public TeamHistory readTeamHistory(String pNif, String pCode)
        {
            return TeamHistoryConnection.readTeamHistory(pNif, pCode);
        }

        /// <summary>
        /// Method that updates a TeamHistory
        /// </summary>
        /// <param name="pNif">The nif employee to update</param>
        /// <param name="pCode">The code team to update</param>
        /// <param name="pEntranceDate">The entrance date to update</param>
        /// <param name="pExitDate">The exit date to update </param>
        /// <returns>Whether if the teamHistory has been correctly updated or not</returns>
        public bool updateTeamHistory(String pNif, String pCode, DateTime pEntranceDate, DateTime pExitDate)
        {
            return TeamHistoryConnection.updateTeamHistory(pNif, pCode, pEntranceDate, pExitDate);
        }

        /// <summary>
        /// Method that deletes a TeamHistory if it exists
        /// </summary>
        /// <param name="pNif">The nif employee to delete</param>
        /// <param name="pCode">The code team to delete</param>
        /// <returns>Returns the TeamHistory if it has been remove</returns>
        public TeamHistory deleteTeamHistory(String pNif, String pCode)
        {
            return TeamHistoryConnection.deleteTeamHistory(pNif, pCode);
        }

        /// <summary>
        /// Method that returns all TeamHistories 
        /// </summary>
        /// <returns>Return a list of teamHistories</returns>
        public List<TeamHistory> getAllTeamHistories()
        {
            List<TeamHistory> _lstTeamHistory = TeamHistoryConnection.readAllTeamHistories();
            foreach (TeamHistory _t in _lstTeamHistory)
            {
                this.returnWithoutSpaces(_t);
            }
            return _lstTeamHistory;
        }

        /// <summary>
        /// Method that returns all TeamHistories by team
        /// </summary>
        /// <param name="pCodeTeam">The code team to search</param>
        /// <returns>Return a list of teamHistories</returns>
        public List<TeamHistory> getAllTeamHistoriesByTeam(String pCodeTeam)
        {
            return TeamHistoryConnection.readAllTeamHistoriesByTeam(pCodeTeam);
        }

        /// <summary>
        /// Method that returns the strings without spaces
        /// </summary>
        /// <param name="pTeamHistory">The object TeamHistory we want to remove the spaces</param>
        /// <returns>Returns the object TeamHistory</returns>
        private TeamHistory returnWithoutSpaces(TeamHistory pTeamHistory)
        {
            if (pTeamHistory != null)
            {
                if (pTeamHistory.id_employee != null) pTeamHistory.id_employee = pTeamHistory.id_employee.Trim();
                if (pTeamHistory.id_team != null) pTeamHistory.id_team = pTeamHistory.id_team.Trim();
            }
            return pTeamHistory;
        }
    }
}
