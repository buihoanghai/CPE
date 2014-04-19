using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface IAgentsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Agent agent);
        System.Collections.Generic.List<Models.Agent> SelectAll();
        Models.Agent SelectByID(int ID);
        bool Update(Models.Agent agentUpdate);
    }
}
