using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueGame : MonoBehaviour
{
    public void RebootGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
