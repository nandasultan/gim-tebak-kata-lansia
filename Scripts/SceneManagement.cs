using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void changeScene(string nama)
    {
        SceneManager.LoadScene(nama);
    }
    public void QuitGame()
    {
        // Hanya berfungsi pada build aplikasi (bukan di dalam Unity Editor)
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
