using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal abstract class Tile : MonoBehaviour
    {
        internal TileStructureBuilder Parent { private protected get; set; }

        private void Start()
        {
            if (transform.position.x >= (int)Parent.MinCornerPos.x && transform.position.x <= (int)Parent.MaxCornerPos.x &&
                transform.position.y >= (int)Parent.MinCornerPos.y && transform.position.y <= (int)Parent.MaxCornerPos.y) return;
            Destroy(gameObject);
        }
    }
}
