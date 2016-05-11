using SynUp_Desktop.model.dao;
using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;

namespace SynUp_Desktop.service
{
    public class TeamHistoryService
    {
        public TeamHistory readTeamHistory(String pNif, String pCode)
        {
            return TeamHistoryConnection.readTeamHistory(pNif, pCode);
        }

        public bool updateTeamHistory(String pNif, String pCode, DateTime pEntranceDate, DateTime pExitDate)
        {
            return TeamHistoryConnection.updateTeamHistory(pNif, pCode, pEntranceDate, pExitDate);
        }

        public TeamHistory deleteTeamHistory(String pNif, String pCode)
        {
            return TeamHistoryConnection.deleteTeamHistory(pNif,pCode);
        }

        public List<TeamHistory> getAllTeamHistories()
        {
            return TeamHistoryConnection.readAllTeamHistories();
        }
    }
}
