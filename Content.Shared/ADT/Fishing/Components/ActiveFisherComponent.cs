using Robust.Shared.GameStates;

namespace Content.Shared.ADT.Fishing.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ActiveFisherComponent : Component
{
    [DataField, AutoNetworkedField]
    public TimeSpan? NextStruggle;

    [DataField, AutoNetworkedField]
    public float? TotalProgress;

    [DataField, AutoNetworkedField]
    public float ProgressPerUse = 0.05f;

    [DataField, AutoNetworkedField]
    public EntityUid FishingRod;
}
