using WSCT.GUI.Plugins.ACOS6.Resources;

namespace WSCT.GUI.Plugins.ACOS6;

/// <summary>
/// Plugin entry point for ACOS6 - ENSICAEN.
/// </summary>
[PluginEntry(Name = nameof(Lang.PluginName), Description = nameof(Lang.PluginDescription), ResourceType = typeof(Lang))]
public class PluginEntry : GenericPluginEntry<Acos6Gui>
{
    public override string Icon => "bi bi-credit-card-2-front";
}
