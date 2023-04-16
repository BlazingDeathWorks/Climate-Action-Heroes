using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class GrasslandTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos => new Vector2(14, 14);
        internal override Vector2 MaxCornerPos => new Vector2(49, 49);
        [SerializeField] private int _minLength, _maxLength;

        private protected override int Points => 1;

        private protected override void CreateStructures()
        {
            Vector2 spawnPoint = new Vector2(Random.Range((int)MinCornerPos.x, (int)MinCornerPos.x + 1), Random.Range(MinCornerPos.y, MaxCornerPos.y + 1));

            TileStructure structure = Instantiate(TileStructure, spawnPoint, Quaternion.identity);

            structure.Width = Random.Range(_minLength, _maxLength + 1);
            structure.Height = Random.Range(_minLength, _maxLength + 1);
            structure.Parent = this;

            Structures[0] = structure;
        }
    }
}
