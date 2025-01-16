using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameObject playerPrefab;

    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 RandomPos = new Vector3(playerPrefab.transform.position.x, playerPrefab.transform.position.y, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, RandomPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
