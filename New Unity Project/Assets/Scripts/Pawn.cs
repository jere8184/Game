using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
 
    public Move Move;
    public Status Status;
    private Condition condition;
    
    public void SetUp() 
    {
        Status = new Status();
        Move = new Move(this);
    }


}

class Condition 
{
    float movementPoints;
    Pawn pawn;

    public Condition(Pawn pawn, float movementPoints) 
    {
        this.movementPoints = movementPoints;
        this.pawn = pawn;
    }

}

public class Status 
{
    public Hex location;

    public Status() 
    {

    }
}

public class Move 
{
    Pawn pawn;

    public Move(Pawn pawn) 
    {
        this.pawn = pawn;
        SetLocation(this.pawn.Status.location);
    }

    //sets the pawns location. should check conditions.
    private void SetLocation(Hex location)
    {
        pawn.Status.location = location;
        UpdateLocation(location);
    }

    //returns hex location of pawn
    private Hex GetLocation()
    {
        return pawn.Status.location;
    }

    //raw method to move pawn
    private void UpdateLocation(Hex location)
    {
        pawn.gameObject.transform.position = location.gameObject.transform.position;
    }

    public void MoveToAdj(Hex adjacent) 
    {
        SetLocation(adjacent);
    }

}