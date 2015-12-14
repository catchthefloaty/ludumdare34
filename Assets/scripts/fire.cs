using UnityEngine;
using System.Collections.Generic;

public class fire : actor
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
        if (base.worldObject.mood == "anger")
        {
            GetComponent<SpriteRenderer>().enabled = true;

            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];

            }
        }
        

    }
    public override void TurnThree()
    {
        if (base.worldObject.mood == "anger")
        {
            GetComponent<SpriteRenderer>().enabled = true;
            if(transform.localScale.x < maxScale1)
            {
                transform.localScale *= scaleRate;
            }
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];

            }
        }
        else if (GetComponent<SpriteRenderer>().enabled == true)
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];

            }
        }
        

    }
    public override void TurnFour()
    {
        if (base.worldObject.mood == "anger")
        {
            GetComponent<SpriteRenderer>().enabled = true;
            transform.localScale *= scaleRate;
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];

            }
        }
        else if (GetComponent<SpriteRenderer>().enabled == true)
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];

            }
        }
    }

}

