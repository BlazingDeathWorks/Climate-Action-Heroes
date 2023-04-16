using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    internal class DirectMeterManager : MonoBehaviour
    {
        [SerializeField] private float _decreaseSpeed = 1;
        [SerializeField] private Slider _hungerBar;
        [SerializeField] private Slider _thirstBar;
        private float _hungerLevel, _thirstLevel;

        private void Awake()
        {
            _hungerLevel = _hungerBar.maxValue;
            _thirstLevel = _thirstBar.maxValue;
        }

        private void Update()
        {
            _hungerLevel -= _decreaseSpeed * Time.deltaTime;
            _thirstLevel -= _decreaseSpeed * Time.deltaTime;

            _hungerBar.value = _hungerLevel;
            _thirstBar.value = _thirstLevel;
        }
    }
}
