using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//also can use using PGGE.Patterns;
public class GameApp : PGGE.Patterns.Singleton<GameApp>
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
