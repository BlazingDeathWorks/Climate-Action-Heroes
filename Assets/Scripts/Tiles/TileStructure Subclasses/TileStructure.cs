using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal abstract class TileStructure : MonoBehaviour
    {
        internal float Width { private protected get; set; }
        internal float Height { private protected get; set; }
        [SerializeField] private protected Tile Tile;

        internal void Fill(TileStructureBuilder builder)
        {
            float tempWidth = (int)transform.position.x != builder.HalfPos ? (int)transform.position.x + Width : Width;
            float tempHeight = (int)transform.position.y != builder.HalfPos ? (int)transform.position.y + Height : Height + 1;
            for (int i = (int)transform.position.x == builder.HalfPos ? 0 : (int)transform.position.x; i < tempWidth; i++)
            {
                for (int j = (int)transform.position.y == builder.HalfPos ? 0 : (int)transform.position.y; j < tempHeight; j++)
                {
                    Instantiate(Tile, new Vector2(i, j), Quaternion.identity);
                }
            }
        }
    }
}
