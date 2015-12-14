using UnityEngine;
using System.Collections;

public class boat : actor
{

    public float maxScale1;
    public float maxScale2;
    public float scaleRate;
    //public float animRate;
    //float animTime;
    //int curFrame;
    // Use this for initialization
    override public void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
    }

    public override void TurnZero()
    {

    }



    public override void TurnOne()
    {

    }

    public override void TurnTwo()
    {
        


    }
    public override void TurnThree()
    {
        if (base.worldObject.mood == "happy")
        {
            GetComponent<SpriteRenderer>().enabled = true;
            
        }
        


    }
    public override void TurnFour()
    {
        if (base.worldObject.mood == "life")
        {
            transform.Translate(Vector3.right*5*Time.deltaTime,Space.World);
        }
    }

}


