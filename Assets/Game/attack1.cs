using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class attack1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    GameObject pang;
    bool isPressed;
    public GameObject mainbullet;
    public GameObject mainbullet2;
    public GameObject mainbullet3;

    //??????
    float curTime = 0;
    public float coolTime = 0.3f;


    float angle;
    Vector3 pos_first = new Vector3();
    Vector3 pos_second = new Vector3();
    Vector3 pos_final = new Vector3();
    float y;
    float x;
    public float shootpossible = 1;
    public bool atk = false;
    // Start is called before the first frame update
    void Start()
    {
        pang = GameObject.Find("maincharac");

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        pos_first = eventData.position;
        Debug.Log("click");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        pos_second = eventData.position;
        Debug.Log("drag");


    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            isPressed = true;
            pos_first = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }
        if (Input.GetMouseButton(0))
        {
            pos_second = Input.mousePosition;
        }

        //Debug.Log(Input.touchCount);
        curTime += Time.deltaTime;

        if (isPressed)
            {
            Debug.Log("땅겨");

                // SoundManager.instance.BGMplay("banana", clip3);

                //pos_second = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                if (Vector3.Distance(pos_second, pos_first) > shootpossible && Input.GetKey(KeyCode.Z)&&curTime>coolTime)
                {
                curTime = 0;

                    GameObject go = Instantiate(mainbullet) as GameObject;

                    go.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);



                    x = pos_first.x - pos_second.x;
                    y = pos_first.y - pos_second.y;

                    angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

                    if (x < 0 && y < 0)
                        go.transform.Rotate(0, 0, angle);

                    else if (x > 0 && y < 0)
                        go.transform.Rotate(0, 0, 180 - angle);
                    else if (x < 0 && y > 0)
                        go.transform.Rotate(0, 0, -angle);

                    else if (x > 0 && y > 0)
                        go.transform.Rotate(0, 0, 180 + angle);


                }
            else if (Vector3.Distance(pos_second, pos_first) > shootpossible && Input.GetKey(KeyCode.X) && curTime > coolTime)
            {
                curTime = 0;

                GameObject go = Instantiate(mainbullet) as GameObject;
                GameObject go2 = Instantiate(mainbullet) as GameObject;
                GameObject go3 = Instantiate(mainbullet) as GameObject;

                go.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);
                go2.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);
                go3.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);



                x = pos_first.x - pos_second.x;
                y = pos_first.y - pos_second.y;

                angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

                if (x < 0 && y < 0)
                {
                    go.transform.Rotate(0, 0, angle);
                    go2.transform.Rotate(0, 0, angle-40);
                    go3.transform.Rotate(0, 0, angle + 40);

                }

                else if (x > 0 && y < 0)
                {
                    go.transform.Rotate(0, 0, 180 - angle);

                    go2.transform.Rotate(0, 0, 180 - angle- 40);
                    go3.transform.Rotate(0, 0, 180 - angle+ 40);
                }
                else if (x < 0 && y > 0)
                {
                    go.transform.Rotate(0, 0, -angle);

                    go2.transform.Rotate(0, 0, 40 - angle);
                    go3.transform.Rotate(0, 0, -angle- 40);
                }

                else if (x > 0 && y > 0)
                {
                    go.transform.Rotate(0, 0, 180 + angle);
                    go2.transform.Rotate(0, 0, 180 + angle- 40);
                    go3.transform.Rotate(0, 0, 180 + angle+ 40);

                }



            }





            else if (Vector3.Distance(pos_second, pos_first) > shootpossible && Input.GetKey(KeyCode.C) && curTime > coolTime)
            {
                curTime = 0;

                GameObject go = Instantiate(mainbullet2) as GameObject;

                go.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);



                x = pos_first.x - pos_second.x;
                y = pos_first.y - pos_second.y;

                angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

                if (x < 0 && y < 0)
                    go.transform.Rotate(0, 0, angle);

                else if (x > 0 && y < 0)
                    go.transform.Rotate(0, 0, 180 - angle);
                else if (x < 0 && y > 0)
                    go.transform.Rotate(0, 0, -angle);

                else if (x > 0 && y > 0)
                    go.transform.Rotate(0, 0, 180 + angle);


            }
            else if (Vector3.Distance(pos_second, pos_first) > shootpossible && Input.GetKey(KeyCode.B) && curTime > coolTime)
            {
                curTime = 0;

                GameObject go = Instantiate(mainbullet3) as GameObject;

                go.transform.position = new Vector3(pang.transform.position.x, pang.transform.position.y, 0);



                x = pos_first.x - pos_second.x;
                y = pos_first.y - pos_second.y;

                angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

                if (x < 0 && y < 0)
                {
                    go.transform.Rotate(0, 0, angle);

                }

                else if (x > 0 && y < 0)
                {
                    go.transform.Rotate(0, 0, 180 - angle);

                }
                else if (x < 0 && y > 0)
                {
                    go.transform.Rotate(0, 0, -angle);

                }

                else if (x > 0 && y > 0)
                {
                    go.transform.Rotate(0, 0, 180 + angle);

                }



            }
        }
        
        
    }
}
