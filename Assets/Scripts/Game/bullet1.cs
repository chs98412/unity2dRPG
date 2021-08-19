using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    Vector3 pos = new Vector3();
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos=transform.position;

        transform.Translate(0.03f, 0, 0);

        if(
            (pos.x>10||pos.x<-10)||
            (pos.y > 10 || pos.y < -10)
            )
        {
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("아야");
    }
}
