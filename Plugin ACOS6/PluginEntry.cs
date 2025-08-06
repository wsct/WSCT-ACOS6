using WSCT.GUI.Plugins.ACOS6.Resources;

namespace WSCT.GUI.Plugins.ACOS6
{
    /// <summary>
    /// 
    /// </summary>
    [PluginEntry(Name = nameof(Lang.PluginName), Description = nameof(Lang.PluginDescription), ResourceType = typeof(Lang))]
    public class PluginEntry : GenericPluginEntry<Gui>
    {
    }
}