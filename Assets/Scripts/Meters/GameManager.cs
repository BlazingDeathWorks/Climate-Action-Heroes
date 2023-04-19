using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;

namespace DonutStudios.Meters
{
    //Game Flow and Score Manager
    internal class GameManager : Singleton<GameManager>
    {
        [SerializeField] private GameObject _gameOverOverlay;

        public void GameOver()
        {
            if (_gameOverOverlay == null) return;
            _gameOverOverlay.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
