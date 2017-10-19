﻿namespace Merchello.Core.Data.Models
{
    using System;
    using System.Collections.Generic;

    internal sealed class OrderStatusDto
    {
        public OrderStatusDto()
        {
            this.MerchOrder = new HashSet<OrderDto>();
        }

        public Guid Pk { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public bool Reportable { get; set; }

        public bool Active { get; set; }

        public int SortOrder { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<OrderDto> MerchOrder { get; set; }
    }
}