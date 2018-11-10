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

    private int MovementToEnter { get; }

    private bool BlocksLineOfSight { get; }

    private TileStatus(int movementToEnter, bool blocksLineOfSight)
    {
        this.MovementToEnter = movementToEnter;
        this.BlocksLineOfSight = blocksLineOfSight;
    }
}
