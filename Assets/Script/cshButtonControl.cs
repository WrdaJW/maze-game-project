using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshButtonControl : MonoBehaviour
{
    GameObject HpObject;
    GameObject player;
    GameObject Troll;
    private Text myText;
    // Start is called before the first frame update
    void Start()
    {
        Troll = GameObject.Find("Monster");
        HpObject = GameObject.Find("HP");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpeedDown()
    {
        player.GetComponent<cshPlayerMoveControl>().m_moveSpeed = player.GetComponent<cshPlayerMoveControl>().m_moveSpeed - 1.0f;
        if(player.GetComponent<cshPlayerMoveControl>().m_moveSpeed <= 0)
        {
            player.GetComponent<cshPlayerMoveControl>().m_moveSpeed = 1.0f;
        }

        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }

    public void lossHp()
    {
        player.GetComponent<cshPlayerCollider>().HP--;
        HpObject.GetComponent<cshHpControl>().HpDown();
        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;


    }

    public void TrollSpeedUp()
    {
        Troll.GetComponent<cshTrollControl>().speedUp();
        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }

    public void lossWeapon()
    {
        player.GetComponent<cshPlayerCollider>().Weapon_Durability = player.GetComponent<cshPlayerCollider>().Weapon_Durability - 2;

        if(player.GetComponent<cshPlayerCollider>().Weapon_Durability<=0)
        {
            player.GetComponent<cshPlayerCollider>().Weapon_Durability = 0;
        }

        GameObject.Find("duability").GetComponent<Text>().text = "X  " + player.GetComponent<cshPlayerCollider>().Weapon_Durability.ToString();

        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();
        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }
    public void SpeedUp()
    {
        player.GetComponent<cshPlayerMoveControl>().m_moveSpeed = player.GetComponent<cshPlayerMoveControl>().m_moveSpeed + 2.0f;
        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }

    public void getHp()
    {
        HpObject.GetComponent<cshHpControl>().HpUp();
        player.GetComponent<cshPlayerCollider>().HP++;
        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }

    public void TrollSpeedDown()
    {
        Troll.GetComponent<cshTrollControl>().speedDown();
        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();

        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }
    public void getWeapon()
    {
        player.GetComponent<cshPlayerCollider>().Weapon_Durability = player.GetComponent<cshPlayerCollider>().Weapon_Durability + 3;
        GameObject.Find("duability").GetComponent<Text>().text = "X  " + player.GetComponent<cshPlayerCollider>().Weapon_Durability.ToString();

        Transform[] childList = GameObject.Find("Canvas").GetComponentsInChildren<Transform>();
        for (int i = 1; i < childList.Length; i++)
        {
            Destroy(childList[i].gameObject);
        }
        Time.timeScale = 1;
    }

    public void Exit() 
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }





}
