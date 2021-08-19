using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject player;
    float y;
    float x;
    float angle;
    float time;
    public float time_set=3;
    bool atk = false;
    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > time_set)
        {
            time = 0;
            x = transform.position.x -player.transform.position.x ;
            y =  transform.position.y- player.transform.position.y  ;

            angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

            if (x < 0 && y < 0)
                transform.Rotate(0, 0, angle);

            else if (x > 0 && y < 0)
                transform.Rotate(0, 0, 180 - angle);
            else if (x < 0 && y > 0)
                transform.Rotate(0, 0, -angle);
            else if (x > 0 && y > 0)
                transform.Rotate(0, 0, 180 + angle);

            atk = true;
        }
        if (atk)
        {
            cnt += 1;
            if (cnt < 100)
            {
                transform.Translate(0.03f, 0, 0);
            }
            else
            {
                cnt = 0;
                atk = false;
            }
        }
        
    }
}
