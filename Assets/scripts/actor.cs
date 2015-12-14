using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class actor : MonoBehaviour
{
    public world worldObject;
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
            TurnZero();
        }
        else if (worldObject.turn == 1)
        {
            TurnOne();
        }
        else if (worldObject.turn == 2)
        {
            TurnTwo();
        }
        else if (worldObject.turn == 3)
        {
            TurnThree();
        }
        else if (worldObject.turn == 4)
        {
            TurnFour();
        }
        //Debug.Log("yep");


    }

    virtual public void TurnZero()
    {

        //Debug.Log("nope");
    }

    virtual public void TurnOne()
    {

        Debug.Log("nope");
    }

    virtual public void TurnTwo()
    {
if (worldObject.mood == "")
            {

            }
            else if (worldObject.mood == "")
            {

            }
    }
    virtual public void TurnThree()
    {

    }
    virtual public void TurnFour()
    {

    }


}
