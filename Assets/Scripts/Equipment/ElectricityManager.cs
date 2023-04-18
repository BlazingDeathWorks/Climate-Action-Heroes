using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FutureInspireGames.Singleton;

namespace DonutStudios.Equipment
{
    internal class ElectricityManager : Singleton<ElectricityManager>
    {
        internal int ElectricityAvailable { get; set; }
        [SerializeField] private Slider _electricitySlider;

        protected override void Awake()
        {
            base.Awake();
            ElectricityAvailable = (int)_electricitySlider.maxValue;
            UpdateElectricitySlider();
        }

        public void UpdateElectricitySlider()
        {
            _electricitySlider.value = ElectricityAvailable;
        }

        public void ClampElectricityAmount()
        {
            ElectricityAvailable = Mathf.Clamp(ElectricityAvailable, 0, (int)_electricitySlider.maxValue);
        }
    }
}
