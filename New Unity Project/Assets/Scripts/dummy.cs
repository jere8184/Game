using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy : MonoBehaviour
{
    //public GameObject pawn;
    public GameObject hex;
    // Start is called before the first frame update
    void Start()
    {
        GenerateMap generateMap = gameObject.AddComponent<GenerateMap>();
        generateMap.hex = hex;
        generateMap.GenerateHexMap();
        //Destroy(GameObject.FindGameObjectWithTag("starting hex"));
        //pawn = Instantiate(pawn);
        //pawn.GetComponent<Pawn>().SetUp();
        //pawn.GetComponent<Pawn>().Status.location = GameObject.FindGameObjectWithTag("starting hex").GetComponent<Hex>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
