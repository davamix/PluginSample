# Plugin Sample

Sample to know how to use plugins in C#.

* <b>PluginSample</b> is the main program.

* <b>MultiplicationPlugin</b> and <b>SumPlugin</b> are the plugins.

* PluginBase contains the common interface for the plugins.

* PluginSample will create a Plugins folder in the output directory after built via post-build event.

* Copy the ouput dll from the plugin projects to the Plugins folder. (MultiplicationPlugin.dll and SumPlugin.dll)

Documentation:

https://learn.microsoft.com/en-us/dotnet/core/tutorials/creating-app-with-plugin-support