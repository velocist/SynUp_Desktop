using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SynUp_Desktop.model.pojo;
using SynUp_Desktop.model.dao;

namespace SynUp_Desktop.service
{
    /// <summary>
    /// The class TeamService
    /// </summary>
    /// <CreationDate>16/05/2016</Creation>
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

        public bool updateTeam(String pCode, String sTeam_name)
        {
            Team _newTeam = new Team
            {
                code = pCode,
                name = sTeam_name
            };
            return TeamConnection.updateTeam(_newTeam);
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

        /// <summary>
        /// Method that returns the strings without spaces
        /// </summary>
        /// <param name="pTeam">The object Team we want to remove the spaces</param>
        /// <returns>Return the object Team</returns>
        private Team returnWithoutSpaces(Team pTeam)
        {
            if (pTeam != null)
            {
                if (pTeam.code != null) pTeam.code = pTeam.code.Trim();
                if (pTeam.name != null) pTeam.name = pTeam.name.Trim();
            }
            return pTeam;
        }

    }
}
