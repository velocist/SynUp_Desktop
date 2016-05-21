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
        /// <summary>
        /// Method that creates a Team
        /// </summary>
        /// <param name="code">The code team</param>
        /// <param name="name">The name team</param>
        /// <returns>Returns object Team</returns>
        public bool createTeam(String code, String name)
        {
            Team newTeam = new Team
            {
                code = code,
                name = name
            };

            return TeamConnection.createTeam(newTeam);
        }

        /// <summary>
        /// Method that returns a Team if it found
        /// </summary>
        /// <param name="pCode">The code team</param>
        /// <returns>Returns object Team </returns>
        public Team readTeam(String pCode)
        {
            return TeamConnection.readTeam(pCode);
        }

        /// <summary>
        /// Method that updates a team with 
        /// </summary>
        /// <param name="pCode"></param>
        /// <param name="sTeam_name"></param>
        /// <returns>Return true if it deleted, or false if it not updated</returns>
        public bool updateTeam(String pCode, String sTeam_name)
        {
            Team _newTeam = new Team
            {
                code = pCode,
                name = sTeam_name
            };
            return TeamConnection.updateTeam(_newTeam);
        }

        /// <summary>
        /// Method that deletes a Team
        /// </summary>
        /// <param name="pTeam">The Team to delete</param>
        /// <returns></returns>
        public Team deleteTeam(Team pTeam)
        {
            return TeamConnection.deleteTeam(pTeam);
        }

        /// <summary>
        /// MEthod that gets all teams
        /// </summary>
        /// <returns></returns>
        public List<Team> getAllTeams()
        {
            List<Team> _lstTeam = TeamConnection.readAllTeams();
            foreach (Team _oTeamItem in _lstTeam)
            {
                this.returnWithoutSpaces(_oTeamItem);
            }
            return _lstTeam;
        }

        /// <summary>
        /// Method that adds a employee in a team
        /// </summary>
        /// <param name="pNifEmployee"></param>
        /// <param name="pCodeTeam"></param>
        /// <returns>Return true if it added in team, or false if it not added in team</returns>
        public bool addToTeam(String pNifEmployee, String pCodeTeam)
        {
            return TeamConnection.addToTeam(pNifEmployee, pCodeTeam);
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
