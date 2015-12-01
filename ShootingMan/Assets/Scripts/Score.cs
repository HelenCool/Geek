using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public int score = 0;
    public int plusScore = 10;
    

    
	
	/*void Update () {
        if (Trigger.FindSceneObjectsOfType(System.Boolean check ) == true) {
            score += plusScore;
        }
    }*/
    void OnGUI ()
    {
        //GUI.Label(new Rect(10, 10, 50, 20), "Score: " + Trigger.FindSceneObjectsOfType(System.Int32 score));
    }
}
