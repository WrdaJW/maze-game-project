using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSpawn : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(players[GameObject.Find("Singleton").GetComponent<cshPlayerSpawn>().selection], SpawnPoint.position, SpawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        Instantiate(players[GameObject.Find("Singleton").GetComponent<cshPlayerSpawn>().selection], SpawnPoint.position, SpawnPoint.rotation);
    }
}
