using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshKeyControl : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        /*
        for (int i = 0; i < player.GetComponent<cshPlayerCollider>().HP; i++)
        {
            GameObject.Find("HP").transform.GetChild(i).gameObject.SetActive(true);
        }
       */
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void KeyUp()
    {
        int key = player.GetComponent<cshPlayerCollider>().KEY;
        GameObject.Find("Key").transform.GetChild(key).gameObject.SetActive(true);
    }

    public void KeyDown()
    {
        int key = player.GetComponent<cshPlayerCollider>().KEY;
        GameObject.Find("Key").transform.GetChild(key).gameObject.SetActive(false);
    }
}
