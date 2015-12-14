using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
    world WorldObject;
    UnityEngine.UI.Image color;
    float delay = 3.0f;
    float curTime;
    bool pressed = false;
    GameObject button1;
    GameObject button2;


    // Use this for initialization
    void Start () {
        color = GetComponent<UnityEngine.UI.Image>();
        WorldObject = GameObject.FindGameObjectWithTag("world").GetComponent<world>();
        button1 = GameObject.FindGameObjectWithTag("button1");
        button2 = GameObject.FindGameObjectWithTag("button2");
    }
	
	// Update is called once per frame
	void Update () {
        if (pressed)
        {
            curTime += Time.deltaTime;
            if(curTime > delay)
            {
                pressed = false;
                curTime = 0;
                button1.GetComponent<UnityEngine.UI.Image>().enabled = true; 
                button1.GetComponent<UnityEngine.UI.Button>().enabled = true;
                button2.GetComponent<UnityEngine.UI.Image>().enabled = true;
                button2.GetComponent<UnityEngine.UI.Button>().enabled = true;


            }
        }

	
	}

    public void press()
    {
        button1.GetComponent<UnityEngine.UI.Image>().enabled = false;
        button1.GetComponent<UnityEngine.UI.Button>().enabled = false;
        button2.GetComponent<UnityEngine.UI.Image>().enabled = false;
        button2.GetComponent<UnityEngine.UI.Button>().enabled = false;
        pressed = true;
        WorldObject.GetComponent<AudioSource>().Stop();
        if (color.color == Color.magenta)
        {
            WorldObject.mood = "fear";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.yellow)
        {
            WorldObject.mood = "anxious";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.red)
        {
            WorldObject.mood = "anger";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.blue)
        {
            WorldObject.mood = "sad";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.green)
        {
            WorldObject.mood = "happy";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.grey)
        {
            WorldObject.mood = "death";
            WorldObject.turn += 1;

        }
        else if (color.color == Color.white)
        {
            WorldObject.mood = "life";
            WorldObject.turn += 1;

        }

    }
}
