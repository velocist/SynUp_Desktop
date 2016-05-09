using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.model.dao
{
    public static class TeamConnection
    {
        private static synupEntities database = new synupEntities();

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges()
        {
            try
            {
                database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates a given team.
        /// </summary>
        /// <param name="pTeam">Receives the object Team that will be inserted in the database.</param>
        /// <returns>Returns a boolean depending in the outcome of the insert - true if it is successfull</returns>
        public static bool createTeam(pojo.Team pTeam)
        {
            pojo.Team _oTeam = readTeam(pTeam.code); //Finds the received team in the database. 

            if (_oTeam == null) database.Teams.Add(pTeam); //If the team doesn't exist already in the database, it will be inserted.

            return commitChanges();
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="pCode">Code key of the team</param>
        /// <returns>If the code is already on the database it will return the Team, otherwise it will return a null.</returns>
        public static pojo.Team readTeam(String pCode)
        {
            var query = from team in database.Teams
                        where team.code == pCode
                        select team;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Receives the team that is meant to be updated
        /// </summary>
        /// <param name="pTeam">Receives the team that will be updated</param>
        /// <returns>Returns a boolean whether the team has been updated succesfully or not.</returns>
        public static bool updateTeam(pojo.Team pTeam)
        {
            pojo.Team _oTeam = readTeam(pTeam.code);

            _oTeam = pTeam;

            return commitChanges();
        }

        /// <summary>
        /// Deletes a given team.
        /// </summary>
        /// <param name="pTeam">Receives the team that is meant to be deleted</param>
        /// <returns></returns>
        public static pojo.Team deleteTeam(pojo.Team pTeam)
        {
            pojo.Team _oTeam = readTeam(pTeam.code); //Finds the received team in the database.

            if (_oTeam != null) //If the team has been found - meaning that it exists:
            {
                database.Teams.Remove(_oTeam); //Will be deleted.
            }

            if (commitChanges()) return _oTeam; //If the changes are commited succesfully it will return the deleted Team.
            else return null;
        }

        public static List<pojo.Team> readAllTeams()
        {
            return (from team in database.Teams select team).ToList();
        }

    }
}
