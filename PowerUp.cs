using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public Transform miniSpawn;
    public Transform BounceSpawn;
    public Transform ranSpawn;
    public Transform miniSpawn2;
    public Transform BounceSpawn2;
    public Transform ranSpawn2;

    public GameObject Mini;
    public GameObject bounce;
    public GameObject Rand;
    public GameObject Mini1;
    public GameObject bounce1;
    public GameObject Rand1;

    public bool spawnedmini = true;
    public bool spawnedbounce = true;
    public bool spawnedRand = true;
    public bool spawnedmini2 = true;
    public bool spawnedbounce2 = true;
    public bool spawnedRand2 = true;

    void Start ()
    {
        Instantiate(Rand, ranSpawn.position, ranSpawn.rotation);
        Instantiate(bounce, BounceSpawn.position, BounceSpawn.rotation);
        Instantiate(Mini, miniSpawn.position, miniSpawn.rotation);

        Instantiate(Rand1, ranSpawn2.position, ranSpawn2.rotation);
        Instantiate(bounce1, BounceSpawn2.position, BounceSpawn2.rotation);
        Instantiate(Mini1, miniSpawn2.position, miniSpawn2.rotation);
    }
	
	// Update
	void Update ()
    {
      if(!spawnedRand)
        {
            StartCoroutine(RandSpawner());
        }
        if (!spawnedbounce)
        {
            StartCoroutine(BounceSpawner());
        }
        if (!spawnedmini)
        {
            StartCoroutine(MiniSpawner());
        }

        if (!spawnedRand2)
        {
            StartCoroutine(RandSpawner1());
        }
        if (!spawnedbounce2)
        {
            StartCoroutine(BounceSpawner1());
        }
        if (!spawnedmini2)
        {
            StartCoroutine(MiniSpawner1());
        }

    }
   IEnumerator RandSpawner()
    {
        spawnedRand = true;
        yield return new WaitForSeconds(20f);
        GameObject RandInstance;
        RandInstance = Instantiate(Rand, ranSpawn.position, ranSpawn.rotation) as GameObject;

     
        
    }
    IEnumerator BounceSpawner()
    {
        spawnedbounce = true;
        yield return new WaitForSeconds(20f);
        GameObject BounceInstance;
        BounceInstance = Instantiate(bounce, BounceSpawn.position, BounceSpawn.rotation) as GameObject;
        
    }
    IEnumerator MiniSpawner()
    {
        spawnedmini = true;
        yield return new WaitForSeconds(20f);
        GameObject MiniInstance;
        MiniInstance = Instantiate(Mini, miniSpawn.position, miniSpawn.rotation) as GameObject;
       
        
    }

    IEnumerator RandSpawner1()
    {
        spawnedRand2 = true;
        yield return new WaitForSeconds(20f);
        GameObject RandInstance;
        RandInstance = Instantiate(Rand1, ranSpawn2.position, ranSpawn2.rotation) as GameObject;

       

    }
    IEnumerator BounceSpawner1()
    {
        spawnedbounce2 = true;
        yield return new WaitForSeconds(20f);
        GameObject BounceInstance;
        BounceInstance = Instantiate(bounce1, BounceSpawn2.position, BounceSpawn2.rotation) as GameObject;
        
    }
    IEnumerator MiniSpawner1()
    {
        spawnedmini2 = true;
        yield return new WaitForSeconds(20f);
        GameObject MiniInstance;
        MiniInstance = Instantiate(Mini1, miniSpawn2.position, miniSpawn2.rotation) as GameObject;
        

    }
}
