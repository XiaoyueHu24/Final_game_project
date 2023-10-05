using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapTrigger : MonoBehaviour
{
    public static int map_Trigger = 0;
    // Start is called before the first frame update
    void Start()
    {
        map_Trigger = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        map_Trigger = 1;
    }
}
