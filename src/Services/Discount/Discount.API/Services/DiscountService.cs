using Discount.API.Entities;
using Discount.API.Repositories.Interfaces;
using Discount.API.Services.Interfaces;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace Discount.API.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            var discount = await _discountRepository.GetDiscount(productName);

            return discount;
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            var discount = await _discountRepository.CreateDiscount(coupon);

            if (discount.Equals(0))
                return false;

            return true;
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            var discount = await _discountRepository.UpdateDiscount(coupon);

            if(discount.Equals(0))
                return false;

            return true;
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            var discount = await _discountRepository.DeleteDiscount(productName);

            if (discount.Equals(0))
                return false;

            return true;
        }
    }
}
