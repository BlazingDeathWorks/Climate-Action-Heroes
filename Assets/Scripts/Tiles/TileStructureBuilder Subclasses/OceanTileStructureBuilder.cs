using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class OceanTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos { get; } = new Vector2(2, 2);
        internal override Vector2 MaxCornerPos { get; } = new Vector2(125, 125);

        private protected override int Points => 4;

        private protected override void CreateStructures()
        {
            
        }
    }
}
