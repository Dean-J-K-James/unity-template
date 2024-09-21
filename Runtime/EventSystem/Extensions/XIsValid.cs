/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XIsValid
{
    //
    public static bool InvokeIsValid<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<IIsValid<T>>()) { if (!item.OnIsValid(param)) { return false; } } return true; }
}