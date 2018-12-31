using System;
using System.Linq;
using Pertamina.LPG.API.DAOs;
using Pertamina.LPG.API.Models;

namespace Pertamina.LPG.API.Services
{
    public class AgentAdminDao : DAO
    {
        public AgentAdmin FindByMobileNumber(string mobileNumber)
        {
            var admins = _context.AgentAdmins.Where(a =>a.StatusId && a.MobileNumber.Replace("+62", "") == mobileNumber.Replace("+62", ""));
            if (admins.Count() > 0)
            {
                return admins.Single();
            }
            return null;
        }

        public void Update(AgentAdmin admin)
        {
            _context.Entry(admin).State = System.Data.EntityState.Modified;
            _context.SaveChanges();
        }

        public AgentAdmin FindById(int userId)
        {
            return _context.AgentAdmins.Find(userId);
        }
    }
}