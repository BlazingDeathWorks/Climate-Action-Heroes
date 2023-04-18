using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Tiles
{
    internal class StoneTile : Tile
    {
        [SerializeField] private BeachTile _beachTile;

        private protected override void Interact()
        {
            base.Interact();
            Destroy(gameObject);
            ItemManager.Instance.IncreaseMetal(1);
            Instantiate(_beachTile, new Vector2((int)transform.position.x, (int)transform.position.y), Quaternion.identity);
        }
    }
}
