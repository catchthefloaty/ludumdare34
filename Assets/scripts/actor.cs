using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class actor : MonoBehaviour
{
    world worldObject;
    public float AnimRate;
    public  float AnimTime;
    public int curFrame;
    public string curAnimation;
    public List<Sprite> idle;


    // Use this for initialization
    public virtual void Start()
    {
        worldObject = GameObject.FindGameObjectWithTag("world").GetComponent<world>();
        //worldObject = GetComponent<world>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (worldObject.turn == 0)
        {
            TurnOne();
        }
        else if (worldObject.turn == 1)
        {
            TurnTwo();
        }

        Debug.Log("yep");


    }


   virtual public void TurnOne()
    {

        Debug.Log("nope");
    }

    void TurnTwo()
    {
if (worldObject.mood == "")
            {

            }
            else if (worldObject.mood == "")
            {

            }
    }
    void TurnThree()
    {

    }
    void TurnFour()
    {

    }
    void TurnFive()
    {

    }

}
