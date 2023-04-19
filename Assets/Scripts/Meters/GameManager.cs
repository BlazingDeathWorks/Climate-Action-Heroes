using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    //Game Flow and Score Manager
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        [SerializeField] private GameObject _gameOverOverlay;
        [SerializeField] private Text _scoreText;
        [SerializeField] private Text _highScoreText;
        private const string HIGH_SCORE = "High Score";
        private int _score;

        private void Awake()
        {
            Instance = this;
        }

        [ContextMenu("Reset High Score")]
        private void ResetHighScore()
        {
            PlayerPrefs.SetInt(HIGH_SCORE, 0);
        }

        private int GetHighScore()
        {
            int currentHighScore = PlayerPrefs.GetInt(HIGH_SCORE);
            if (_score <= currentHighScore) return currentHighScore;
            PlayerPrefs.SetInt(HIGH_SCORE, _score);
            return _score;
        }

        public void AddScore(int score)
        {
            _score += score;
        }

        public void GameOver()
        {
            if (_gameOverOverlay == null) return;
            _scoreText.text = $"Score: {_score}";
            _highScoreText.text = $"High Score: {GetHighScore()}";
            _gameOverOverlay.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
