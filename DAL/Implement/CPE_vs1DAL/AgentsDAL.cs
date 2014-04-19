using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class AgentsDAL : DAL.Implement.CPE_vs1DAL.IAgentsDAL
    {
        public bool Insert(Models.Agent agent)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Agents.Add(agent);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Agent agentUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Agent agent = db.Agents.Single<Models.Agent>(c => c.ID == agentUpdate.ID);
                    agent.Code = agentUpdate.Code;
		    agent.Name = agentUpdate.Name;
		    agent.Contact = agentUpdate.Contact;
		    agent.Email = agentUpdate.Email;
		    agent.Address = agentUpdate.Address;
		    
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool DeleteByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try{
                    var agent = db.Agents.Single(c => c.ID == ID);
                    db.Agents.Remove(agent);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Agent> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Agents.OrderByDescending(a=>a.ID).ToList();
                }
                catch { return null; }
            }
        }
        public Models.Agent SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Agents.Single(c => c.ID == ID);
                }
                catch { return null; }
            }
        }
        public bool CheckByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    db.Agents.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }
    }
}

