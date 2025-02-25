namespace PluginBase;

public interface IPluginBase{
    string Name { get; }
    string Description { get; }

    void Execute();

}
