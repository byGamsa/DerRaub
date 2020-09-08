using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

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
    public override void OnEnable()
    {
        
    }
    
    public void QuickStart()
    {
        quickCancelButton.SetActive(true);
        quickStartButton.SetActive(false);
        PhotonNetwork.JoinRandomRoom();
        print("Joined room");
    }

    public void OnJoinRadnomFailed(short returnCode, string message)
    {
        print("Failed to join a room, we are creating on now");
    }

    public void CreateRandomRoom()
    {
        int roomNumer = Random.Range(0, 500);
        RoomOptions roomOptions = new RoomOptions() {IsVisible = true, IsOpen = false, MaxPlayers = (byte)roomNumer};
        PhotonNetwork.CreateRoom("Room " + roomNumer, roomOptions);

    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Failed to create room...Trying again");
        CreateRandomRoom();
    }

    public override void OnDisable() 
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
