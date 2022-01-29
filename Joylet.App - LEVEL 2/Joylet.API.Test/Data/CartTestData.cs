using AutoMapper;
using Joylet.API.Domain.Models;
using Joylet.API.Domain.Models.Dto;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joylet.API.Test.Data
{
    public class CartTestData : IEnumerable<object[]>
    {        
        public IEnumerator<object[]> GetEnumerator()
        {

            var oCartTest = new List<CreateCartDto>();
            oCartTest.Add(new CreateCartDto
            {
                Id = 1,
                CartsItems = new List<CreateItemsDto> { new CreateItemsDto { Quantity = 1, ArticleId = 2 },
                                                        new CreateItemsDto { Quantity = 15, ArticleId = 3 }
                },

            });
            oCartTest.Add(new CreateCartDto
            {
                Id = 30,
                CartsItems = new List<CreateItemsDto> { new CreateItemsDto { Quantity = 10, ArticleId = 4 },
                                                        new CreateItemsDto { Quantity = 8, ArticleId = 1 }
                },

            });

            yield return new object[] { oCartTest };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IList<CreateCartDto> CartDtoDataTest()
        {
            var oCartTest = new List<CreateCartDto>();
            oCartTest.Add(new CreateCartDto
            {
                Id = 2,
                CartsItems = new List<CreateItemsDto> { new CreateItemsDto { Quantity = 1, ArticleId = 2 },
                                                        new CreateItemsDto { Quantity = 15, ArticleId = 3 }
                },

            });
            oCartTest.Add(new CreateCartDto
            {
                Id = 1,
                CartsItems = new List<CreateItemsDto> { new CreateItemsDto { Quantity = 10, ArticleId = 4 },
                                                        new CreateItemsDto { Quantity = 8, ArticleId = 1 }
                },

            });


            return oCartTest;
        }

    }
}
