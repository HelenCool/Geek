using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text counterText;

    public float seconds, minutes, recordMinutes, recordSeconds;
    //public float record1, record2;
    public float scoreSeconds, scoreMinutes;


    void Start()
    {
        counterText = GetComponent<Text>() as Text;

        //recordMinutes = minutes;
        //recordSeconds = seconds;
       // PlayerPrefs.SetFloat("saveMinutes", 99);
       // PlayerPrefs.SetFloat("saveSeconds", 99);
       // recordMinutes = PlayerPrefs.GetFloat("saveMinutes");
        //recordSeconds = PlayerPrefs.GetFloat("saveSeconds");


    }

    void Update()
    {
        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);

        if (minutes <= recordMinutes || recordMinutes == 0)
        {
            PlayerPrefs.SetFloat("saveMinutes", minutes);
        }

        if (seconds <= recordSeconds || recordSeconds == 0)
        {
            PlayerPrefs.SetFloat("saveSeconds", seconds);
        }

        recordMinutes = PlayerPrefs.GetFloat("saveMinutes");
        recordSeconds = PlayerPrefs.GetFloat("saveSeconds");

        counterText.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00") + "\nRecord: " + recordMinutes.ToString("00") + ":" + recordSeconds.ToString("00");
    }
}




   
