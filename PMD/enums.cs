
namespace PMD
{

    public enum FloorLayout
    {
        LAYOUT_LARGE,
        LAYOUT_SMALL,
        LAYOUT_ONE_ROOM_MONSTER_HOUSE,
        LAYOUT_OUTER_RING,
        LAYOUT_CROSSROADS,
        LAYOUT_TWO_ROOMS_WITH_MONSTER_HOUSE,
        LAYOUT_LINE,
        LAYOUT_CROSS,
        LAYOUT_LARGE_0x8,
        LAYOUT_BEETLE,
        LAYOUT_OUTER_ROOMS,
        LAYOUT_MEDIUM,
        LAYOUT_UNUSED_0xC,
        LAYOUT_UNUSED_0xD,
        LAYOUT_UNUSED_0xE,
        LAYOUT_UNUSED_0xF
    }

    public enum TerrainType
    {
        TERRAIN_WALL,
        TERRAIN_NORMAL,
        TERRAIN_SECONDARY,
        TERRAIN_CHASM
    }


   // export type MissionSubtype = MissionSubtypeChallenge | MissionSubtypeExplore | MissionSubtypeOutlaw | MissionSubtypeTakeItem;


    public enum SecondaryTerrainType
    {
        SECONDARY_TERRAIN_WATER,
        SECONDARY_TERRAIN_LAVA,
        SECONDARY_TERRAIN_CHASM
    }

    public enum DungeonObjectiveType
    {
        OBJECTIVE_STORY,
        OBJECTIVE_NORMAL,
        OBJECTIVE_RESCUE,
        OBJECTIVE_UNK_GAMEMODE_5
    }


    public enum FloorSize
    {
        FLOOR_SIZE_LARGE,
        FLOOR_SIZE_SMALL,
        FLOOR_SIZE_MEDIUM
    }

    public enum HiddenStairsType
    {
        HIDDEN_STAIRS_NONE,
        HIDDEN_STAIRS_SECRET_BAZAAR,
        HIDDEN_STAIRS_SECRET_ROOM,
        HIDDEN_STAIRS_RANDOM_SECRET_BAZAAR_OR_SECRET_ROOM = 255
    }

    public enum FloorType
    {
        FLOOR_TYPE_NORMAL,
        FLOOR_TYPE_FIXED,
        FLOOR_TYPE_RESCUE
    }

    /// <summary>
    /// DirectionId - Direction on the dungeon grid
    /// 
    /// Enum values can be mapped to offsets in LIST_DIRECTIONS
    /// </summary>
    public enum DirectionId
    {
        DIR_NONE = 20,
        DIR_DOWN = 0,
        DIR_DOWN_RIGHT = 1,
        DIR_RIGHT = 2,
        DIR_UP_RIGHT = 3,
        DIR_UP = 4,
        DIR_UP_LEFT = 5,
        DIR_LEFT = 6,
        DIR_DOWN_LEFT = 7,
        DIR_CURRENT = 8
    }

    /// <summary>
    /// CardinalDirection - used to help make 4-directional branching readable
    /// 
    /// Not part of the original code
    /// </summary>
    public enum CardinalDirection
    {
        DIR_RIGHT=0,
        DIR_UP=1,
        DIR_LEFT=2,
        DIR_DOWN=3
    }

    /// <summary>
    /// SecondaryStructureType - for readability in GenerateSecondaryStructures
    /// 
    /// Not part of the original code
    /// </summary>
    public enum SecondaryStructureType
    {
        SECONDARY_STRUCTURE_NONE=0,
        SECONDARY_STRUCTURE_MAZE_PLUS_DOT=1,
        SECONDARY_STRUCTURE_CHECKERBOARD=2,
        SECONDARY_STRUCTURE_POOL=3,
        SECONDARY_STRUCTURE_ISLAND=4,
        SECONDARY_STRUCTURE_DIVIDER=5
    }

    /// <summary>
    /// GenerationStepLevel - specifies significance level of a callback event
    /// 
    /// Not part of the original code
    /// </summary>
    public enum GenerationStepLevel
    {
        GEN_STEP_NONE,
        GEN_STEP_COMPLETE,
        GEN_STEP_MAJOR,
        GEN_STEP_MINOR,
        
    }

    /// <summary>
    /// MajorGenerationType - Specifications for types of major events that have occurred (ex. created all rooms/anchors)
    /// 
    /// Not part of the original code
    /// </summary>
    public enum MajorGenerationType
    {
        GEN_TYPE_RESET_FLOOR,
        GEN_TYPE_INIT_DUNGEON_GRID,
        GEN_TYPE_CREATE_ROOMS_AND_ANCHORS,
        GEN_TYPE_CREATE_GRID_CELL_CONNECTIONS,
        GEN_TYPE_ENSURE_CONNECTED_GRID,
        GEN_TYPE_GENERATE_MAZE_ROOM,
        GEN_TYPE_GENERATE_KECLEON_SHOP,
        GEN_TYPE_GENERATE_MONSTER_HOUSE,
        GEN_TYPE_GENERATE_EXTRA_HALLWAYS,
        GEN_TYPE_GENERATE_ROOM_IMPERFECTIONS,
        GEN_TYPE_GENERATE_SECONDARY_STRUCTURES,
        GEN_TYPE_ONE_ROOM_MONSTER_HOUSE_FLOOR,
        GEN_TYPE_OUTER_RING_FLOOR,
        GEN_TYPE_CROSSROADS_FLOOR,
        GEN_TYPE_TWO_ROOMS_WITH_MONSTER_HOUSE_FLOOR,
        GEN_TYPE_MERGE_ROOM_VERTICALLY,
        GEN_TYPE_GENERATE_SECONDARY_TERRAIN,
        GEN_TYPE_SPAWN_NON_ENEMIES,
        GEN_TYPE_SPAWN_ENEMIES,
        GEN_TYPE_GENERATE_FLOOR
    }

    /// <summary>
    /// MinorGenerationType - Specifications for types of minor events that have occurred (ex. created a hallway)
    /// 
    /// Not part of the original code
    /// </summary>
    public enum MinorGenerationType
    {
        GEN_TYPE_CREATE_ROOM,
        GEN_TYPE_CREATE_ANCHOR,
        GEN_TYPE_CREATE_HALLWAY,
        GEN_TYPE_MERGE_ROOM,
        GEN_TYPE_ENSURE_CONNECTED_HALLWAY,
        GEN_TYPE_REMOVE_UNCONNECTED_ANCHOR,
        GEN_TYPE_REMOVE_UNCONNECTED_ROOM,
        GEN_TYPE_GENERATE_EXTRA_HALLWAY,
        GEN_TYPE_GENERATE_ROOM_IMPERFECTION,
        GEN_TYPE_GENERATE_SECONDARY_STRUCTURE,
        GEN_TYPE_MERGE_ROOM_VERTICALLY,
        GEN_TYPE_SECONDARY_TERRAIN_RIVER,
        GEN_TYPE_SECONDARY_TERRAIN_RIVER_LAKE,
        GEN_TYPE_SECONDARY_TERRAIN_STANDALONE_LAKE,
        GEN_TYPE_SPAWN_STAIRS,
        GEN_TYPE_SPAWN_ITEMS,
        GEN_TYPE_SPAWN_BURIED_ITEMS,
        GEN_TYPE_SPAWN_MONSTER_HOUSE_ITEMS_TRAPS,
        GEN_TYPE_SPAWN_TRAPS,
        GEN_TYPE_SPAWN_PLAYER,
        GEN_TYPE_SPAWN_NON_MONSTER_HOUSE_ENEMIES,
        GEN_TYPE_SPAWN_MONSTER_HOUSE_EXTRA_ENEMIES
    }


    /// <summary>
    /// MajorGenerationType - Specifications for types of major events that have occurred (ex. created all rooms/anchors)
    /// 
    /// Not part of the original code
    /// </summary>
    public enum GenerationType
    {
        GEN_TYPE_RESET_FLOOR,
        GEN_TYPE_INIT_DUNGEON_GRID,
        GEN_TYPE_CREATE_ROOMS_AND_ANCHORS,
        GEN_TYPE_CREATE_GRID_CELL_CONNECTIONS,
        GEN_TYPE_ENSURE_CONNECTED_GRID,
        GEN_TYPE_GENERATE_MAZE_ROOM,
        GEN_TYPE_GENERATE_KECLEON_SHOP,
        GEN_TYPE_GENERATE_MONSTER_HOUSE,
        GEN_TYPE_GENERATE_EXTRA_HALLWAYS,
        GEN_TYPE_GENERATE_ROOM_IMPERFECTIONS,
        GEN_TYPE_GENERATE_SECONDARY_STRUCTURES,
        GEN_TYPE_ONE_ROOM_MONSTER_HOUSE_FLOOR,
        GEN_TYPE_OUTER_RING_FLOOR,
        GEN_TYPE_CROSSROADS_FLOOR,
        GEN_TYPE_TWO_ROOMS_WITH_MONSTER_HOUSE_FLOOR,
        GEN_TYPE_MERGE_ROOM_VERTICALLY,
        GEN_TYPE_GENERATE_SECONDARY_TERRAIN,
        GEN_TYPE_SPAWN_NON_ENEMIES,
        GEN_TYPE_SPAWN_ENEMIES,
        GEN_TYPE_GENERATE_FLOOR,
        GEN_TYPE_CREATE_ROOM,
        GEN_TYPE_CREATE_ANCHOR,
        GEN_TYPE_CREATE_HALLWAY,
        GEN_TYPE_MERGE_ROOM,
        GEN_TYPE_ENSURE_CONNECTED_HALLWAY,
        GEN_TYPE_REMOVE_UNCONNECTED_ANCHOR,
        GEN_TYPE_REMOVE_UNCONNECTED_ROOM,
        GEN_TYPE_GENERATE_EXTRA_HALLWAY,
        GEN_TYPE_GENERATE_ROOM_IMPERFECTION,
        GEN_TYPE_GENERATE_SECONDARY_STRUCTURE,
        GEN_TYPE_SECONDARY_TERRAIN_RIVER,
        GEN_TYPE_SECONDARY_TERRAIN_RIVER_LAKE,
        GEN_TYPE_SECONDARY_TERRAIN_STANDALONE_LAKE,
        GEN_TYPE_SPAWN_STAIRS,
        GEN_TYPE_SPAWN_ITEMS,
        GEN_TYPE_SPAWN_BURIED_ITEMS,
        GEN_TYPE_SPAWN_MONSTER_HOUSE_ITEMS_TRAPS,
        GEN_TYPE_SPAWN_TRAPS,
        GEN_TYPE_SPAWN_PLAYER,
        GEN_TYPE_SPAWN_NON_MONSTER_HOUSE_ENEMIES,
        GEN_TYPE_SPAWN_MONSTER_HOUSE_EXTRA_ENEMIES
    }
    public enum MissionSubtype
    {
        MISSION_RESCUE_CLIENT,
        MISSION_RESCUE_TARGET,
        MISSION_ESCORT_TO_TARGET,
        MISSION_EXPLORE_WITH_CLIENT,
        MISSION_PROSPECT_WITH_CLIENT,
        MISSION_GUIDE_CLIENT,
        MISSION_FIND_ITEM,
        MISSION_DELIVER_ITEM,
        MISSION_SEARCH_FOR_TARGET,
        MISSION_TAKE_ITEM_FROM_OUTLAW,
        MISSION_ARREST_OUTLAW,
        MISSION_CHALLENGE_REQUEST,
        MISSION_TREASURE_MEMO,
        MISSION_CHALLENGE_NORMAL,
        MISSION_CHALLENGE_MEWTWO,
        MISSION_CHALLENGE_ENTEI,
        MISSION_CHALLENGE_RAIKOU,
        MISSION_CHALLENGE_SUICUNE,
        MISSION_CHALLENGE_JIRACHI,
        MISSION_EXPLORE_NORMAL,
        MISSION_EXPLORE_SEALED_CHAMBER,
        MISSION_EXPLORE_GOLDEN_CHAMBER,
        MISSION_EXPLORE_NEW_DUNGEON,
        MISSION_OUTLAW_NORMAL_0,
        MISSION_OUTLAW_NORMAL_1,
        MISSION_OUTLAW_NORMAL_2,
        MISSION_OUTLAW_NORMAL_3,
        MISSION_OUTLAW_ESCORT,
        MISSION_OUTLAW_FLEEING,
        MISSION_OUTLAW_HIDEOUT,
        MISSION_OUTLAW_MONSTER_HOUSE,
        MISSION_TAKE_ITEM_NORMAL_OUTLAW,
        MISSION_TAKE_ITEM_HIDDEN_OUTLAW,
        MISSION_TAKE_ITEM_FLEEING_OUTLAW,
    }

}