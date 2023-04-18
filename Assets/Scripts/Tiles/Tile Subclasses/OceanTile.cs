using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;
using DonutStudios.Equipment;

namespace DonutStudios.Tiles
{
    internal class OceanTile : Tile
    {
        private protected override void Interact()
        {
            DirectMeterManager.Instance.ThirstLevel += Filter.DrinkEffectiveness;
        }
    }
}
