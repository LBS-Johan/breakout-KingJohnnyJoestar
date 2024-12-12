using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class seeManiger : MonoBehaviour
{
    public void LoadMainGame()
    {
        Score.score = 0;
        SceneManager.LoadScene(1);
    }
}