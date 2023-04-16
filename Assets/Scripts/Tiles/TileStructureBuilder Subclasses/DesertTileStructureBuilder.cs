using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class DesertTileStructureBuilder : TileStructureBuilder
    {
        internal override Vector2 MinCornerPos => new Vector2(14, 14);
        internal override Vector2 MaxCornerPos => new Vector2(113, 113);
        [SerializeField] private int _minLength, _maxLength;

        private protected override int Points => Random.Range(2, 4);

        private protected override void CreateStructures()
        {
            for (int i = 0; i < Structures.Length; i++)
            {
                Vector2 spawnPoint = new Vector2(Random.Range((int)MinCornerPos.x, (int)MinCornerPos.x + 1), Random.Range(MinCornerPos.y, MaxCornerPos.y + 1));

                TileStructure structure = Instantiate(TileStructure, spawnPoint, Quaternion.identity);

                structure.Width = Random.Range(_minLength, _maxLength + 1);
                structure.Height = Random.Range(_minLength, _maxLength + 1);
                structure.Parent = this;

                Structures[i] = structure;
            }
        }
    }
}
