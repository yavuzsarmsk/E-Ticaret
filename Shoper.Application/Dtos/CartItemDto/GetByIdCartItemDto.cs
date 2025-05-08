using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoper.Domain.Entities;

namespace Shoper.Application.Dtos.CartItemDto
{
    public class GetByIdCartItemDto
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
