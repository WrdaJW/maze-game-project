using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshBoxSpawn : MonoBehaviour
{
    public GameObject[] Boxs;
    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        Boxs = ShuffleArray(Boxs);
        for(int i=0; i<6; i++)
        {
            Instantiate(Boxs[i], positions[i].position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private T[] ShuffleArray<T>(T[] array)
    {
        int random1, random2;
        T temp;

        for (int i = 0; i < array.Length; ++i)
        {
            random1 = Random.Range(0, array.Length);
            random2 = Random.Range(0, array.Length);

            temp = array[random1];
            array[random1] = array[random2];
            array[random2] = temp;
        }

        return array;
    }
}
