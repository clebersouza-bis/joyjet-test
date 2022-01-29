using Joylet.API.Domain.IServices;
using Joylet.API.Domain.Models;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joylet.API.Test.Services
{
    public class MockCartService : Mock<ICartService>
    {
        public async Task <MockCartService> MockGetAll(IEnumerable<Cart> carts)
        {
            Setup(x => x.GetCartsAsync())
                .Returns( (Task<IEnumerable<Cart>>)carts);
            return this;
        }
    }
}
