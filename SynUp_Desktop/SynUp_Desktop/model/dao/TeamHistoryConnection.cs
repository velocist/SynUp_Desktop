﻿using SynUp_Desktop.model.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynUp_Desktop.model.dao
{
    public static class TeamHistoryConnection
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
        /// Given the code, it is searched in the database and will return the first result.
        /// </summary>
        /// <param name="code">Code key of the teamHistory.</param>
        /// <returns>If the code is already on the database it will return the TeamHistory, otherwise it will return a null.</returns>
        public static pojo.TeamHistory readTeamHistory(String pNif, String pCodeTeam)
        {
            var query = from teamHistory in database.TeamHistories
                        where teamHistory.id_employee == pNif && teamHistory.id_team == pCodeTeam
                        select teamHistory;

            return query.SingleOrDefault();
        }

        /// <summary>
        /// Deletes a given teamHistory.
        /// </summary>
        /// <param name="t">Receives the teamHistory that is meant to be deleted.</param>
        /// <returns>Returns the teamHistory that has been deleted.</returns>
        public static pojo.TeamHistory deleteTeamHistory(String pNif, String pCode)
        {
            pojo.TeamHistory foundTeamHistory = readTeamHistory(pNif,pCode); //Finds the received teamHistory in the database.

            if (foundTeamHistory != null) //If the teamHistory has been found - meaning that it exists:
            {
                using(var context = new synupEntities())
                {
                    tryAttach(context, foundTeamHistory);
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
        public static bool updateTeamHistory(String pNif, String pCodeTeam, DateTime pEntranceDate, DateTime pExitDate)
        {
            pojo.TeamHistory modifiedTeamHistory = null;

            modifiedTeamHistory = readTeamHistory(pNif, pCodeTeam);

            using (var context = new synupEntities())
            {
                if (modifiedTeamHistory != null)
                {
                    modifiedTeamHistory.id_employee = pNif;
                    modifiedTeamHistory.id_team = pCodeTeam;
                    modifiedTeamHistory.entranceDay = pEntranceDate;
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
            return (from teamHistory in database.TeamHistories select teamHistory).ToList();
        }

        /// <summary>
        /// Read the teamsHistories by team
        /// </summary>
        /// <param name="pCodeTeam"></param>
        /// <returns></returns>
        public static List<TeamHistory> readAllTeamHistoriesByTeam(String pCodeTeam)
        {
            return (from teamHistory in database.TeamHistories
                    where teamHistory.id_team == pCodeTeam && teamHistory.exitDate == null select teamHistory).ToList();
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
