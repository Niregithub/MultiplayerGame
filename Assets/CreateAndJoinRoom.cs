using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{

    public InputField createInput;
    public InputField joinInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        //base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("SampleScene");
    }

}
