using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Map : MonoBehaviour {

    private int[,] TileValues;

    void Start()
    {
        string contents = File.ReadAllText(@"C:\Users\Henry\Desktop\Descent\Assets\Maps\Map01.json");
    }

    private void DeserializeMap(string json)
    {
        MapJSON map = JsonConvert.DeserializeObject<MapJSON>(json);

        int x = map.mapRows[0].row.Split(',').Length;
        int y = map.mapRows.Length;
        TileValues = new int[x, y];

        for(int i = 0; i < x; i++)
        {
            string[] rowValues = map.mapRows[i].row.Split(',');
            for (int j = 0; j < y; j++)
            {
                int value;
                TileValues[i, j] = (int.TryParse(rowValues[j], out value) ? value : 0);
            }
        }
    }
}

public class MapJSON
{
    public MapRow[] mapRows { get; set; }
}

public class MapRow
{

    public string row { get; set; }
}