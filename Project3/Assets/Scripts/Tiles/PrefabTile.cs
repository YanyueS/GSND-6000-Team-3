using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "NewPrefabTile", menuName = "Tiles/Prefab Tile")]
public class PrefabTile : Tile
{
    public GameObject prefab; 
}
