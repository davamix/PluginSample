# Plugin Sample

Sample to know how to use plugins in C#.

* <b>PluginSample</b> is the main program.

* <b>MultiplicationPlugin</b> and <b>SumPlugin</b> are the plugins.
	* Added a new plugin project, <b>ExternalReferencePlugin</b>, to show how to use external references in the plugins.

* <b>PluginBase</b> contains the common interface for the plugins.

* PluginSample will create a Plugins folder in the output directory after built via post-build event.

* Copy the ouput dll from the plugin projects to the Plugins folder. (MultiplicationPlugin.dll and SumPlugin.dll)

Documentation:

https://learn.microsoft.com/en-us/dotnet/core/tutorials/creating-app-with-plugin-support

* The .csproj files of <b>SumPlugin</b> and <b>ExternalReferencePlugin</b> have changes to not copy the <i>PluginBase.dll</i> to the output directory.
* Will only copy the required dependencies when build or publish. 
* <b>SumPlugin</b> will have only <i>SumPlugin.dll</i> and <b>ExternalReferencePlugin</b> will have the <i>MathLibrary.Numerics</i> library additionally.