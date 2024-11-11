using System.Reflection;
using Avalonia;
using Transman.Extensions.DependencyInjection.Controls;

namespace Transman.Extensions.DependencyInjection;

public static class Extensions {

    private static IEnumerable<Type> GetDITypes(Assembly assembly) {
        var type = typeof(IInjectable);
        var items = assembly.GetTypes().Where(x => x.IsAssignableTo(type));
        return items;
    }
        
        
        
    public static AppBuilder UseDependencyInjection(this AppBuilder builder, Action<IServiceCollection> adder) {
        var collection = new ServiceCollection();
        adder.Invoke(collection);
        //Get a collection of all services (they can contain other services) and UI elements that require DI 
        var types = collection.GetServices().Concat(GetDITypes(Assembly.GetCallingAssembly()));
        collection.Build(types);
        return builder;
    }
}
