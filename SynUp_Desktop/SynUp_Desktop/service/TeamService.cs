﻿using System;
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
            return TeamConnection.readAllTeams();
        }

    }
}