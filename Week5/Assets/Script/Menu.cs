using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //we are going to add button clicks
    // from script instead of using the unity editor.
    [SerializeField]
    Button ButtonSingleP;
    [SerializeField]
    Button ButtonMultiP;

    private void Start()
    {
        ButtonSingleP.onClick.AddListener(delegate ()
        {
            onClick_SinglePlayer();
        });

        ButtonMultiP.onClick.AddListener(delegate ()
        {
            onClick_MultiPlayer();
        });
    }
    public void onClick_SinglePlayer()
    {
        Debug.Log("Loading Single Player");
        SceneManager.LoadScene("SinglePlayer");
    }

    public void onClick_MultiPlayer()
    {
        Debug.Log("Loading MultiPlayer");
        SceneManager.LoadScene("MultiPlayerLauncher");
    }
}
