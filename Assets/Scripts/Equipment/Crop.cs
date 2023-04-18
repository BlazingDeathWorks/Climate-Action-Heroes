using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Equipment
{
    internal class Crop : Equipment
    {
        public float GrowingSpeed { get; set; } = 1;
        [SerializeField] private float _growingRate = 60;
        [SerializeField] private int _cropsPerGrowth = 2;
        private float _timeSinceLastGrowth;


        private void Update()
        {
            _timeSinceLastGrowth += Time.deltaTime * GrowingSpeed;

            if (_timeSinceLastGrowth >= _growingRate)
            {
                _timeSinceLastGrowth = 0;
                //Grow crops
                ItemManager.Instance.IncreaseCrop(_cropsPerGrowth);
            }
        }
    }
}
