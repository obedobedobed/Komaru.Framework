using System.Collections.Generic;
using System.Linq;

namespace Komaru.Framework.GameWorld;

public static class World
{
    public static List<Tile> Tiles { get; private set; } = new List<Tile>();

    // Overloads for change all tiles
    public static void UpdateTiles(List<Tile> tiles)
    {
        Tiles = tiles;
    }

    public static void UpdateTiles(Tile[] tiles)
    {
        Tiles = tiles.ToList();
    }


    // Overload for add/delete one tile
    public static void UpdateTiles(Tile tile, bool isDeleting = false)
    {
        if (!isDeleting)
        {
            Tiles.Add(tile);
        }
        else
        {
            Tiles.Remove(tile);
        }
    }
}