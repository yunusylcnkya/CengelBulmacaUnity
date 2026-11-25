using UnityEngine;
using UnityEngine.SceneManagement;

namespace CengelBulmaca.Core
{
    public sealed class AppBootstrap : MonoBehaviour
    {
        [SerializeField] private string mainMenuScene = "MainMenu";

        private void Start()
        {
            if (!Application.CanStreamedLevelBeLoaded(mainMenuScene))
            {
                Debug.LogError(
                    $"'{mainMenuScene}' yüklenemiyor. Build Profiles içindeki " +
                    "etkin sahne listesini kontrol et.",
                    this);
                return;
            }

            SceneManager.LoadSceneAsync(mainMenuScene);
        }
    }
}