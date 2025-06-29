
namespace PMD
{
    /// <summary>
    /// room_flags - 1-byte bitfield
    /// </summary>
    public class RoomFlags
    {
        public RoomFlags()
        {
            this.f_secondary_terrain_generation = false;
            this.f_room_imperfections = false;
        }

        public bool f_secondary_terrain_generation ;
        public bool f_room_imperfections ;
    }

    /// <summary>
    /// terrain_flags -
    /// </summary>
    public class TerrainFlags
    {
        public TerrainFlags()
        {
            this.terrain_type = TerrainType.TERRAIN_WALL;
            this.f_corner_cuttable = false;
            this.f_natural_junction = false;
            this.f_impassable_wall = false;
            this.f_in_kecleon_shop = false;
            this.f_in_monster_house = false;
            this.terrain_flags_unk7 = false;
            this.f_unbreakable = false;
            this.f_stairs = false;
            this.terrain_flags_unk10 = false;
            this.f_key_door = false;
            this.f_key_door_key_locked = false;
            this.f_key_door_escort_locked = false;
            this.terrain_flags_unk14 = false;
            this.f_unreachable_from_stairs = false;
        }

        public TerrainType terrain_type ;
        public bool f_corner_cuttable ;
        public bool f_natural_junction ;
        public bool f_impassable_wall ;
        public bool f_in_kecleon_shop ;
        public bool f_in_monster_house ;
        public bool terrain_flags_unk7 ;
        public bool f_unbreakable ;
        public bool f_stairs ;
        public bool terrain_flags_unk10 ;
        public bool f_key_door ;
        public bool f_key_door_key_locked ;
        public bool f_key_door_escort_locked ;
        public bool terrain_flags_unk14 ;
        public bool f_unreachable_from_stairs ;
    }

    /// <summary>
    /// spawn_flags - 2-byte bitfield
    /// </summary>
    public class SpawnFlags
    {
        public SpawnFlags()
        {

            this.f_stairs = false;
            this.f_item = false;
            this.f_trap = false;
            this.f_monster = false;
            this.f_special_tile = false;
            this.spawn_flags_field_0x5 = false;
            this.spawn_flags_field_0x6 = false;
            this.spawn_flags_field_0x7 = false;
            f_in_kecleon_shop = false;
        }
        public bool f_in_kecleon_shop;
        public bool f_stairs ;
        public bool f_item ;
        public bool f_trap ;
        public bool f_monster ;
        public bool f_special_tile ;
        public bool spawn_flags_field_0x5 ;
        public bool spawn_flags_field_0x6 ;
        public bool spawn_flags_field_0x7 ;
    }


    public class StairsReachableFlags
    {
        public StairsReachableFlags()
        {
            this.f_cannot_corner_cut = false;
            this.f_secondary_terrain_cannot_corner_cut = false;
            this.f_unknown_field_0x2 = false;
            this.f_starting_point = false;
            this.f_in_visit_queue = false;
            this.f_visited = false;
        }

        public bool f_cannot_corner_cut ;
        public bool f_secondary_terrain_cannot_corner_cut ;
        public bool f_unknown_field_0x2 ;
        public bool f_starting_point ;
        public bool f_in_visit_queue ;
        public bool f_visited ;
    }

    public class MissionDestinationInfo
    {
        public bool is_destination_floor = false; // 0x0
        public MissionSubtype mission_type = MissionSubtype.MISSION_RESCUE_CLIENT; // 0x1
        public MissionSubtype mission_subtype = MissionSubtype.MISSION_CHALLENGE_NORMAL; // 0x2
    }
}