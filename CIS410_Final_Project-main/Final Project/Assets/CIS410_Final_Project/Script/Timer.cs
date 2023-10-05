using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public static float TimeRemain;

    public Text TimerTxt;
   
    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                TimeRemain = TimeLeft;
                updateTimer(TimeLeft);
            }
            else
            {
                //Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                SceneManager.LoadScene("EndMenu");
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public static float returnTime()
    {
        return TimeRemain;
    }

}