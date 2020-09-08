using System.Collections;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
