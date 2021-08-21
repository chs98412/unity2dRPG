using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class player1 : MonoBehaviour, IPointerDownHandler
{
    public Image mainHP;
    public GameObject vill;
    public GameObject sword;
    public bool atk = false;
    public bool move = false;

    bool down = true;
    public float speed = 0.1f;
    Rigidbody2D rigid2D;
    Vector3 pos_player = new Vector3();
    Vector3 pos_moveto = new Vector3();

    Vector2 vc = new Vector2();
    public float weight = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    public float moveSpeed = 0.5f;

    void Update()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{

        //    rigid2D.MovePosition(rigid2D.position + Vector2.right * moveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rigid2D.MovePosition(rigid2D.position + Vector2.left * moveSpeed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rigid2D.MovePosition(rigid2D.position + Vector2.up * moveSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rigid2D.MovePosition(rigid2D.position + Vector2.up * moveSpeed * Time.deltaTime);
        //}



        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 vc = new Vector2(h, v);
        rigid2D.MovePosition(rigid2D.position + vc * moveSpeed * Time.deltaTime);

        //transform.position += new Vector3(speed * h, speed * v, 0);

        //if (Input.GetKey(KeyCode.V))
        //{
        //    transform.position += new Vector3(h,  v, 0);

        //}

        if (Input.GetKeyDown(KeyCode.P))
        {
            atk = true;

        }

        if (atk)
        {
            if (sword.transform.rotation.z > -90)
                sword.transform.Rotate(Vector3.back * 0.1f * 30);
            else if (sword.transform.rotation.z < 0)
            {

                sword.transform.Rotate(Vector3.forward * 0.1f * 30);
                if (sword.transform.rotation.z >= 0)
                {
                    atk = false;
                }
            }

        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("눌렀다");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("아야");
        if (collision.tag == "enemy")
        {
            mainHP.fillAmount -= 0.05f;
        }
    }

}
