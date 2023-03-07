using System.Collections.Generic;

namespace Joylet.API.Domain.Models.Dto
{
    public class CreateCartDto
    {
        public int Id { get; set; }

        public List<CreateItemsDto> CartsItems { get; set; }

    }
}
