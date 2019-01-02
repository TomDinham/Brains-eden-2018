using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public int health = 1;
    public int points;
    public int turnspeed = 20;
    public int walkspeed = 5;
    public GameObject player;
    public bool CanMove = true;
    public bool CanShoot = true;
    
    public Transform[] barrelend;
    public Rigidbody PistolBullet;
    public Rigidbody BounceBullet;
    public Rigidbody MiniBullet;

    public int Pistolbulletforce = 500;
    public int shotgunbulletforce = 100;
    public int MiniGunBulletforce = 1000;

    public int minithrust = 100;
    public GameController gameControl;

    void Start ()
    {
        gameControl = FindObjectOfType<GameController>();
    }
	
	
	void Update ()
    {
       
	}

}
