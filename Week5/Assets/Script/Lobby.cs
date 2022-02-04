using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Lobby : MonoBehaviour
{
    [SerializeField]
    InputField InputName;
    [SerializeField]
    Button ButtonName;
    [SerializeField]
    Text ConnectionText;

    private string mPlayerName;

    // Start is called before the first frame update
    void Start()
    {
        //ButtonName.onClick.AddListener(delegate ()
        //{
        //    OnClick_JoinRoom();
        //});
    }

    public void OnClick_JoinRoom()
    {
        ConnectionText.gameObject.SetActive(true);
        //mPlayerName = InputName.text;
        //PhotonNetwork.NickName = InputName.text;

        // now we will make a connection to the server using
        // PUN callbacks.
        Debug.Log("to do");
        Debug.Log("Hello " + PhotonNetwork.NickName);
    }
}
