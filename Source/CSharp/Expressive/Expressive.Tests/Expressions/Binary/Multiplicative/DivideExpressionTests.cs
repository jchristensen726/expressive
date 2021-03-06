﻿using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Expressions.Binary.Multiplicative;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Expressive.Tests.Expressions.Binary.Multiplicative
{
    [TestClass]
    public class DivideExpressionTests
    {
        [TestMethod]
        public void TestEvaluate()
        {
            var expression = new DivideExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)1),
                ExpressiveOptions.None);

            Assert.AreEqual(1d, expression.Evaluate(null));
        }
    }
}
