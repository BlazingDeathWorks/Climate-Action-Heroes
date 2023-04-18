using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Equipment
{
    internal class SolarPanel : Equipment
    {
        [SerializeField] private int _generatingElectricity = 5;
        private float _timeSinceLastGeneration = 60;

        private void Update()
        {
            _timeSinceLastGeneration += Time.deltaTime;
            if (_timeSinceLastGeneration >= 60)
            {
                _timeSinceLastGeneration = 0;
                ElectricityManager.Instance.ElectricityAvailable += _generatingElectricity;
                ElectricityManager.Instance.UpdateElectricitySlider();
                ElectricityManager.Instance.ClampElectricityAmount();
            }
        }

        public override void PlaceDown(GameObject tile, string layerName)
        {
            if (!CheckTileLayer(layerName) || !CheckCosts())
            {
                Destroy(gameObject);
                return;
            }
            Destroy(tile);
            gameObject.SetActive(true);
        }
    }
}
