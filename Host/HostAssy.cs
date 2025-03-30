using System.Reflection;

namespace Host;

public static class HostAssy
{
    private static Assembly[]? _assemblies;

    public static Assembly[] Assemblies => _assemblies ??= [typeof(App.Components.Layout.MainLayout).Assembly];
}