using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class BeachTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos { get; } = new Vector2(14, 14);
        internal override Vector2 MaxCornerPos { get; } = new Vector2(113, 113);

        private protected override int Points => 1;

        private protected override void Awake()
        {
            HalfPos = Mathf.RoundToInt((MaxCornerPos.x - MinCornerPos.x) / 2);
            base.Awake();
        }

        private protected override void CreateStructures()
        {
            Structures[0] = Instantiate(TileStructure, new Vector2(HalfPos, HalfPos), Quaternion.identity);

            Structures[0].Width = MaxCornerPos.x + 1;
            Structures[0].Height = MaxCornerPos.y;
            Structures[0].Parent = this;
        }
    }
}
