using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTest : MonoBehaviour
{
    Rigidbody itemRb;
    [SerializeField] GameObject item;
    public float power = 10.0f;
    private int state = 0;
    public GameObject pl;
    


    // Start is called before the first frame update
    void Start()
    {
        itemRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.S))
            {
                Vector3 tmp = pl.transform.position;
                itemRb.useGravity = false;
                this.transform.position = new Vector3(0f + tmp.x, 1 + tmp.y, 0 + tmp.z);
                state = 1;
                Debug.Log(state);
            }

            if (Input.GetKey(KeyCode.S) && state == 1)
            {
                itemRb.useGravity = true;
                itemRb.AddForce(transform.forward * power, ForceMode.Impulse);
                itemRb.AddForce(transform.up * power * 0.5f, ForceMode.Impulse);
                state = 0;
                Debug.Log(state);

            }
        }
    }
}
