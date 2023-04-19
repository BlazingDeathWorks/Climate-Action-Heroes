using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    internal class LoadManager : MonoBehaviour
    {
        public static LoadManager Instance;
        public Text LoadingText;

        private void Awake()
        {
            Instance = this;
        }
    }
}
