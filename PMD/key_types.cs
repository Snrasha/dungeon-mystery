
using System;
using System.Collections.Generic;

namespace PMD
{
    /// <summary>
    /// A Grid Cell refers to a single enclosed tile-space of the dungeon map.
    /// These are used in dungeon.ts to form a matrix of grid cells that represent the entire map.
    /// 
    /// Each individual grid cell can hold one room or hallway anchor (or nothing if its contents are deleted later in generation).
    /// 
    /// Grid Cells are an important level of abstraction above the tile space, though they aren't used once dungeon generation has finished.
    /// </summary>
    public class GridCell
    {
        public GridCell()
        {
            this.start_x = 0;
            this.start_y = 0;
            this.end_x = 0;
            this.end_y = 0;
            this.is_invalid = false;
            this.has_secondary_structure = false;
            this.is_room = false;
            this.is_connected = false;
            this.is_kecleon_shop = false;
            this.unk3 = false;
            this.is_monster_house = false;
            this.unk4 = false;
            this.is_maze_room = false;
            this.has_been_merged = false;
            this.is_merged = false;
            this.connected_to_top = false;
            this.connected_to_bottom = false;
            this.connected_to_left = false;
            this.connected_to_right = false;
            this.should_connect_to_top = false;
            this.should_connect_to_bottom = false;
            this.should_connect_to_left = false;
            this.should_connect_to_right = false;
            this.unk5 = false;
            this.flag_imperfect = false;
            this.flag_secondary_structure = false;
        }

        public int start_x ;
        public int start_y ;
        public int end_x ;
        public int end_y ;
        public bool is_invalid ;
        public bool has_secondary_structure ;
        public bool is_room ;
        public bool is_connected ;
        public bool is_kecleon_shop ;
        public bool unk3 ;
        public bool is_monster_house ;
        public bool unk4 ;
        public bool is_maze_room ;
        public bool has_been_merged ;
        public bool is_merged ;
        public bool connected_to_top ;
        public bool connected_to_bottom ;
        public bool connected_to_left ;
        public bool connected_to_right ;
        public bool should_connect_to_top ;
        public bool should_connect_to_bottom ;
        public bool should_connect_to_left ;
        public bool should_connect_to_right ;
        public bool unk5 ;
        public bool flag_imperfect ;
        public bool flag_secondary_structure ;
    }

    /// <summary>
    /// A Tile is one individual square on the actual dungeon map.
    /// 
    /// Most of its relevant properties are contained in TerrainFlags and SpawnFlags, which specify how the
    /// tile operates and what it will look like.
    /// </summary>
    public class TileDungeon
    {
        public TileDungeon()
        {
            this.terrain_flags = new TerrainFlags();
            this.spawn_or_visibility_flags = new SpawnFlags();
            this.texture_id = 0;
            this.room_index = 255;
        }

        public TerrainFlags terrain_flags ;
        public SpawnFlags spawn_or_visibility_flags ;
        public int texture_id ;
        public int room_index ;
    }

    /// <summary>
    /// Floor Properties defines many of the key properties for dungeon generation, such as
    /// the type of layout, base number of rooms, and floor connectivity.
    /// 
    /// It's worth noting that not all settings affecting dungeon generation are contained here, as
    /// various other properties in Dungeon can also impact how the floor will generate.
    /// </summary>
    public class FloorProperties
    {
        public FloorProperties()
        {
            this.layout = FloorLayout.LAYOUT_SMALL;
            this.room_density = 4;
            this.floor_connectivity = 15;
            this.enemy_density = 0;
            this.kecleon_shop_chance = 0;
            this.monster_house_chance = 0;
            this.maze_room_chance = 0;
            this.allow_dead_ends = false;
            this.secondary_structures_budget = 0;
            this.room_flags = new RoomFlags();
            this.item_density = 0;
            this.trap_density = 0;
            this.floor_number = 0;
            this.fixed_room_id = 0;
            this.num_extra_hallways = 0;
            this.buried_item_density = 0;
            this.secondary_terrain_density = 10;
            this.itemless_monster_house_chance = 0;
            this.hidden_stairs_type = HiddenStairsType.HIDDEN_STAIRS_NONE;
            this.hidden_stairs_spawn_chance = 0;
        }

        public FloorLayout layout ;
        public int room_density ;
        public int floor_connectivity ;
        public int enemy_density ;
        public int kecleon_shop_chance ;
        public int monster_house_chance ;
        public int maze_room_chance ;
        public bool allow_dead_ends ;
        public int secondary_structures_budget ;
        public RoomFlags room_flags ;
        public int item_density ;
        public int trap_density ;
        public int floor_number ;
        public int fixed_room_id ;
        public int num_extra_hallways ;
        public bool skip_entities;
        public int buried_item_density ;
        public int secondary_terrain_density ;
        public int itemless_monster_house_chance ;
        public HiddenStairsType hidden_stairs_type ;
        public int hidden_stairs_spawn_chance ;
    }

    /// <summary>
    /// NA: 0237CFBC
    /// Floor Generation Status holds many of the runtime values for dungeon generation
    /// 
    /// Generally, most of these values are copied from other existing data, but some like has_monster_house
    /// do record information as generation progresses.
    /// </summary>
    public class FloorGenerationStatus
    {
        public FloorGenerationStatus()
        {
            this.second_spawn = false;
            this.has_monster_house = false;
            this.stairs_room_index = 0;
            this.has_kecleon_shop = false;
            this.has_chasms_as_secondary_terrain = false;
            this.is_invalid = false;
            this.floor_size = FloorSize.FLOOR_SIZE_LARGE;
            this.has_maze = false;
            this.no_enemy_spawn = false;
            this.kecleon_shop_chance = 100;
            this.monster_house_chance = 0;
            this.num_rooms = 0;
            this.secondary_structures_budget = 0;
            this.hidden_stairs_spawn_x = 0;
            this.hidden_stairs_spawn_y = 0;
            this.kecleon_shop_middle_x = 0;
            this.kecleon_shop_middle_y = 0;
            this.num_tiles_reachable_from_stairs = 0;
            this.layout = FloorLayout.LAYOUT_LARGE;
            this.hidden_stairs_type = HiddenStairsType.HIDDEN_STAIRS_NONE;
            this.kecleon_shop_min_x = 0;
            this.kecleon_shop_min_y = 0;
            this.kecleon_shop_max_x = 0;
            this.kecleon_shop_max_y = 0;
        }

        public bool second_spawn ;
        public bool has_monster_house ;
        public int stairs_room_index ;
        public bool has_kecleon_shop ;
        public bool has_chasms_as_secondary_terrain ;
        public bool is_invalid ;
        public FloorSize floor_size ;
        public bool has_maze ;
        public bool no_enemy_spawn ;
        public int kecleon_shop_chance ;
        public int monster_house_chance ;
        public int num_rooms ;
        public int secondary_structures_budget ;
        public int hidden_stairs_spawn_x ;
        public int hidden_stairs_spawn_y ;
        public int kecleon_shop_middle_x ;
        public int kecleon_shop_middle_y ;
        public int num_tiles_reachable_from_stairs ;
        public FloorLayout layout ;
        public HiddenStairsType hidden_stairs_type ;
        public int kecleon_shop_min_x ;
        public int kecleon_shop_min_y ;
        public int kecleon_shop_max_x ;
        public int kecleon_shop_max_y ;
    }

    /// <summary>
    /// Dungeon Generation Info provides additional information about dungeon generation
    /// at runtime.
    /// </summary>
    public class DungeonGenerationInfo
    {
        public DungeonGenerationInfo()
        {
            this.force_create_monster_house = false;
            this.monster_house_room = -1;
            this.hidden_stairs_type = HiddenStairsType.HIDDEN_STAIRS_NONE;
            this.fixed_room_id = 0;
            this.floor_generation_attempts = 0;
            this.player_spawn_x = -1;
            this.player_spawn_y = -1;
            this.stairs_spawn_x = -1;
            this.stairs_spawn_y = -1;
            this.hidden_stairs_spawn_x = -1;
            this.hidden_stairs_spawn_y = -1;
        }

        public bool force_create_monster_house ;
        public int monster_house_room ;
        public HiddenStairsType hidden_stairs_type ;
        public int fixed_room_id ;
        public int floor_generation_attempts ;
        public int player_spawn_x ;
        public int player_spawn_y ;
        public int stairs_spawn_x ;
        public int stairs_spawn_y ;
        public int hidden_stairs_spawn_x ;
        public int hidden_stairs_spawn_y ;
    }

    /// <summary>
    /// NA: 02353538
    /// Dungeon - Essentially the master class for just about all properties.
    /// 
    /// Holds various key data, as well as the dungeon map: list_tiles
    /// </summary>
    public class Dungeon
    {
        public Dungeon()
        {
            this.id = 1;
            this.floor = 1;
            this.rescue_floor = 1;
            this.nonstory_flag = true;
            this.dungeon_objective = DungeonObjectiveType.OBJECTIVE_NORMAL;
            this.kecleon_shop_min_x = 0;
            this.kecleon_shop_min_y = 0;
            this.kecleon_shop_max_x = 0;
            this.kecleon_shop_max_y = 0;
            this.num_items = 0;
            this.guaranteed_item_id = 0;
            this.n_floors_plus_one = 4;
        //    this.list_tiles;// = new List<List<Tile>>();
        //    this.fixed_room_tiles;// = new List<List<Tile>>();
            this.active_traps = new List<double>(64);
        }

        public double id ;
        public double floor ;
        public double rescue_floor ;
        public bool nonstory_flag ;
        public  MissionDestinationInfo mission_destination = new MissionDestinationInfo(); //0x760
        public DungeonObjectiveType dungeon_objective ;
        public double kecleon_shop_min_x ;
        public double kecleon_shop_min_y ;
        public double kecleon_shop_max_x ;
        public double kecleon_shop_max_y ;
        public double num_items ;
        public double guaranteed_item_id ;
        public double n_floors_plus_one ;
        public TileDungeon[][] list_tiles ;
        public TileDungeon[][] fixed_room_tiles ;
        public List<double> active_traps ;
    }
}