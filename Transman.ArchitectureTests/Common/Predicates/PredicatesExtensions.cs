
namespace Transman.ArchitectureTests.Common.Predicates;

internal static class PredicatesExtensions
{
    internal static string[] GetModuleTypes(this PredicateList predicates) =>
        predicates
            .GetTypes()
            .Select(type => type.FullName)
            .Distinct()
            .ToArray()!;
}