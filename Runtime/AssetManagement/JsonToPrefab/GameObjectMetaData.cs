/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
//public static class GameObjectExtensions
//{

//    public static string Slug(this GameObject go)
//    {

//    }
//}



public struct GameObjectMetaData
{
    public string slug;
    public string type;
    public string variation;

    public GameObjectMetaData(string name)
    {
        slug = name[..(name.IndexOf('.'))];

        variation = name.LastIndexOf('_') != -1 ? name[(name.LastIndexOf('_') + 1)..] : "";

        type = name;
        type = type.Replace(slug + ".", "");
        type = type.Replace("_" + variation, "");
    }
}