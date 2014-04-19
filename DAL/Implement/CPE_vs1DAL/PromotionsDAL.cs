using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implement.CPE_vs1DAL
{
    public class PromotionsDAL : DAL.Implement.CPE_vs1DAL.IPromotionsDAL
    {
        public bool Insert(Models.Promotion promotion)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Promotions.Add(promotion);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Update(Models.Promotion promotionUpdate)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    Models.Promotion promotion = db.Promotions.Single<Models.Promotion>(c => c.ID == promotionUpdate.ID);
                    promotion.PromotionName = promotionUpdate.PromotionName;
                    promotion.Discount = promotionUpdate.Discount;
                    promotion.PromotionCode = promotionUpdate.PromotionCode;
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
                    var promotion = db.Promotions.Single(c => c.ID == ID);
                    db.Promotions.Remove(promotion);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public List<Models.Promotion> SelectAll()
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Promotions.OrderByDescending(p=>p.ID).ToList();
                }
                catch { return null; }
            }
        }
        public Models.Promotion SelectByID(int ID)
        {
            using(var db=new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Promotions.Single(c => c.ID == ID);
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
                    db.Promotions.Single(r => r.ID == ID);
                    return true;
                }
                catch { return false; }
           }
        }


        public Models.Promotion SelectByPromotionCode(string PromotionCode)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    return db.Promotions.Single(c => c.PromotionCode == PromotionCode);
                }
                catch { return null; }
            }
        }


        public bool CheckByPromotionCode(string PromotionCode)
        {
            using (var db = new Models.DBContextCPEDB())
            {
                try
                {
                    db.Promotions.Single(r => r.PromotionCode == PromotionCode);
                    return true;
                }
                catch { return false; }
            }
        }
    }
}

