using System.Reflection;

namespace Transman.Extensions.DependencyInjection;

public static class Helper {
    public static IEnumerable<FieldInfo> GetRequiredServices(IReflect t) {
        return t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x=>Attribute.IsDefined(x, typeof(Inject)));
    }
}