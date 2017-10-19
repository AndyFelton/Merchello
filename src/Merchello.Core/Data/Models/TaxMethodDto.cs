﻿namespace Merchello.Core.Data.Models
{
    using System;

    internal class TaxMethodDto
    {
        public Guid Pk { get; set; }

        public Guid ProviderKey { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public decimal PercentageTaxRate { get; set; }

        public string ProvinceData { get; set; }

        public bool ProductTaxMethod { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual GatewayProviderSettingsDto ProviderKeyNavigation { get; set; }
    }
}