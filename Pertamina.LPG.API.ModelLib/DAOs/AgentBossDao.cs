﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pertamina.LPG.API.DAOs;
using Pertamina.LPG.API.Models;

namespace Pertamina.LPG.API.DAOs
{
    public class AgentBossDao: DAO
    {
        public AgentBoss FindByMobileNumber(string mobileNumber)
        {
            var agentBoss = _context.AgentBosses.Where(a =>a.StatusId && a.MobileNumber.Replace("+62", "") == mobileNumber.Replace("+62", ""));
            if (agentBoss.Count() > 0)
            {
                return agentBoss.Single();
            }
            return null;
        }

        public void Update(AgentBoss agentBoss)
        {
            _context.Entry(agentBoss).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
        }

        public AgentBoss FindById(int userId)
        {
            return _context.AgentBosses.Find(userId);
        }
    }
}
