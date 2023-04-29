using StoreManagement.Domain.Models.Purchase;

namespace StoreManagement.Repository.Repositories.Purchase
{
    public interface IPurchaseRepository
    {
        void CreatePurshase(PurchaseModel purchaseModel);
    }
}