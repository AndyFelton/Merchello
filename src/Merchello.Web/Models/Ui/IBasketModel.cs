﻿namespace Merchello.Web.Models.Ui
{
    /// <summary>
    /// Defines a basket UI component.
    /// </summary>
    /// <typeparam name="TBasketItemModel">
    /// The type of the basket item.
    /// </typeparam>
    public interface IBasketModel<TBasketItemModel> : IUiModel
        where TBasketItemModel : class, ILineItemModel, new()
    {
        /// <summary>
        /// Gets or sets the basket items.
        /// </summary>
        TBasketItemModel[] Items { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the wish list is enabled.
        /// </summary>
        bool WishListEnabled { get; set; }
    }
}