using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toyGeneration : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    public bool firstTime = false;
    public bool canSpawn = true;
    public bool changeUI = false;

    public GameObject toyDeny;
    public GameObject toyDeny2;

    void Start()
    {
        //spawnObjects();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha9) && Input.GetKey(KeyCode.LeftShift))
        {
            spawnObjects();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "BeanDetect" && canSpawn == true)
        {
            firstTime = true;
            spawnObjects();
            canSpawn = false;
        }

        if (collision.gameObject.name == "DiningDetect")
        {
            canSpawn = true;
            changeUI = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DiningDetect")
        {
            changeUI = false;
        }
    }

    public void spawnObjects()
    {
        destroyObjects();
        toyDeny.gameObject.SetActive(true);
        toyDeny2.gameObject.SetActive(true);
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            GameObject GO = Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            GO.tag = "Spawnable";
            if(GO.name == "BeanoBall(Clone)" || GO.name == "MessyBall(Clone)" || GO.name == "ScribbleBall(Clone)")
            {
                GO.tag = "Spawnable2";
            }
        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }

        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable2"))
        {
            Destroy(o);
        }
    }


}
