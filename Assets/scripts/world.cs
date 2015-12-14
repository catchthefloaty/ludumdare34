using UnityEngine;
using System.Collections;

public class world : MonoBehaviour {
    public int turn;

    public string mood;
    GameObject button1;
    GameObject button2;
    UnityEngine.UI.Image screenColor;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public AudioClip four;
    end endObject;
    float endTime;
    // Use this for initialization
    void Start () {
        button1 = GameObject.FindGameObjectWithTag("button1");
        button2 = GameObject.FindGameObjectWithTag("button2");
        screenColor = GameObject.FindGameObjectWithTag("screenColor").GetComponent<UnityEngine.UI.Image>();
        endObject = GameObject.FindGameObjectWithTag("end").GetComponent<end>();
	}
	
	// Update is called once per frame
	void Update () {
	if (turn == 0)
        {
            button1.GetComponent<UnityEngine.UI.Image>().color = Color.magenta;
            button2.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
            GetComponent<AudioSource>().clip = one;
            if (GetComponent<AudioSource>().isPlaying)
            {

            }
            else
            {
                GetComponent<AudioSource>().Play();
            }
        }
    else if (turn == 1)
        {
            if (mood == "fear")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                screenColor.color = Color.magenta;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = two;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if(mood == "anxious")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                screenColor.color = Color.yellow;
                screenColor.color = new Color(screenColor.color.r,screenColor.color.g,screenColor.color.b,.2f);
                GetComponent<AudioSource>().clip = three;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        else if (turn == 2)
        {
            if (mood == "anger")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                screenColor.color = Color.red;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = three;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "sad")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.magenta;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                screenColor.color = Color.blue;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = two;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "happy")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                screenColor.color = Color.green;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = four;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        else if (turn == 3)
        {
            if (mood == "anger")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
                screenColor.color = Color.red;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = three;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "fear")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                screenColor.color = Color.magenta;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = two;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "sad")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.grey;
                screenColor.color = Color.blue;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = one;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "happy")
            {
                button1.GetComponent<UnityEngine.UI.Image>().color = Color.white;
                button2.GetComponent<UnityEngine.UI.Image>().color = Color.white;
                screenColor.color = Color.green;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = four;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        else if (turn == 4)
        {
            endObject.ending = mood;
            button1.SetActive(false);
            button2.SetActive(false);
            if (mood == "anger")
            {
                screenColor.color = Color.red;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = three;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
                
            }
            else if (mood == "anxious")
            {
                screenColor.color = Color.yellow;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = two;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "sad")
            {
                screenColor.color = Color.blue;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = three;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "death")
            {
                screenColor.color = Color.grey;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = one;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            else if (mood == "life")
            {
                screenColor.color = Color.white;
                screenColor.color = new Color(screenColor.color.r, screenColor.color.g, screenColor.color.b, .2f);
                GetComponent<AudioSource>().clip = four;
                if (GetComponent<AudioSource>().isPlaying)
                {

                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }
            }
            endTime += Time.deltaTime;
            if (endTime > 5)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("endLevel");
            }
        }














    }
}
