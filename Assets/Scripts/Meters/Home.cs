using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Meters
{
    internal class Home : MonoBehaviour
    {
        [SerializeField] private float _humanSpawnRate = 180;
        [SerializeField] private float _decreaseIncrement = 0.5f;
        private float _timeSinceLastHumanSpawned;

        private void Update()
        {
            _timeSinceLastHumanSpawned += Time.deltaTime;

            if (_timeSinceLastHumanSpawned >= _humanSpawnRate)
            {
                _timeSinceLastHumanSpawned = 0;
                DirectMeterManager.Instance.IncrementDecreaseSpeed(_decreaseIncrement);
            }
        }

        private void OnMouseDown()
        {
            DirectMeterManager.Instance.HungerLevel += ItemManager.Instance.GetMeat();
        }
    }
}
