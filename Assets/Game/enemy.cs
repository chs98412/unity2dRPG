using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemy : MonoBehaviour
{
    public GameObject player;
    float y;
    float x;
    float angle;
    float time;
    public float time_set = 3;
    bool atk = false;
    int cnt = 0;
    public Image hpBar;
    public int speed = 100;
    public float speed2 = 0.01f;
    public float speed3 = 3;
    public float speed4 = 3;

    public bool crash = false;
    Rigidbody2D rigid2D;
    bool coma = false;
    float comaTime = 0;
    public float comaTimeset = 3;
    public bool blackhalltrig = false;
    public float dmg_basicbullet = 0.01f;
    public float weight = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coma)
        {
            comaTime += Time.deltaTime;
            GetComponent<SpriteRenderer>().color = Color.blue;
            if (comaTime > comaTimeset)
            {
                coma = false;
                comaTime = 0;
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }

        else if (!blackhalltrig)
        {
            Vector2 targetPosition = player.transform.position;
            Vector2 myPosition = transform.position;

            if (Vector2.Distance(targetPosition, myPosition) < 3)
            {
                Debug.Log("아야");

            }

            else
            {
                rigid2D.MovePosition(rigid2D.position + (myPosition - targetPosition) * weight * speed3 * Time.deltaTime);

                // transform.position = Vector2.MoveTowards(myPosition, targetPosition, speed3 * Time.deltaTime);
            }
            {
                //     if (crash)
                //     {
                //         time += Time.deltaTime;
                //         if (time > time_set)
                //         {
                //             time = 0;
                //             x = player.transform.position.x - this.transform.position.x;
                //             y = player.transform.position.y - this.transform.position.y;

                //             angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;
                //             transform.Rotate(0, 0, 0);
                //             if (x < 0 && y < 0)
                //                 transform.Rotate(0, 0, angle);

                //             else if (x > 0 && y < 0)
                //                 transform.Rotate(0, 0, 180 - angle);
                //             else if (x < 0 && y > 0)
                //                 transform.Rotate(0, 0, -angle);
                //             else if (x > 0 && y > 0)
                //                 transform.Rotate(0, 0, 180 + angle);

                //             atk = true;
                //         }
                //         if (atk)
                //         {
                //             cnt += 1;
                //             if (cnt < speed)
                //             {
                //                 Vector2 vc = new Vector2(x, y);

                //                 rigid2D.MovePosition(rigid2D.position + vc * (speed3 * 100) * Time.deltaTime);
                //             }
                //             else
                //             {
                //                 cnt = 0;
                //                 atk = false;
                //             }
                //         }
                //     }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "comashot")
        {
            coma = true;
        }
        else if (collision.tag == "basicbullet")
        {
            Debug.Log("아야");

            hpBar.fillAmount -= dmg_basicbullet;
        }

        else if (collision.tag == "blackhallbullet")
        {
            Debug.Log("아야");
        }
    }
    public void blackhall(Vector3 pos)
    {
        if (!blackhalltrig)
        {

            blackhalltrig = true;

        }
        Vector3 myPosition = transform.position;

        transform.position = Vector2.MoveTowards(myPosition, pos, speed3 * Time.deltaTime);



    }
}
