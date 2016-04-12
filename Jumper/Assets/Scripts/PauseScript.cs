using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PauseScript : MonoBehaviour {

    private bool isPause = false;
    private Image pauseIm;
    public Sprite onPause;
    public Sprite offPause;


    void Start () {
        pauseIm = GameObject.Find("Pause").GetComponent<Image>();

	}
	
	public void Pause()
    {
        isPause = !isPause;

        if (isPause){
            pauseIm.sprite = onPause;
            Time.timeScale = 0;
        }

        else
        {
            pauseIm.sprite = offPause;
            Time.timeScale = 1;
        }
    }

    

}
