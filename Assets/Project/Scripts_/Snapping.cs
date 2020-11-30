using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);

        if (other.tag == "originalShape") {
            Debug.Log(other.name.Split('_')[0] + " , "+ transform.name.Split('_')[0]);

            if (other.name.Split('_')[0] == transform.name.Split('_')[0])
            {
               transform.parent= GameObject.Find(other.name).transform;
                transform.localPosition = Vector3.zero;
                Debug.Log(gameObject.name);
           //     transform.GetComponent<MeshCollider>().enabled = false;
              //  GameObject.Find(other.name).transform.GetComponent<MeshCollider>().enabled = false;
             //   Debug.Log("snapped!!");
              //  GameObject.Find(other.name).SetActive(false);
              //  GameObject.Find(other.name).SetActive(true);
            }
        }
    }
    }
