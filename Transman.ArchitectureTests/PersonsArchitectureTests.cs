using FluentAssertions;
using Transman.ArchitectureTests.Common;
using Transman.ArchitectureTests.Common.Predicates;

namespace Transman.ArchitectureTests;

public class PersonsArchitectureTests
{
    private const string Event = "Event";

    [Theory]
    [InlineData(Modules.Orders)]
    internal void Persons_should_not_have_dependency_on_module(string moduleName)
    {
        // Arrange
        var passesModule = Solution.Types
            .That()
            .ResideInNamespace(Modules.Persons);

        var forbiddenModule = Solution.Types
            .That()
            .ResideInNamespace(moduleName);
        var forbiddenModuleTypes = forbiddenModule.GetModuleTypes();

        // Act
        var rules = passesModule
            .Should()
            .NotHaveDependencyOnAny(forbiddenModuleTypes);
        var validationResult = rules!.GetResult();

        // Assert
        validationResult.FailingTypes.Should().BeNull();
    }

//     [Fact]
//     internal void PassesShouldCommunicateWithContractViaEvents()
//     {
//         // Arrange
//         var personsModule = Solution.Types
//             .That()
//             .ResideInNamespace(Modules.Persons);
//
//         var shouldModule = Solution.Types
//             .That()
//             .ResideInNamespace(Modules.Orders)
//             .And()
//             .DoNotHaveNameEndingWith(Event);
//         var forbiddenModuleTypes = shouldModule.GetModuleTypes();
//         //
//         // Act
//         var rules = personsModule
//             .Should()
//             .NotHaveDependencyOnAny(forbiddenModuleTypes);
//         var validationResult = rules!.GetResult();
//         //
//         // Assert
//         validationResult.FailingTypes.Should().BeNull();
//     }
}