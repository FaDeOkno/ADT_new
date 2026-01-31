using Content.Shared.ADT.SpaceWhale;
using Robust.Shared.Map;

namespace Content.Client.ADT.SpaceWhale;

public sealed class TailedEntitySystem : SharedTailedEntitySystem
{
    public override void FrameUpdate(float frameTime)
    {
        base.FrameUpdate(frameTime);

        var query = EntityQueryEnumerator<TailedEntityComponent, TransformComponent>();
        while (query.MoveNext(out var uid, out var comp, out var xform))
        {
            UpdateTailPositions((uid, comp, xform), frameTime);
        }
    }
}
