using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class ForestTile : Tile
    {
        private protected override void Interact()
        {
            Debug.Log("Forest");
        }
    }
}
