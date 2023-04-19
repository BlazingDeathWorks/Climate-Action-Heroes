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
        private bool _complete = false;

        private void Update()
        {
            if (!IsFunctional) return;
            if (_complete) return;
            DrinkEffectiveness += _drinkEffectIncrease;
            _complete = true;
        }

        public override void PlaceDown(GameObject tile, string layerName)
        {
            if (!CheckTileLayer(layerName) || !CheckCosts())
            {
                Destroy(gameObject);
                return;
            }
            tile.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.SetActive(true);
        }
    }
}
