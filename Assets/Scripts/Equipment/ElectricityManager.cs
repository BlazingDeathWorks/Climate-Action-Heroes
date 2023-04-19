using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DonutStudios.Equipment
{
    internal class ElectricityManager : MonoBehaviour
    {
        public static ElectricityManager Instance;
        internal int ElectricityAvailable { get; set; }
        [SerializeField] private Slider _electricitySlider;

        private void Awake()
        {
            Instance = this;
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
