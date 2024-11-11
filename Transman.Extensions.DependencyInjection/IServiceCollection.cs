namespace Transman.Extensions.DependencyInjection;

public interface IServiceCollection {
    public void AddTransient<T>(Func<T> ctor);
    public void AddSingleton<T>(Func<T> ctor);
}