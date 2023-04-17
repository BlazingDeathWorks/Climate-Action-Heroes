using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Channels;

namespace DonutStudios.Tiles
{
    internal class TileManager : MonoBehaviour
    {
        internal static TileManager Instance { get; private set; }
        [SerializeField] private ActionChannel _tileBuildFinished;
        [SerializeField] private ActionChannel _tileWipeFinished;
        [SerializeField] private int _checks;
        private int _checkCount;

        private void Awake()
        {
            Instance = this;
        }

        private IEnumerator FinishWipe()
        {
            yield return new WaitForSecondsRealtime(5f);
            _tileWipeFinished.CallAction();
        }

        public void AddCheck()
        {
            _checkCount++;
            if (_checkCount >= _checks)
            {
                Debug.Log("fc");
                _tileBuildFinished.CallAction();
                FinishWipe();
            }
        }
    }
}
