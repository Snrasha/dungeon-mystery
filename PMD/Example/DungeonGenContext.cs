using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace PMD.Example
{



    public class DungeonGenContext
    {

        public DungeonGen data;

        public TileDungeon[][] map;

        public int Width = 0;
        public int Height = 0;



        public void Run(ulong seed, int floor)
        {
            UnityEngine.Random.InitState((int)seed);
            FloorProperties floor_props = new FloorProperties();
            floor_props.layout = FloorLayout.LAYOUT_SMALL;
            floor_props.room_density = 5;
            floor_props.floor_connectivity = 15;
            floor_props.allow_dead_ends = true;
            floor_props.room_flags.f_secondary_terrain_generation = true;
            floor_props.room_flags.f_room_imperfections = true;
            floor_props.num_extra_hallways = 5;
            floor_props.skip_entities = true;


            Dungeon dungeon = new Dungeon();
            dungeon.id = 1;
            dungeon.floor = floor;
            dungeon.nonstory_flag = false;
            dungeon.dungeon_objective = DungeonObjectiveType.OBJECTIVE_NORMAL;

            data = new DungeonGen();
            data.GenerateDungeon(floor_props, dungeon);

            map = data.dungeonData.list_tiles;
            Width = DungeonGen.FLOOR_MAX_X;
            Height = DungeonGen.FLOOR_MAX_Y;
           

        }

        public int GetRandomRoom()
        {

            return 0;
        }
        public RectInt GetRectFromRoom( int idx)
        {
            return new RectInt(0, 0, 5, 5);
        }
        public int GetIndexFromAnotherRoom(int idx)
        {
            return 0;
        }


		public List<Vector2Int> GetAllValidSpawnForStair()
		{
			List<Vector2Int> valid_spawns = new List<Vector2Int>();

			TileDungeon[][] list_tiles = data.dungeonData.list_tiles;


			for (int x = 0; x < DungeonGen.FLOOR_MAX_X; x++)
			{
				for (int y = 0; y < DungeonGen.FLOOR_MAX_Y; y++)
				{
					//The stairs can spawn on tiles that are:
					// - Open Terrain
					// - In a room
					// - Not in a Kecleon Shop
					// - Not an enemy spawn
					// - Not a special tile (flagged by kecleon shops, traps, and items)
					// - Not a junction tile (next to a hallway)
					// - Not a special tile that can't be broken by Absolute Mover

					if (
						list_tiles[x][y].terrain_flags.terrain_type == TerrainType.TERRAIN_NORMAL &&
						list_tiles[x][y].room_index != 0xff &&
						!list_tiles[x][y].terrain_flags.f_in_kecleon_shop &&
						!list_tiles[x][y].spawn_or_visibility_flags.f_monster &&
						!list_tiles[x][y].spawn_or_visibility_flags.f_special_tile &&
						!list_tiles[x][y].terrain_flags.f_natural_junction &&
						!list_tiles[x][y].terrain_flags.f_unbreakable
					)
					{
                        valid_spawns.Add(new Vector2Int(x, y));

					}
				}
			}
            return valid_spawns;

		}

	}
}