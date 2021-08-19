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
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    public float moveSpeed = 0.5f;

    void Update()
    {

       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(0.3f * h, 0.3f * v, 0);
        if (Input.GetKeyDown(KeyCode.P))
        {
            for(int i = 0; i < 90; i++)
            {
                sword.transform.Rotate(0, 0, -1);
            }
            //for (int i = 0; i < 90; i++)
            //{
            //    sword.transform.Rotate(0, 0, 1);
            //}
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("눌렀다");
    }
    
}
