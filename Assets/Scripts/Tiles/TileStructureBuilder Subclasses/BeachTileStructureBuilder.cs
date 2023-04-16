using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class BeachTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos { get; } = new Vector2(14, 14);
        internal override Vector2 MaxCornerPos { get; } = new Vector2(113, 113);

        private protected override int Points => Random.Range(2, 4);

        private protected override void CreateStructures()
        {
            throw new System.NotImplementedException();
        }
    }
}
