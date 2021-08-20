using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet3 : MonoBehaviour
{
    public GameObject enemy;
    public float time = 3.0f;
    float cnt = 0;
    int distance = 0;
    public int distanceSet = 10;
    Vector3 pos = new Vector3();
    public float speed3 = 3;
    public Vector3 myPosition;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        distance += 1;
        if (distance < distanceSet)
        {
            transform.Translate(0.05f, 0, 0);
        }
        else
        {
            cnt += Time.deltaTime;
            if (cnt >= time)
            {
                Destroy(gameObject);
                
            }

            Vector3 targetPosition = enemy.transform.position;
            myPosition = transform.position;

            if (Vector3.Distance(targetPosition, myPosition) < 5)
            {
                enemy.GetComponent<enemy>().blackhall(myPosition);
            }
        }
        if (
            (pos.x > 10 || pos.x < -10) ||
            (pos.y > 10 || pos.y < -10)
            )
        {
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        enemy.GetComponent<enemy>().blackhalltrig = false;
    }
}
