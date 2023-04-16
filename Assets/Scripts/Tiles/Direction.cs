using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    public abstract class Direction
    {
        internal static Direction[] Directions { get; } = new Direction[] { new Up(), new Down(), new Left(), new Right() };
        internal abstract Vector2 NormalizedDirection { get; private protected set; }
        internal abstract Direction RestrictedDirection { get; }
    }

    public class Up : Direction
    {
        internal override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(0, 1);
        internal override Direction RestrictedDirection => new Down();
    }

    public class Down : Direction
    {
        internal override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(0, -1);
        internal override Direction RestrictedDirection => new Up();
    }

    public class Left : Direction
    {
        internal override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(-1, 0);
        internal override Direction RestrictedDirection => new Right();
    }

    public class Right : Direction
    {
        internal override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(1, 0);
        internal override Direction RestrictedDirection => new Left();
    }
}
