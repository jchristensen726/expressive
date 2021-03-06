﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions.Date
{
    internal sealed class DayOfFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name => "DayOf";

        public override object Evaluate(IExpression[] parameters, ExpressiveOptions options)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            var dateObject = parameters[0].Evaluate(this.Variables);

            if (dateObject == null) return null;

            if (dateObject.ToString() == "") return null;

            var date = Convert.ToDateTime(dateObject);

            return date.Day;
        }

        #endregion
    }
}
