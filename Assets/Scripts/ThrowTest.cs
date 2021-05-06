using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowTest : MonoBehaviour
{
    Rigidbody itemRb;
    [SerializeField] GameObject item;
    public float power = 1.0f;
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
        if (state == 1)
        {
            Vector3 tmp = pl.transform.position;
            Quaternion tmp2 = pl.transform.rotation;
            itemRb.useGravity = false;
            this.transform.position = new Vector3(0f + tmp.x, 2 + tmp.y, 0 + tmp.z);
            this.transform.rotation = tmp2;
            Debug.Log(state);

            if (Input.GetKeyUp(KeyCode.S))
            {
                Thlow();
            }

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(state);
            if (Input.GetKey(KeyCode.S)&&state == 0)
            {
                state = 1;
            }

           
        }
    }

    private void Thlow()
    {
        itemRb.useGravity = true;
        itemRb.AddForce(transform.forward * power, ForceMode.Impulse);
        itemRb.AddForce(transform.up * power * 0.6f, ForceMode.Impulse);
        state = 0;
        Debug.Log(state);
    } 
}