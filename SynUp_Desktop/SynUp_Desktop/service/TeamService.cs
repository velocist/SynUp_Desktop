using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.model.dao;

namespace SynUp_Desktop.service
{
    public class TeamService
    {
        public bool createTeam(String code, String name)
        {
            Team newTeam = new Team
            {
                code = code,
                name = name
            };

            return TeamConnection.createTeam(newTeam);
        }

        public Team readTeam(String pCode)
        {
            return TeamConnection.readTeam(pCode);
        }

        public bool updateTeam(Team pTeam)
        {
            return TeamConnection.updateTeam(pTeam);
        }

        public Team deleteTeam(Team pTeam)
        {
            return TeamConnection.deleteTeam(pTeam);
        }

        public List<Team> getAllTeams()
        {
            List<Team> _lstTeam = TeamConnection.readAllTeams();
            foreach (Team _oTeamItem in _lstTeam)
            {
                this.returnWithoutSpaces(_oTeamItem);
            }
            return _lstTeam;
        }

        public bool addToTeam(String pEmployee, String pTeam)
        {
            return TeamConnection.addToTeam(pEmployee, pTeam);
        }

        private Team returnWithoutSpaces(Team pTeam)
        {
            if (pTeam != null)
            {
                pTeam.code = pTeam.code.Trim();
                pTeam.name = pTeam.name.Trim();
            }
            return pTeam;
        }

    }
}
