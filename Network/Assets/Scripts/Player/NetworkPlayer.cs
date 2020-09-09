using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayer : MonoBehaviourPun /*IPunObservable*/
{
    public GameObject myCamera;

    private Vector3 correctPlayerPos;
    private Quaternion correctPlayerRot;

    // Start is called before the first frame update
    void Start()
    {

        if (photonView.IsMine)
        {
            //Kamera aktivieren
            myCamera.SetActive(true);
            //Steueung aktivieren
            GetComponent<PlayerMovement>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (!photonView.IsMine)
        //{
        //    transform.position = Vector3.Lerp(transform.position, this.correctPlayerPos, Time.deltaTime * 5);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, this.correctPlayerRot, Time.deltaTime * 5);
        //}
    }

    //public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    //{
    //    if (stream.IsWriting)
    //    {
    //        // We own this player: send the others our data
    //        stream.SendNext(transform.position);
    //        stream.SendNext(transform.rotation);

    //    }
    //    else
    //    {
    //        // Network player, receive data
    //        this.correctPlayerPos = (Vector3)stream.ReceiveNext();
    //        this.correctPlayerRot = (Quaternion)stream.ReceiveNext();
    //    }
    //}
}
