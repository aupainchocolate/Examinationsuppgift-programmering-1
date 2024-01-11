using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerController CurrentPlayerData = null; 
    public float movespeed;
    public TextMeshProUGUI HPText = null;
    public TextMeshProUGUI PointsText = null;
    public PlayerBullet PlayerBulletPrefab = null; 
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        if (Input.GetKey(KeyCode.UpArrow)) playerPos.y += movespeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow)) playerPos.y -= movespeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow)) playerPos.x -= movespeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow)) playerPos.x += movespeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Instantiate(PlayerBulletPrefab, this.transform.position, PlayerBulletPrefab.transform.rotation);
        }
        transform.position = playerPos;

        HPText.text = CurrentPlayerData.HPText + "HP";
        PointsText.text = CurrentPlayerData.PointsText + "Points";

    }
}
