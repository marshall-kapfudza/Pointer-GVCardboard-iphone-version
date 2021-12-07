using UnityEngine;
/*
 Abdoulaye Boundy DJIKINE
 12/6/2021
 CSC 350H
 */
public class NodeSpawner : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject nodePrefab;
=======
    public NewNode nodePrefab;
>>>>>>> Stashed changes
    public bool isSpawning;
    public bool canSpawn;

    ConveyorHandler movement;
    public static int TotalNode { get; private set; }
    void Start()
    {
        movement = GameObject.FindGameObjectWithTag("Convayor").GetComponent<ConveyorHandler>();
        TotalNode = 0;
    }

    private void OnTriggerExit(Collider other)
<<<<<<< Updated upstream
    {
        isSpawning = false;
    }
    private void Update()
    {
        if (canSpawn && movement.Belts[0].Node == null)
        {
            Instantiate(nodePrefab, transform.position, Quaternion.identity);
            canSpawn = false;
        }
    }

    public void CreateNewNode()
    {
        if (isSpawning) return;

        movement.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        TotalNode++;
        isSpawning = true;
        canSpawn = true;

    }


=======
    {
        isSpawning = false;
    }
    private void Update()
    {
        if (canSpawn && movement.Belts[0].Node == null)
        {
            Instantiate(nodePrefab, transform.position, Quaternion.identity);
            canSpawn = false;
        }
    }

    public void CreateNewNode()
    {
        if (isSpawning) return;

        movement.ChangeConveyorBeltState(ConveyorDirection.LEFT);
        TotalNode++;
        isSpawning = true;
        canSpawn = true;

    }
>>>>>>> Stashed changes
}