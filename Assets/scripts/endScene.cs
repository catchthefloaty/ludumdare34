using UnityEngine;
using System.Collections;

public class endScene : MonoBehaviour {
    public UnityEngine.UI.Text text;
	// Use this for initialization
	void Start () {
        string ending = GameObject.FindGameObjectWithTag("end").GetComponent<end>().ending;
        if(ending == "anger")
        {
            text.text = "The flames consume you";
        }
        else if(ending == "anxious")
        {
            text.text = "Drowning yourself solves nothing";
        }
        else if (ending == "sad")
        {
            text.text = "Tears solve no problems";
        }
        else if (ending == "death")
        {
            text.text = "You give up and wither away";
        }
        else if (ending == "life")
        {
            text.text = "Bright outlook has spared you";
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Press()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }
}
