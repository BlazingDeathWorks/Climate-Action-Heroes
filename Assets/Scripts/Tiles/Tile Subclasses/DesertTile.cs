using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Tiles
{
    internal class DesertTile : Tile
    {
        private void OnDestroy()
        {
            GameManager.Instance.AddScore(50);
        }
    }
}
