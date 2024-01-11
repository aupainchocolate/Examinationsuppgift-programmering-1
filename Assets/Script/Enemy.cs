using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Movespeed;
    public PlayerData CurrentPlayerData = null;
    public GameObject OffScreenChecker = null; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        Vector3 EnemyPos = transform.position;
        EnemyPos.x -= Movespeed * Time.deltaTime;
        transform.position = EnemyPos;

    }
    public void DealDamage()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController playerComp = collision.gameObject.GetComponent<PlayerController>();
        if (playerComp != null)
        {
            DealDamage();
        }


    }
    public void TakeDamage()
    {
        GameObject.Destroy(gameObject); 
    }

      
}
