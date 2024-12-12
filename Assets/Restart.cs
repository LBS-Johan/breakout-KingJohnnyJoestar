using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            // transform.position = new Vector2(0, -3);
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(0);
        }
    }
}
