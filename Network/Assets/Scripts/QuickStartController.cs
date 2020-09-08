﻿using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class QuickStartController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private int multiplayerSceneIndex;


    public override void OnEnable() 
    {
        PhotonNetwork.AddCallbackTarget(this);
    }
    
    public override void OnDisable() 
    {
        PhotonNetwork.RemoveCallbackTarget(this);    
    }
    public override void OnJoinedRoom()
    {
        print("Joined Room");
        StartGame();
    }
    private void StartGame()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel(multiplayerSceneIndex);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
