using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace PluginSample;

class PluginLoadContext : AssemblyLoadContext {
    private AssemblyDependencyResolver _resolver;

    public PluginLoadContext(string pluginPath) {
        _resolver = new AssemblyDependencyResolver(pluginPath);
    }

    protected override Assembly? Load(AssemblyName assemblyName) {
        string assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);

        if(assemblyPath != null) {
            return base.LoadFromAssemblyPath(assemblyPath);
        }

        return null;
    }

    protected override nint LoadUnmanagedDll(string unmanagedDllName) {
        string libraryPath = _resolver.ResolveUnmanagedDllToPath(unmanagedDllName);

        if(libraryPath != null) {
            return LoadUnmanagedDllFromPath(libraryPath);
        }

        return nint.Zero;
    }
}
