using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileStatus : MonoBehaviour {
   
    public static TileStatus Empty = new TileStatus(-1, true);

    public static TileStatus Ground = new TileStatus(1, false);

    public static TileStatus Water = new TileStatus(-1, false);

    public static TileStatus Rubble = new TileStatus(-1, true);

    public static TileStatus Encounters = new TileStatus(1, true);

    public static TileStatus GlyphDeactivated = new TileStatus(1, false);

    public static TileStatus GlyphActivated = new TileStatus(1, false);

    public static TileStatus Staircase = new TileStatus(1, false);

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
                return TileStatus.Encounters;
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
}
