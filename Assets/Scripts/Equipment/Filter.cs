using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Equipment
{
    //Increases the effectiveness of drinking water - you can drink water from the ocean
    public class Filter : Equipment
    {
        //Drink effectiveness
        //Drink effectiveness increase
        public static int DrinkEffectiveness { get; set; } = 1;
        [SerializeField] private int _drinkEffectIncrease = 10;

        public override void PlaceDown(GameObject tile, string layerName)
        {
            if (!CheckTileLayer(layerName) || !CheckCosts())
            {
                Destroy(gameObject);
                return;
            }
            Destroy(tile);
            gameObject.SetActive(true);
            DrinkEffectiveness += _drinkEffectIncrease;
        }
    }
}
