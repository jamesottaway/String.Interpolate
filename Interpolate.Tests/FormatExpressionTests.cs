﻿using Interpolate;
using NUnit.Framework;

namespace Interpolate.Tests
{
    [TestFixture]
    public class FormatExpressionTests
    {
        [Test]
        public void Format_WithExpressionReturningNull_DoesNotThrowException()
        {
            //arrange
            var expr = new FormatExpression("{foo}");

            //assert
            Assert.AreEqual(string.Empty, expr.Eval(new {foo = (object)null}));
        }

        [Test]
        public void Format_WithoutColon_ReadsWholeExpression() { 
            //arrange
            var expr = new FormatExpression("{foo}");

            //assert
            Assert.AreEqual("foo", expr.Expression);
        }

        [Test]
        public void Format_WithColon_ParsesoutFormat    ()
        {
            //arrange
            var expr = new FormatExpression("{foo:#.##}");

            //assert
            Assert.AreEqual("#.##", expr.Format);
        }

        [Test]
        public void Eval_WithNamedExpression_EvalsPropertyOfExpression() {
            //arrange
            var expr = new FormatExpression("{foo}");

            //act
            string result = expr.Eval(new { foo = 123 });
            
            //assert
            Assert.AreEqual("123", result);
        }

        [Test]
        public void Eval_WithNamedExpressionAndFormat_EvalsPropertyOfExpression()
        {
            //arrange
            var expr = new FormatExpression("{foo:#.##}");

            //act
            string result = expr.Eval(new { foo = 1.23456 });

            //assert
            Assert.AreEqual("1.23", result);
        }
    }
}
