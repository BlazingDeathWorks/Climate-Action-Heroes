using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using FutureInspireGames.Singleton;

namespace DonutStudios.Meters
{
    internal class SceneController : Singleton<SceneController>
    {
        private IEnumerator LoadAsyncScene(int index)
        {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);
            if (LoadManager.Instance.LoadingText != null)
            {
                LoadManager.Instance.LoadingText.gameObject.SetActive(true);
            }

            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }

        public void NextSceneAsync()
        {
            StartCoroutine(LoadAsyncScene(SceneManager.GetActiveScene().buildIndex + 1));
        }

        public void PreviousScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
