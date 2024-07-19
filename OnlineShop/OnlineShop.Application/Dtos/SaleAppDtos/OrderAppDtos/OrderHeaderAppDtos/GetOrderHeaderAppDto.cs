﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Dtos.SaleAppDtos.OrderAppDtos.OrderHeaderAppDtos
{
    public class GetOrderHeaderAppDto
    {
        public Guid HeaderId { get; set; }
        public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateCreatedLatin { get; set; }
        public string DateCreatedPersian { get; set; }
        public string EntityDescription { get; set; }
        public bool IsModified { get; set; }
        public DateTime? DateModifiedLatin { get; set; }
        public string? DateModifiedPersian { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateSoftDeletedLatin { get; set; }
        public string? DateSoftDeletedPersian { get; set; }


    }
}
