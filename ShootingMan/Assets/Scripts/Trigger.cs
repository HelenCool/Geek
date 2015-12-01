using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    public Light Lamp;
    public Renderer R;
    private Character myOtherClass;
    public static int score = 0;
    public int plusScore = 10;
    public bool check;
    public float countdown = 30.0f;


    void Start()
    {

    }

 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet" && gameObject.tag == "Lamp")
        {
            Debug.Log("Trigger");
            Lamp.color = Color.red;
            R.material.color = Color.red;
            check = true;
            score += plusScore;
            Invoke("ColorWhite", 1.5f);

        }

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), "Score: " +  score);
    }

    void Update()
    {
        /*countdown -= Time.deltaTime;
        if (check == true)
        {
            if (countdown <= 0.0f)
            {
                Lamp.color = Color.white;
                R.material.color = Color.white;
                check = false;
            }
            }*/
        
    }
    void ColorWhite()
    {
        Lamp.color = Color.white;
        R.material.color = Color.white;
        check = false;
    }
    
}
