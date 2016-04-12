using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour {

    private Image menu_back;
    private Image play;
    private Image pause;
    public Image dead;


    void Start () {
        menu_back = GameObject.Find("Menu_Back").GetComponent<Image>();
        play = GameObject.Find("Play").GetComponent<Image>();
        pause = GameObject.Find("Pause").GetComponent<Image>();
        dead = GameObject.Find("Dead").GetComponent<Image>();

        menu_back.enabled = true;
        play.enabled = true;
        pause.enabled = false;
        dead.enabled = false;

        Time.timeScale = 0;
    }
	
	


    public void StartButton()
    {
        menu_back.enabled = false;
        play.enabled = false;
        pause.enabled = true;

        Time.timeScale = 1;
    }
}
