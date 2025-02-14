using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    [SerializeField] GameObject FlyEnamine;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        flySpawn();
    }
    private void flySpawn()
    {
        if (Random.Range(1, 100) == 1)
        {
            float enamineX = Random.Range(-8, 8);
            Instantiate(FlyEnamine, new Vector3(enamineX,7,0), Quaternion.identity);
        }
    }
}
