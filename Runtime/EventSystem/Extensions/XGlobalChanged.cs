/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XGlobalChanged
{
    //
    public static void GlobalChanged<T>(this MonoBehaviour go, T param) { var obt = Object.FindObjectsByType<SingletonListener>(FindObjectsSortMode.None); foreach (var sl in obt) { sl.InvokeChanged(param); } }
}