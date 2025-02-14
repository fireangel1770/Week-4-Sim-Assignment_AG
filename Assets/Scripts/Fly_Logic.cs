using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fly_Logic : MonoBehaviour
{
    [SerializeField] float speed = 3.0f;
    [SerializeField] float YKill = -6.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void BallCollision()
    {
        
        Destroy(gameObject);
    }
    private void Move()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        if (transform.position.y < YKill)
        {
            GameManeger Lose = FindObjectOfType<GameManeger>();
            if (Lose != null) 
            {
                Lose.GameLose();
            }
            Destroy(gameObject);
        }
    }
}
