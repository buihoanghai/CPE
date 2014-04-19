using System;
namespace DAL.Implement.CPE_vs1DAL
{
    public interface IPromotionsDAL
    {
        bool CheckByID(int ID);
        bool DeleteByID(int ID);
        bool Insert(Models.Promotion promotion);
        System.Collections.Generic.List<Models.Promotion> SelectAll();
        Models.Promotion SelectByID(int ID);
        bool Update(Models.Promotion promotionUpdate);
        Models.Promotion SelectByPromotionCode(string PromotionCode);
        bool CheckByPromotionCode(string PromotionCode);
    }
}
