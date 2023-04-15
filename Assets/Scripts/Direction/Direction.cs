using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Direction
{
    public abstract class Direction
    {
        public abstract Vector2 NormalizedDirection { get; private protected set; }
        internal abstract Direction RestrictedDirection { get; }
        private static Direction[] s_directions = new Direction[] { new Up(), new Down(), new Left(), new Right() };

        public static Direction RandomizeDirection(Direction currentDir)
        {
            Direction randomDir;
            do
            {
                randomDir = s_directions[Random.Range(0, s_directions.Length)];
            } while (randomDir.GetType() == currentDir.RestrictedDirection.GetType());
            return randomDir;
        }
    }

    public class Up : Direction
    {
        public override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(0, 1);
        internal override Direction RestrictedDirection => new Down();
    }

    public class Down : Direction
    {
        public override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(0, -1);
        internal override Direction RestrictedDirection => new Up();
    }

    public class Left : Direction
    {
        public override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(-1, 0);
        internal override Direction RestrictedDirection => new Right();
    }

    public class Right : Direction
    {
        public override Vector2 NormalizedDirection { get; private protected set; } = new Vector2(1, 0);
        internal override Direction RestrictedDirection => new Left();
    }
}
