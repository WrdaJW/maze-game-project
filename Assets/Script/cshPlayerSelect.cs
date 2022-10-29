using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshPlayerSelect : MonoBehaviour
{
    
    public Camera cam;
    public GameObject[] players;
    public GameObject SpawnPoint;
    public int selection = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.transform.gameObject);
                if (hit.transform.gameObject.tag == "FirstPlayerSelect")
                {
                    Debug.Log(hit.transform.gameObject);
                    GameObject.Find("Singleton").GetComponent<cshPlayerSpawn>().selection = 0;
                    //Instantiate(players[selection], SpawnPoint.transform);
                    SceneManager.LoadScene("SampleScene");
                }
                    
                else if(hit.transform.gameObject.tag == "SecondPlayerSelect")
                {
                    Debug.Log(hit.transform.gameObject);
                    GameObject.Find("Singleton").GetComponent<cshPlayerSpawn>().selection = 1;
                    //Instantiate(players[selection], SpawnPoint.transform);
                    SceneManager.LoadScene("SampleScene");
                }


            }
        }
       

    }
}
