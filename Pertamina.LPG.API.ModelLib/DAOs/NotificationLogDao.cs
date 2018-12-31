using Pertamina.LPG.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DAOs
{
    public class NotificationLogDao : DAO
    {
        public NotificationLog Insert(NotificationLog log)
        {
            _context.NotificationLogs.Add(log);
            _context.SaveChanges();
            return log;
        }
    }
}
