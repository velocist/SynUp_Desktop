using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SynUp_Desktop.model.dao
{
    public static class TeamHistoryConnection
    {
        //private static synupEntities database = new synupEntities();

        /// <summary>
        /// Saves the changes done over the database.
        /// </summary>
        /// <returns>Returns a boolean depending in whether the operation is completed succesfully or not.</returns>
        private static bool commitChanges()
        {
            try
            {
                new synupEntities().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
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
                Debug.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="code">Code key of the teamHistory.</param>
        /// <returns>If the code is already on the database it will return the TeamHistory, otherwise it will return a null.</returns>
        public static pojo.TeamHistory readTeamHistory(String pNif, String pCodeTeam, synupEntities seContext)
        {
            //var query = from teamHistory in seContext.TeamHistories
            //            where teamHistory.id_employee == pNif && teamHistory.id_team == pCodeTeam
            //            select teamHistory;
            var subquery = seContext.TeamHistories.Where(x => x.id_employee == pNif && x.id_team == pCodeTeam).Max(x => x.id);
            var query = seContext.TeamHistories.Where(x => x.id == subquery);

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="code">Code key of the teamHistory.</param>
        /// <returns>If the code is already on the database it will return the TeamHistory, otherwise it will return a null.</returns>
        public static pojo.TeamHistory readTeamHistory(String pNif, String pCodeTeam)
        {
            //var query = from teamHistory in new synupEntities().TeamHistories
            //            where teamHistory.id_employee == pNif && teamHistory.id_team == pCodeTeam && 
            //            select teamHistory;

            synupEntities _synupE = new synupEntities();
            var subquery = _synupE.TeamHistories.Where(x => x.id_employee == pNif && x.id_team == pCodeTeam).Max(x => x.id);
            var query = _synupE.TeamHistories.Where(x => x.id == subquery);

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Deletes a given teamHistory.
        /// </summary>
        /// <param name="t">Receives the teamHistory that is meant to be deleted.</param>
        /// <returns>Returns the teamHistory that has been deleted.</returns>
        public static pojo.TeamHistory deleteTeamHistory(String pNif, String pCode)
        {
            using (var context = new synupEntities())
            {
                pojo.TeamHistory foundTeamHistory = readTeamHistory(pNif, pCode, context); //Finds the received teamHistory in the database.

                if (foundTeamHistory != null) //If the teamHistory has been found - meaning that it exists:
                {
                    tryAttach(context, foundTeamHistory);
                    //foundTeamHistory
                    //foundTeamHistory.Team = null;
                    context.TeamHistories.Remove(foundTeamHistory); //Will be deleted.
                    if (commitChanges(context)) return foundTeamHistory; //If the changes are commited succesfully it will return the deleted TeamHistory.
                    else return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Updates a given teamHistory with the new parameters of it.
        /// </summary>
        /// <param name="pTeamHistory">Receives the teamHistory that will be updated.</param>
        /// <returns>Returns a boolean whether the teamHistory has been updated succesfully or not.</returns>
        public static bool updateTeamHistory(String pNif, String pCodeTeam/*, DateTime pEntranceDate,*/, DateTime pExitDate)
        {
            using (var context = new synupEntities())
            {
                pojo.TeamHistory modifiedTeamHistory = null;

                modifiedTeamHistory = readTeamHistory(pNif, pCodeTeam, context);


                if (modifiedTeamHistory != null)
                {
                    tryAttach(context, modifiedTeamHistory);
                    //modifiedTeamHistory.id_employee = pNif;
                    //modifiedTeamHistory.id_team = pCodeTeam;
                    //modifiedTeamHistory.entranceDay = pEntranceDate;
                    modifiedTeamHistory.exitDate = pExitDate;

                }

                return commitChanges(context);
            }
        }

        /// <summary>
        /// Read all teamsHistories
        /// </summary>
        /// <returns></returns>
        public static List<TeamHistory> readAllTeamHistories()
        {
            return (from teamHistory in new synupEntities().TeamHistories select teamHistory).ToList();
        }

        /// <summary>
        /// Read the teamsHistories by team
        /// </summary>
        /// <param name="pCodeTeam"></param>
        /// <returns></returns>
        public static List<TeamHistory> readAllTeamHistoriesByTeam(String pCodeTeam)
        {
            return (from teamHistory in new synupEntities().TeamHistories
                    where teamHistory.id_team == pCodeTeam && teamHistory.exitDate == null
                    select teamHistory).ToList();
        }

        /// <summary>
        /// Read the teamsHistories by employee
        /// </summary>
        /// <param name="pNifEmployee"></param>
        /// <returns></returns>
        public static TeamHistory getCurrentTeamHistoryByEmployee(String pNifEmployee,String pCodeTeam)
        {
            var query = from teamHistory in new synupEntities().TeamHistories
                        where teamHistory.id_employee == pNifEmployee && teamHistory.id_team == pCodeTeam && teamHistory.exitDate == null
                        select teamHistory;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_codeTeam"></param>
        /// <returns></returns>
        public static List<pojo.TeamMember> readTeamMembers(String _codeTeam)
        {
            using (var context = new synupEntities())
            {
                List<TeamMember> toReturn = new List<TeamMember>();

                var query = from employee in context.Employees
                            join record in context.TeamHistories on employee.nif equals record.id_employee
                            where record.id_team.Equals(_codeTeam) && record.exitDate == null
                            select new
                            {
                                Emp = employee,
                                His = record
                            };

                foreach (var s in query)
                {
                    TeamMember tm = new TeamMember(s.Emp.nif, s.Emp.name, s.Emp.surname, s.His.entranceDay);
                    toReturn.Add(tm);
                }

                return toReturn;
            }
        }

        /// <summary>
        /// Attachs teams
        /// </summary>
        /// <param name="pContext"></param>
        /// <param name="pTeamHistory">The object which were attachs</param>
        private static void tryAttach(synupEntities pContext, pojo.TeamHistory pTeamHistory)
        {
            var entry = pContext.Entry(pTeamHistory);
            if (entry.State == System.Data.Entity.EntityState.Detached) pContext.TeamHistories.Attach(pTeamHistory);
        }
    }
}
