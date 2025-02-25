using PluginBase;
using System.Reflection;

namespace PluginSample;

// Build SumPlugin and MultiplicationPlugin and copy the output .dll files to the Plugins folder
// no need to copy PluginBase.dll

internal class Program {
    static void Main(string[] args) {
        Dictionary<int, IPluginBase> plugins = new();

        Console.WriteLine("Calculator");

        IEnumerable<string> pluginPaths = GetPluginPaths();

        // Load plugins
        int pluginCount = 0;
        foreach (var path in pluginPaths) {
            pluginCount++;

            var plugin = LoadPlugin(path);
            if (plugin != null) {
                plugins.Add(pluginCount, plugin);
            }
        }

        // Show plugins options
        int selectedOperation = 0;
        do {
            Console.WriteLine("0: Exit");
            foreach (var plugin in plugins) {
                Console.WriteLine($"{plugin.Key}: {plugin.Value.Name}");
            }

            Console.Write("Select operation: ");
            selectedOperation = Int32.Parse(Console.ReadLine());

            if (selectedOperation != 0 && selectedOperation <= plugins.Count) {
                plugins[selectedOperation].Execute();
            }
        } while (selectedOperation != 0);
    }

    private static IEnumerable<string> GetPluginPaths() {
        var pluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");

        return Directory.GetFiles(pluginPath, "*.dll");
    }

    private static IPluginBase LoadPlugin(string pluginPath) {
        var loadContext = new PluginLoadContext(pluginPath);
        var assembly = loadContext.LoadFromAssemblyName(AssemblyName.GetAssemblyName(pluginPath));
        foreach (Type type in assembly.GetTypes()) {
            if (typeof(IPluginBase).IsAssignableFrom(type)) {
                IPluginBase plugin = Activator.CreateInstance(type) as IPluginBase;

                return plugin;
            }
        }

        return null;
    }

    //private static IEnumerable<IPluginBase> LoadPlugin(string pluginPath) {

    //    var loadContext = new PluginLoadContext(pluginPath);

    //    var assembly = loadContext.LoadFromAssemblyName(AssemblyName.GetAssemblyName(pluginPath));

    //    foreach (Type type in assembly.GetTypes()) {
    //        if (typeof(IPluginBase).IsAssignableFrom(type)) {
    //            IPluginBase plugin = Activator.CreateInstance(type) as IPluginBase;

    //            yield return plugin;
    //        }
    //    }
    //}
}
