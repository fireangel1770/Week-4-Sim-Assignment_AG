using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class YarnBall : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float YKill = 7.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("AAAAAAAAAAA");
        Fly_Logic hit = collision.gameObject.GetComponent<Fly_Logic>();
        if (hit != null )
        {
            GameManeger scoreAdd = FindObjectOfType<GameManeger>();
            if (scoreAdd != null)
            {
                scoreAdd.score();
            }
            hit.BallCollision();
            Destroy(gameObject);
        }
    }
    private void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.y > YKill)
        {
            Destroy(gameObject);
        }
    }
}
