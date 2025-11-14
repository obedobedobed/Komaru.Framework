using System.Linq;

namespace Komaru.Framework.GameWorld;

public static class World
{
    public static Tile[] WorldTiles { get; private set; }

    // Overload for change all tiles
    public static void UpdateTiles(Tile[] tiles)
    {
        WorldTiles = tiles;
    }

    // Overload for add/delete one tile
    public static void UpdateTiles(Tile tile, bool isDeleting = false)
    {
        var tmpTiles = WorldTiles.ToList();

        if (!isDeleting)
        {
            tmpTiles.Add(tile);
        }
        else
        {
            tmpTiles.Remove(tile);
        }

        WorldTiles = tmpTiles.ToArray();
    }
}