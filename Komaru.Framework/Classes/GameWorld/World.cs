using System.Linq;

namespace Komaru.Framework.GameWorld;

public static class World
{
    public static Tile[] Tiles { get; private set; } = new Tile[0];

    // Overload for change all tiles
    public static void UpdateTiles(Tile[] tiles)
    {
        Tiles = tiles;
    }

    // Overload for add/delete one tile
    public static void UpdateTiles(Tile tile, bool isDeleting = false)
    {
        var tmpTiles = Tiles.ToList();

        if (!isDeleting)
        {
            tmpTiles.Add(tile);
        }
        else
        {
            tmpTiles.Remove(tile);
        }

        Tiles = tmpTiles.ToArray();
    }
}