using Basket.API.Entities;
using Basket.API.Repositories;
using Basket.API.Services.Interface;
using System.Threading.Tasks;

namespace Basket.API.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;

        public BasketService(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            var basket = await _basketRepository.GetBasket(userName);
            return basket;
        }

        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            var basketUpdate = await _basketRepository.UpdateBasket(basket);
            return basketUpdate;
        }

        public async Task DeleteBasket(string userName)
        {
            await _basketRepository.DeleteBasket(userName);
        }
    }
}
