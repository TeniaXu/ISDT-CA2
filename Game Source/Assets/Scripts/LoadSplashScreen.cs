using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadSplashScreen : MonoBehaviour
{
    #region PUBLIC_MEMBERS
    // calling the public float for how long the loading delay will be
    public float loadingDelay = 5.0F;
    #endregion //PUBLIC_MEMBERS


    #region MONOBEHAVIOUR_METHODS
    void Start()
    {
        StartCoroutine(LoadNextSceneAfter(loadingDelay));
    }
    #endregion //MONOBEHAVIOUR_METHODS


    #region PRIVATE_METHODS
    //after the delay will load the next scene in the build according to the buildindex
    private IEnumerator LoadNextSceneAfter(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
    #endregion //PRIVATE_METHODS
}

