using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int randomX = Random.Range(-8, +8);
        PhotonNetwork.Instantiate("Player", new Vector3(randomX, 4, 0), Quaternion.identity, 0);
    }
}
