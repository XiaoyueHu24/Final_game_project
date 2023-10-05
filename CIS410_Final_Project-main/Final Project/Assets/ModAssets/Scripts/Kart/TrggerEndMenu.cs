using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrggerEndMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int TriggerTimes = 0;
    void OnTriggerEnter(Collider other) 
    {
        TriggerTimes = TriggerTimes + 1;
        if (TriggerTimes >= 2 && mapTrigger.map_Trigger == 1)
        {
            SceneManager.LoadScene("EndMenu");
        }
    }
}
