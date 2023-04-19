using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    public class DirectMeterManager : MonoBehaviour
    {
        public static DirectMeterManager Instance;
        public float HungerLevel { get; set; } 
        public float ThirstLevel { get; set;}
        public float TemperatureLevel { get; set; }
        [SerializeField] private float _decreaseSpeed = 1;
        [SerializeField] private Slider _hungerBar;
        [SerializeField] private Slider _thirstBar;
        [SerializeField] private Slider _temperatureBar;

        private void Awake()
        {
            Instance = this;
            HungerLevel = _hungerBar.maxValue;
            ThirstLevel = _thirstBar.maxValue;
        }

        private void Update()
        {
            HungerLevel -= _decreaseSpeed * Time.deltaTime;
            ThirstLevel -= _decreaseSpeed * Time.deltaTime;

            _hungerBar.value = HungerLevel;
            _thirstBar.value = ThirstLevel;

            //Check end condition for hunger and thirst
            if (HungerLevel <= 0 || ThirstLevel <= 0)
            {
                GameManager.Instance.GameOver();
            }
        }

        public void ClampAllValues()
        {
            HungerLevel = Mathf.Clamp(HungerLevel, 0, _hungerBar.maxValue);
            ThirstLevel = Mathf.Clamp(ThirstLevel, 0, _thirstBar.maxValue);
            TemperatureLevel = Mathf.Clamp(TemperatureLevel, 0, _temperatureBar.maxValue);
        }

        public void UpdateTemperature()
        {
            _temperatureBar.value = TemperatureLevel;
            //Check end condition for temperature
            if (TemperatureLevel >= _temperatureBar.maxValue)
            {
                GameManager.Instance.GameOver();
            }
        }

        public void IncrementDecreaseSpeed(float value)
        {
            _decreaseSpeed += value;
        }
    }
}
