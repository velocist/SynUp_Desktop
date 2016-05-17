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

        private static bool commitChanges(synupEntities _database)
        {
            try
            {
                _database.SaveChanges();
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
            //openConnection();

            pojo.Team _oTeam = readTeam(pTeam.code); //Finds the received team in the database. 

            if (_oTeam == null)//If the team doesn't exist already in the database, it will be inserted.
            {
                using (var context = new synupEntities())
                {
                    context.Teams.Add(pTeam);
                    return commitChanges(context);
                }
            }

            return false;
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

            using (var context = new synupEntities())
            {
                _oTeam.name = pTeam.name;                
                return commitChanges();
            }
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
                using (var context = new synupEntities())
                {
                    tryAttach(context, _oTeam);

                    context.Teams.Remove(_oTeam); //Will be deleted.
                    if (commitChanges(context)) return _oTeam; //If the changes are commited succesfully it will return the deleted Team.
                    else return null;
                }
            }
            return null;
        }

        public static List<pojo.Team> readAllTeams()
        {
            return (from team in database.Teams select team).ToList();
        }

        public static bool addToTeam(/*pojo.Employee pEmployee, pojo.Team pTeam*/ String _EmpNif, String _TeamCode)
        {
            model.pojo.TeamHistory _oTeamHistory = new model.pojo.TeamHistory();

            if (_EmpNif != null && _TeamCode != null)
            {
                using (var q = new synupEntities())
                {
                    _oTeamHistory.id_employee = _EmpNif;
                    _oTeamHistory.id_team = _TeamCode;
                    //_oTeamHistory.Employee = pEmployee;
                    //_oTeamHistory.Team = pTeam;
                    _oTeamHistory.entranceDay = DateTime.Today;

                    //database.TeamHistories.Add(_oTeamHistory);

                    q.TeamHistories.Add(_oTeamHistory);
                    return commitChanges(q);
                }

            }

            return false;
        }

        /// <summary>
        /// To-DO // CHECK THAT THE TEAM THAT IS DELETED WONT HAVE ANY FOREIGN KEYS THAT REFERENCE IT
        /// </summary>
        /// <param name="team"></param>
        private static void checkTeamMembers(Team team)
        {
            //Shows the employees that are currently in the given team.
            var query = from th in database.TeamHistories
                        join emp in database.Employees on th.id_employee equals emp.nif
                        where th.id_team.Equals(team.code) && th.exitDate == null
                        select emp;

            foreach (var member in query)
            {

            }
        }

        /// <summary>
        /// Attachs teams
        /// </summary>
        /// <param name="pContext"></param>
        /// <param name="pTeam">The object which were attachs</param>
        private static void tryAttach(synupEntities pContext, pojo.Team pTeam)
        {
            var entry = pContext.Entry(pTeam);
            if (entry.State == System.Data.Entity.EntityState.Detached) pContext.Teams.Attach(pTeam);
        }
    }
}
