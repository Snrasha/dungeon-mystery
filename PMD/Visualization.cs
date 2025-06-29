using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace PMD
{
    public static class Visualisation
    {

        public static void WriteFile(TileDungeon[][] dungeon_map, string filename)
        {
            string text = Visualisation.CreateMapString(dungeon_map);

            string destination = Application.persistentDataPath + "/"+ filename + ".txt";

            FileStream file;

            //Debug.Log(destination);


            if (File.Exists(destination))
            {
                File.Delete(destination);
                file = File.Create(destination);
            }
            else file = File.Create(destination);


            file.Write(System.Text.Encoding.Default.GetBytes(text));

        }
        public static string CreateMapString(TileDungeon[][] map, List<int> list_x = null, List<int> list_y = null)
        {
            string map_string = "";

            int x_idx, y_idx = 0;
            bool on_x_border, on_y_border;

            for (int y = 0; y < 32; y++)
            {
                string mapLine = "";

                if (list_y != null && y_idx < list_y.Count && y >= list_y[y_idx] - 1)
                {
                    if (y >= list_y[y_idx])
                    {
                        y_idx++;
                    }

                    on_y_border = true;
                }
                else
                {
                    on_y_border = false;
                }

                x_idx = 0;

                for (int x = 0; x < 56; x++)
                {
                    if (list_x != null && x_idx < list_x.Count && x >= list_x[x_idx] - 1)
                    {
                        if (x >= list_x[x_idx])
                        {
                            x_idx++;
                        }

                        on_x_border = true;
                    }
                    else
                    {
                        on_x_border = false;
                    }

                    if (x > 0)
                    {
                        mapLine += " ";
                    }
                    TileDungeon tile = map[x][y];

                    if (tile.terrain_flags.terrain_type == TerrainType.TERRAIN_NORMAL)
                    {
                        if (tile.spawn_or_visibility_flags.f_stairs)
                        {
                            mapLine += "=";
                        }
                        else if (tile.spawn_or_visibility_flags.f_in_kecleon_shop)
                        {
                            mapLine += "K";
                        }
                        else if (tile.spawn_or_visibility_flags.f_item)
                        {
                            mapLine += "I";
                        }
                        else if (tile.spawn_or_visibility_flags.f_monster)
                        {
                            mapLine += "M";
                        }
                        else if (tile.spawn_or_visibility_flags.f_trap)
                        {
                            mapLine += "T";
                        }
                        else
                        {
                            if (tile.room_index == 0xFF)
                            {
                                mapLine += "P";
                            }
                            else if (tile.room_index == 0xFE)
                            {
                                mapLine += "A";
                            }
                            else
                            {
                                if (tile.terrain_flags.f_in_monster_house)
                                {
                                    mapLine += "Z";
                                }
                                else
                                {
                                    mapLine += "X";
                                }
                            }
                        }
                    }
                    else if (tile.terrain_flags.terrain_type == TerrainType.TERRAIN_WALL)
                    {
                        if (on_x_border || on_y_border)
                        {
                            mapLine += "\\";
                        }
                        else
                        {
                            mapLine += "-";
                        }
                    }
                    else if (tile.terrain_flags.terrain_type == TerrainType.TERRAIN_SECONDARY)
                    {
                        mapLine += "v";
                    }
                    else if (tile.terrain_flags.terrain_type == TerrainType.TERRAIN_CHASM)
                    {
                        mapLine += "C";
                    }
                }

                map_string += mapLine + "\n";
            }

            return map_string;
        }
    }
}