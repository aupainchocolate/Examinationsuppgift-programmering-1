using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float Movespeed;
    public PlayerBullet PlayerBulletPrefab = null; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position.x. += Movespeed * Time.deltaTime; 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemyComp = collision.gameObject.GetComponent<Enemy>();
        if (enemyComp != null)
        {
            enemyComp.TakeDamage();
            GameObject.Destroy(gameObject);
        }
    }

}
