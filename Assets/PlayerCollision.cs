using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public int counter;
    public Text vidas;
    public Text GO;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        GO.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.1f)
        {
            transform.position = new Vector3(3.07f, 0.5f, -7);
            counter--;
        }
    }

    void OnCollisionEnter (Collision col)
    {
        vidas.text = "Vidas: " + counter.ToString();

        if (counter > 0)
        {
            if (col.gameObject.name == "Killer")
            {
                transform.position = new Vector3(3.07f, 0.5f, -7);
                counter--;
            }
        } else
        {
            Destroy(gameObject);
            GO.text = "¡Game Over!";
        }
    }
}
