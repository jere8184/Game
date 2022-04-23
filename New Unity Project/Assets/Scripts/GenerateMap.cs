using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    public GameObject hex;
    const int numColloums = 10;
    const int numRows = 10;

    List<Vector2> coordinates = HexMapMath.Generate2DHexCooridantes(numColloums, numRows);
    List<GameObject> hexList = new List<GameObject>();

    public void GenerateHexMap()
    {
        int i = 0;
        for (int row = 0; row < numColloums; row++) 
        {
            for (int colloum = 0; colloum < numRows; colloum++) 
            {
                Instantiate(hex);
                hex.transform.position = coordinates[i];
                hex.GetComponent<Hex>().colloum = colloum;
                hex.GetComponent<Hex>().row = row;
                hex.GetComponent<Hex>().s = -(row + colloum);
                hexList.Add(hex);
                i++;
            }
            
        }
        hexList[0].tag = "starting hex";
        //hex = new GameObject();
    }
}
