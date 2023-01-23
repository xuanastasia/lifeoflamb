using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wine : MonoBehaviour
{
    public GameObject Wine; 
    public float Speed; 

    void Start()
    {
        InvokeRepeating("Generate", 0, Speed);
    }

    void Generate()
    {
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);

        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x,y,0));
        Target.z = 0; 

        Instantiate(Wine, Target, Quaternion.identity);
    }
}
