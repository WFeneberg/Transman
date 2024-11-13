using System;

namespace Transman.Common.BusinessRulesEngine;

public class BusinessRuleValidationException : InvalidOperationException
{
    public BusinessRuleValidationException(string message) : base(message)
    {
    }
}