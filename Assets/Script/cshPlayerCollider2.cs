using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshPlayerCollider2 : MonoBehaviour
{
    GameObject Troll;
    GameObject keyObject;
    GameObject HpObject;
    public GameObject EndingUI;
    public GameObject BadEndingUI;

    public GameObject[] buttons;
    public GameObject[] Debufs;

    //public GameObject[] hearts;
    public Vector2 first_Button_position;
    public Vector2 second_Button_position;
    public Vector2 debuf_position;

    public int HP = 3;
    public int KEY = 0;
    public int Weapon_Durability = 1;


    void Start()
    {

        first_Button_position = new Vector2(GameObject.Find("Canvas").transform.position.x + 200, GameObject.Find("Canvas").transform.position.y);
        second_Button_position = new Vector2(GameObject.Find("Canvas").transform.position.x - 200, GameObject.Find("Canvas").transform.position.y);
        debuf_position = new Vector2(GameObject.Find("Canvas").transform.position.x, GameObject.Find("Canvas").transform.position.y);
        Troll = GameObject.Find("Monster");
        HpObject = GameObject.Find("HP");
        keyObject = GameObject.Find("Key");
        GameObject.Find("duability").GetComponent<Text>().text = "X  " + Weapon_Durability.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SelectableObj")
        {
            Destroy(collision.gameObject);
        }
    }*/
    private void getEnding()
    {
        if (HP <= 0)
        {
            Debug.Log("ending");
            GameObject BadEnding = Instantiate(BadEndingUI, GameObject.Find("Canvas").transform);
            Time.timeScale = 0;
        }
    }
    private void knockback()
    {
        float power = 200.0f;
        Vector3 dir = new Vector3(0, 0, -1);
        dir = dir.normalized;
        gameObject.GetComponent<Rigidbody>().AddForce(dir * power);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DebufBox")
        {

            int Debuf_num = Random.Range(0, 4);


            GameObject MakeDebuf = Instantiate(Debufs[Debuf_num], debuf_position, Quaternion.identity, GameObject.Find("Canvas").transform) as GameObject;


            Destroy(other.gameObject);
            getEnding();
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Troll")
        {
            if (Weapon_Durability == 0)
            {
                HP--;
                HpObject.GetComponent<cshHpControl>().HpDown();
                getEnding();
                knockback();
            }
            else
            {
                Weapon_Durability = 0;
                GameObject.Find("duability").GetComponent<Text>().text = "X  " + Weapon_Durability.ToString();
            }
        }

        if (other.gameObject.tag == "Key")
        {
            keyObject.GetComponent<cshKeyControl>().KeyUp();
            KEY++;
            Troll.GetComponent<cshTrollControl>().speedUp();
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "ItemBox")
        {

            int firstButton_idx = Random.Range(0, 4);
            int secondButton_idx = Random.Range(0, 4);

            while (firstButton_idx == secondButton_idx)
            {
                secondButton_idx = Random.Range(0, 4);
            }

            GameObject firstButton = Instantiate(buttons[firstButton_idx], first_Button_position, Quaternion.identity, GameObject.Find("Canvas").transform) as GameObject;
            GameObject secondButton = Instantiate(buttons[secondButton_idx], second_Button_position, Quaternion.identity, GameObject.Find("Canvas").transform) as GameObject;

            Destroy(other.gameObject);
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Slime")
        {
            if (Weapon_Durability == 0)
            {
                HP--;
                HpObject.GetComponent<cshHpControl>().HpDown();
                getEnding();
            }

            else
            {
                Weapon_Durability--;
                HpObject.GetComponent<cshHpControl>().HpUp();
                HP++;
                GameObject.Find("duability").GetComponent<Text>().text = "X  " + Weapon_Durability.ToString();
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Door")
        {
            if (KEY == 3)
            {
                GameObject Ending = Instantiate(EndingUI, GameObject.Find("Canvas").transform);
                Time.timeScale = 0;
            }
        }
    }



}

