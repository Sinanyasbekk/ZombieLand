using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInstantiate : MonoBehaviour
{
    public GameObject[] spawners;
    void OnJoinedRoom()
    {
        int r = Random.Range(0, spawners.Length);
        PhotonNetwork.Instantiate("Player", spawners[r].transform.position, transform.rotation,0);
    }
}
