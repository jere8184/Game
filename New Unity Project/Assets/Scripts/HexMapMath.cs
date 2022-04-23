using System;
using System.Collections.Generic;
using UnityEngine;

public class HexMapMath
{
    //pointy top
    const float hexSize = 1;
    static float hexWidth = (float)Math.Sqrt(3) * hexSize;
    static float hexHeight = 2 * hexSize;
    static public List<Vector2> Generate2DHexCooridantes(int numColoums, int numRows)
    {
        List<Vector2> HexMapCooridantes = new List<Vector2>();
        for (int row = 0; row < numRows; row++)
        {
            for (int coloum = 0; coloum < numColoums; coloum++)
            {
                if (row % 2 == 0) { HexMapCooridantes.Add(new Vector2((coloum * hexWidth), row * hexHeight * 0.75f)); }
                else { HexMapCooridantes.Add(new Vector2((coloum * hexWidth) + hexWidth / 2, row * hexHeight * 0.75f)); }
            }
        }
        return HexMapCooridantes;
    }
}
