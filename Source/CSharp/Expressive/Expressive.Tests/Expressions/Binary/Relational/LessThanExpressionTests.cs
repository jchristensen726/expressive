﻿using System.Collections.Generic;
using Expressive.Expressions;
using Expressive.Expressions.Binary.Relational;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Expressive.Tests.Expressions.Binary.Relational
{
    [TestClass]
    public class LessThanExpressionTests
    {
        [TestMethod]
        public void TestBothNull()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                ExpressiveOptions.None);

            Assert.AreEqual(null, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestEqual()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                ExpressiveOptions.None);

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestGreaterThan()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)2),
                ExpressiveOptions.None);

            Assert.AreEqual(false, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestLeftNull()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)"abc"),
                ExpressiveOptions.None);

            Assert.AreEqual(null, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestLessThan()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)2),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)5),
                ExpressiveOptions.None);

            Assert.AreEqual(true, expression.Evaluate(null));
        }

        [TestMethod]
        public void TestRightNull()
        {
            var expression = new LessThanExpression(
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)false),
                Mock.Of<IExpression>(e => e.Evaluate(It.IsAny<IDictionary<string, object>>()) == (object)null),
                ExpressiveOptions.None);

            Assert.AreEqual(null, expression.Evaluate(null));
        }
    }
}
