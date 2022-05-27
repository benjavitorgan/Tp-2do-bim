using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer2 : MonoBehaviour
{
    public GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clon = Instantiate(gameObject);

        clon.transform.position += new Vector3(0, 5, 0);
    }

    public void Instantiate ()
    {
       
    }
}
