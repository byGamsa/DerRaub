using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.IO;

public class QuiickStartLobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject quickStartButton;
    [SerializeField]
    private GameObject quickCancelButton;
    [SerializeField]
    private int RoomSize;

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        quickStartButton.SetActive(true);
    }

    
    public void QuickStart()
    {
        quickCancelButton.SetActive(true);
        quickStartButton.SetActive(false);
        PhotonNetwork.JoinRandomRoom();
        print("Joined room");
        QuickStart();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        print("Failed to join a room, we are creating on now");
        CreateRandomRoom();
    }

    public void CreateRandomRoom()
    {
        int roomNumber = Random.Range(0, 500);
        RoomOptions roomOptions = new RoomOptions() {IsVisible = true, IsOpen = false, MaxPlayers = (byte)roomNumber};
        PhotonNetwork.CreateRoom("Room " + roomNumber, roomOptions);

    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Failed to create room...Trying again");
        CreateRandomRoom();
    }

    public void QuickCancel()
    {
        PhotonNetwork.LeaveLobby();
        
    }

  
}
