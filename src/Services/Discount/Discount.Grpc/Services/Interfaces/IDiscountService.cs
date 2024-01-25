using Discount.Grpc.Entities;
using System.Threading.Tasks;

namespace Discount.Grpc.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<Coupon> GetDiscount(string productName);

        Task<bool> CreateDiscount(Coupon coupon);

        Task<bool> UpdateDiscount(Coupon coupon);

        Task<bool> DeleteDiscount(string productName);
    }
}