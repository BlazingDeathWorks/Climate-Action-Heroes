using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Equipment
{
    internal class PowerPlant : Equipment
    {
        [SerializeField] private int _carbonBlowUp = 30;
        [SerializeField] private int _generatingElectricity = 20;
        private float _timeSinceLastGeneration = 60;

        private void Update()
        {
            if (!IsFunctional) return;

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
            DirectMeterManager.Instance.TemperatureLevel += _carbonBlowUp;
            DirectMeterManager.Instance.UpdateTemperature();
            DirectMeterManager.Instance.ClampAllValues();
        }
    }
}
