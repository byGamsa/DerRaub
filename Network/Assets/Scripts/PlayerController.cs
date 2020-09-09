using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour, IPunObservable
{
    PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() 
    {
        photonView = GetComponent<PhotonView>(); 
        photonView.ObservedComponents.Add(this);

        if(!photonView.IsMine)
        {
            enabled = false;
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
 
            // We own this player: send the others our data
            stream.SendNext(transform.position); //position of the character
            stream.SendNext(transform.rotation); //rotation of the character
 
        }
        else
        {
            // Network player, receive data
            Vector3 syncPosition = (Vector3)stream.ReceiveNext(); 
            Quaternion syncRotation = (Quaternion)stream.ReceiveNext();
        }
    }
}

