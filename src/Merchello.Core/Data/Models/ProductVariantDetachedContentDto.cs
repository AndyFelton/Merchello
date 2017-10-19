﻿namespace Merchello.Core.Data.Models
{
    using System;

    internal class ProductVariantDetachedContentDto
    {
        public Guid Pk { get; set; }

        public Guid ProductVariantKey { get; set; }

        public string CultureName { get; set; }

        public Guid DetachedContentTypeKey { get; set; }

        public string Values { get; set; }

        public int? TemplateId { get; set; }

        public string Slug { get; set; }

        public bool CanBeRendered { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual DetachedContentTypeDto DetachedContentTypeDtoKeyNavigation { get; set; }

        public virtual ProductVariantDto ProductVariantDtoKeyNavigation { get; set; }
    }
}