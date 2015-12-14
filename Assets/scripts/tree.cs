using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tree : actor {
    //public List<Sprite> idle;
    public List<Sprite> windy;
    
    //public float animRate;
    //float animTime;
    //int curFrame;
    // Use this for initialization
    override public void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	override public void Update () {
        base.Update();
	}

    public override void TurnZero()
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



    public override void TurnOne()
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

    public override void TurnTwo()
    {
        if(base.worldObject.mood == "anger")
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= windy.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = windy[base.curFrame];
            }
        }
        else if (base.worldObject.mood == "sad")
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
        else if (base.worldObject.mood == "happy")
        {
            GetComponent<SpriteRenderer>().sprite = base.idle[0];
        }

    }
    public override void TurnThree()
    {
        if (base.worldObject.mood == "anger")
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= windy.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = windy[base.curFrame];
            }
        }
        else if (base.worldObject.mood == "sad")
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
        else if (base.worldObject.mood == "fear")
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
        else if (base.worldObject.mood == "happy")
        {
            GetComponent<SpriteRenderer>().sprite = base.idle[0];
        }

    }
    public override void TurnFour()
    {
        if (base.worldObject.mood == "anger")
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= windy.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = windy[base.curFrame];
            }
        }
        else if (base.worldObject.mood == "anxious")
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
        else if (base.worldObject.mood == "sad")
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
        else if (base.worldObject.mood == "life")
        {
            GetComponent<SpriteRenderer>().sprite = base.idle[0];
        }
        else if (base.worldObject.mood == "death")
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
