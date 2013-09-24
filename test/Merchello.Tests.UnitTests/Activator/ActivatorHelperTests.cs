﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Merchello.Core;
using Merchello.Core.OrderFulfillment.Strategies.Payment;
using Merchello.Core.Services;
using NUnit.Framework;

namespace Merchello.Tests.UnitTests.Activator
{
    [TestFixture]
    public class ActivatorHelperTests
    {
        [Test]
        public void Can_Instantiate_PaymentApplicationStrategy()
        {
            //// Arrange
            var args = new Type[] { typeof (InvoiceService), typeof (TransactionService)};
            var argValues = new object[] { new InvoiceService(), new TransactionService() };
            var expected = new PaymentApplicationStrategy(new InvoiceService(), new TransactionService());
            
            //// Act
            var actual = ActivatorHelper.CreateInstance<PaymentApplicationStrategy>(typeof(PaymentApplicationStrategy), args, argValues);

            //// Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}