using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using Photon.Realtime;

public class GameSetupController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreatePlayer()
    {
        PhotonNetwork.Instantiate(Path.Combine("FPSController"), Vector3.zero, Quaternion.identity);   
    }
}
