using Robust.Client.Graphics;

namespace Content.Client.ADT.Mirror;

public sealed partial class MirrorSystem : EntitySystem
{
    [Dependency] private IOverlayManager _overlay = default!;

    public override void Initialize()
    {
        base.Initialize();

        _overlay.AddOverlay(new MirrorOverlay());
    }
}
