using Robust.Shared.Containers;
using Robust.Shared.GameStates;

namespace Content.Shared.ADT.ModSuits;

/// <summary>
///     This component indicates that this clothing is attached to some other entity with a <see
///     cref="MODSuitComponent"/>. When unequipped, this entity should be returned to the entity that it is
///     attached to, rather than being dumped on the floor or something like that. Intended for use with hardsuits and
///     hardsuit helmets.
/// </summary>
[Access(typeof(ModSuitSystem))]
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ModPartComponent : Component
{
    public const string DefaultClothingContainerId = "replaced-clothing";

    /// <summary>
    ///     The Id of the piece of clothing that this entity belongs to.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid AttachedUid;

    /// <summary>
    ///     Container ID for clothing that will be replaced with this one
    /// </summary>
    [DataField, AutoNetworkedField]
    public string ClothingContainerId = DefaultClothingContainerId;

    [ViewVariables, NonSerialized]
    public ContainerSlot? ClothingContainer;
}
