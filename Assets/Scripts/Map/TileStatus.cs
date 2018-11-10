using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileStatus : MonoBehaviour {

    [SerializeField]
    private static GameObject[] mapPrefabs;

    public static TileStatus Empty = new TileStatus(-1, true);

    public static TileStatus Ground = new TileStatus(1, false);

    public static TileStatus Water = new TileStatus(-1, false);

    public static TileStatus Rubble = new TileStatus(-1, true);

    public static TileStatus Encounter = new TileStatus(1, true);

    public static TileStatus GlyphDeactivated = new TileStatus(1, false);

    public static TileStatus GlyphActivated = new TileStatus(1, false);

    public static TileStatus Staircase = new TileStatus(1, false);

    private static GameObject MapGround = (GameObject)Resources.Load("Map/Ground", typeof(GameObject));

    private static GameObject MapWater = (GameObject)Resources.Load("Map/Ground", typeof(GameObject));

    private static GameObject MapRubble = (GameObject)Resources.Load("Map/Rubble", typeof(GameObject));

    private static GameObject MapEncounter = (GameObject) Resources.Load("Map/Encounter", typeof(GameObject));

    private static GameObject MapGlyphDeactivated = (GameObject)Resources.Load("Map/GlyphDeactivated", typeof(GameObject));

    private static GameObject MapGlyphActivated = (GameObject)Resources.Load("Map/GlyphActivated", typeof(GameObject));

    private static GameObject MapStaircase = (GameObject)Resources.Load("Map/Staircase", typeof(GameObject));

    private int MovementToEnter;

    private bool BlocksLineOfSight;

    private TileStatus(int movementToEnter, bool blocksLineOfSight)
    {
        this.MovementToEnter = movementToEnter;
        this.BlocksLineOfSight = blocksLineOfSight;
    }

    public int GetMovementToEnter()
    {
        return MovementToEnter;
    }

    public bool IsBlockingLineOfSight()
    {
        return BlocksLineOfSight;
    }

    public static TileStatus GetTileStatusByID(int id)
    {
        switch (id)
        {
            case 0:
                return TileStatus.Empty;
            case 1:
                return TileStatus.Ground;
            case 2:
                return TileStatus.Water;
            case 3:
                return TileStatus.Rubble;
            case 4:
                return TileStatus.Encounter;
            case 5:
                return TileStatus.GlyphDeactivated;
            case 6:
                return TileStatus.GlyphActivated;
            case 7:
                return TileStatus.Staircase;
            default:
                return TileStatus.Empty;
        }
    }

    public static GameObject GetMapPrefabById(int id)
    {
        switch (id)
        {
            case 1:
                return MapGround;
            case 2:
                return MapWater;
            case 3:
                return MapRubble;
            case 4:
                return MapEncounter;
            case 5:
                return MapGlyphDeactivated;
            case 6:
                return MapGlyphActivated;
            case 7:
                return MapStaircase;
            default:
                return null;
        }
    }
}
