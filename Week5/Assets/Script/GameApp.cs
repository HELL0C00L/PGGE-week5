using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//also can use using PGGE.Patterns;
public class GameApp : PGGE.Patterns.Singleton<GameApp>
{
    private bool mPause = false;

    // easier to understand this function
    // hence refactoring.
    public void PauseGame(bool flag)
    {
        mPause = flag;
        //mOnPause?.Invoke(GamePaused)
        if (mPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //public bool GamePaused
    //{
    //    get { return mPause; }
    //    set
    //    {
    //        mPause = value;
    //        mOnPause?.Invoke(GamePaused);
    //        if (GamePaused)
    //        {
    //            Time.timeScale = 0;
    //        }
    //        else
    //        {
    //            Time.timeScale = 1;
    //        }
    //    }
    //}

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame(!mPause);
        }

    }
}
