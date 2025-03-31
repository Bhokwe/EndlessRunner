using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    [SerializeField]
    private int initialTilesCount = 10;
    [SerializeField]
    private GameObject startingTile;
    [SerializeField]
    private List<GameObject> obstacles;

    private Vector3 currentTileLocation = Vector3.zero; 
}
