﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoper.Application.Dtos.OrderItemDtos;
using Shoper.Domain.Entities;

namespace Shoper.Application.Dtos.OrderDtos
{
    public class UpdateOrderDtos
    {
        public int OrderId { get; set; }
        //public DateTime OrderDate { get; set; }
        //public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        //public string BillingAdress { get; set; }
        //public string ShippingAdress { get; set; }
        //public string PaymentMethod { get; set; }
        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
        public ICollection<UpdateOrderItemDto> OrderItems { get; set; }  }
}
