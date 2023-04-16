using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class SpaceTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos { get; } =  new Vector2(0, 0);
        internal override Vector2 MaxCornerPos { get; } = new Vector2(63, 63);

        private protected override int Points => 4;
        private Vector2[] _pointPositions;

        private protected override void Awake()
        {
            HalfPos = (int)MaxCornerPos.x / 2;
            _pointPositions = new Vector2[] { new Vector2(0, HalfPos), new Vector2(62, HalfPos), new Vector2(HalfPos, 0), new Vector2(HalfPos, 62) };
            base.Awake();
        }

        private protected override void CreateStructures()
        {
            for (int i = 0; i < Points; i++)
            {
                TileStructure structure = Instantiate(TileStructure, _pointPositions[i], Quaternion.identity);

                //Set structure point size
                structure.Width = (structure.transform.position.y == HalfPos) ? ChildBuilder.MinCornerPos.x : MaxCornerPos.x;
                structure.Height = (structure.transform.position.x == HalfPos) ? ChildBuilder.MinCornerPos.y : MaxCornerPos.y;
                structure.Parent = this;

                Structures[i] = structure;
            }
        }
    }
}
