using UnityEngine;
using System.Collections.Generic;

public class person : actor
{
    public float speed;
    //public List<Sprite> idle;
    public List<Sprite> windy;
    public Vector3 targetSleep;
    public Vector3 targetBoat;
    public Vector3 targetDrown;
    public List<Sprite> sleep;
    public List<Sprite> walk;
    public List<Sprite> startcry;
    public List<Sprite> cry;
    public List<Sprite> sitdown;
    public List<Sprite> sitIdle;
    public List<Sprite> sitCry;
    public List<Sprite> startSitcry;
    bool testcry = false;
    bool moveToSleep = false;
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
        base.AnimTime += Time.deltaTime;
        if (base.AnimTime > base.AnimRate)
        {
            base.AnimTime = 0;
            base.curFrame += 1;
            if (base.curFrame >= sitIdle.Count)
            {
                base.curFrame = 0;

            }
            GetComponent<SpriteRenderer>().sprite = sitIdle[base.curFrame];
        }
    }



    public override void TurnOne()
    {
        if (base.worldObject.mood == "fear")
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
        else if (base.worldObject.mood == "anxious")
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= startSitcry.Count)
                {
                    base.curFrame = 1;

                }
                GetComponent<SpriteRenderer>().sprite = startSitcry[base.curFrame];
            }
        }
    }

    public override void TurnTwo()
    {
        if (base.worldObject.mood == "anger")
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
                if (base.curFrame >= sitCry.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = sitCry[base.curFrame];
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
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];
            }
        }
        else if (base.worldObject.mood == "sad")
        {

            if (!testcry)
            {
                base.AnimTime += Time.deltaTime;
                if (base.AnimTime > base.AnimRate)
                {
                    base.AnimTime = 0;
                    base.curFrame += 1;
                    if (base.curFrame >= startcry.Count)
                    {
                        base.curFrame = startcry.Count-1;
                        testcry = true;
                        
                    }
                    GetComponent<SpriteRenderer>().sprite = startcry[base.curFrame];
                }

            }
            else
            {
                base.AnimTime += Time.deltaTime;
                if (base.AnimTime > base.AnimRate)
                {
                    base.AnimTime = 0;
                    base.curFrame += 1;
                    if (base.curFrame >= cry.Count)
                    {
                        base.curFrame = 0;

                    }
                    GetComponent<SpriteRenderer>().sprite = cry[base.curFrame];
                }
            }
        }
        else if (base.worldObject.mood == "fear")
        {
            
                transform.position = Vector3.MoveTowards(transform.position, targetBoat, speed * Time.deltaTime);
                if (transform.position == targetBoat)
                {
                    moveToSleep = true;
                    base.curFrame = 0;
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
        else if (base.worldObject.mood == "happy")
        {
            transform.position = Vector3.MoveTowards(transform.position, targetBoat, speed * Time.deltaTime);
            if (transform.position == targetBoat)
            {
                moveToSleep = true;
                base.curFrame = 0;
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
                if (base.curFrame >= base.idle.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = base.idle[base.curFrame];
            }
        }
        else if (base.worldObject.mood == "anxious")
        {
            transform.position = Vector3.MoveTowards(transform.position, targetDrown, speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().sortingOrder = -19;
            if (transform.position == targetBoat)
            {
                moveToSleep = true;
                base.curFrame = 0;
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
        else if (base.worldObject.mood == "sad")
        {
            base.AnimTime += Time.deltaTime;
            if (base.AnimTime > base.AnimRate)
            {
                base.AnimTime = 0;
                base.curFrame += 1;
                if (base.curFrame >= cry.Count)
                {
                    base.curFrame = 0;

                }
                GetComponent<SpriteRenderer>().sprite = cry[base.curFrame];
            }

        }
        else if (base.worldObject.mood == "life")
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime, Space.World);
        }
        else if (base.worldObject.mood == "death")
        {
            
            if (!moveToSleep)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetSleep, speed * Time.deltaTime);
                if (transform.position == targetSleep)
                {
                    moveToSleep = true;
                    base.curFrame = 0;
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
            else
            {
                base.AnimTime += Time.deltaTime;
                if (base.AnimTime > base.AnimRate)
                {
                    base.AnimTime = 0;
                    base.curFrame += 1;
                    if (base.curFrame >= sleep.Count)
                    {
                        base.curFrame = 0;

                    }
                    GetComponent<SpriteRenderer>().sprite = sleep[0];
                }
            }

        }
    }

}
