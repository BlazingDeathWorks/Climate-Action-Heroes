using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Tiles
{
    internal class GrasslandTile : Tile
    {
        [SerializeField] private ForestTile _forestTile;

        private protected override void Interact()
        {
            Destroy(gameObject);
            Instantiate(_forestTile, new Vector3(transform.position.x, transform.position.y, -5), Quaternion.identity);
            DirectMeterManager.Instance.TemperatureLevel -= 3;
            DirectMeterManager.Instance.UpdateTemperature();
            DirectMeterManager.Instance.ClampAllValues();
        }
    }
}
