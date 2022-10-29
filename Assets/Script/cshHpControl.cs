using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshHpControl : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        for (int i=0; i<player.GetComponent<cshPlayerCollider>().HP; i++)
        {
            GameObject.Find("HP").transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HpUp()
    {
        int hp = player.GetComponent<cshPlayerCollider>().HP;
        GameObject.Find("HP").transform.GetChild(hp).gameObject.SetActive(true);
    }

    public void HpDown()
    {        int hp = player.GetComponent<cshPlayerCollider>().HP;
        GameObject.Find("HP").transform.GetChild(hp).gameObject.SetActive(false);
    }
}
