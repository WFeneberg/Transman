namespace Transman.Common.BusinessRulesEngine;

public interface IBusinessRule
{
    bool IsMet();
    string Error { get; }
}