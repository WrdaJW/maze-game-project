using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Navmeshmove : MonoBehaviour
{
    public Camera mainCam;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                GetComponent<NavMeshAgent>().destination = hit.point;
            }
        }
    }
}

