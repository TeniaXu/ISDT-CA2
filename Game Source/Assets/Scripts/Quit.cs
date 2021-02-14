using UnityEngine;

public class Quit : MonoBehaviour
{

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        //on click will quit the app.
        Application.Quit();
    }
}