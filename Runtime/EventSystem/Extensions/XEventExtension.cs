/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;

/**
 * 
 */
public static class XEventExtensions
{
    //
    public static void InvokeCreated<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<ICreated<T>>()) { item.OnCreated(param); } }
    public static void InvokeChanged<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<IChanged<T>>()) { item.OnChanged(param); } }
    public static void InvokeUpdated<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<IUpdated<T>>()) { item.OnUpdated(param); } }
    public static void InvokeTickerd<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<ITickerd<T>>()) { item.OnTickerd(param); } }
    public static void InvokeDeleted<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<IDeleted<T>>()) { item.OnDeleted(param); } }
    public static void InvokeTrigger<T>(this MonoBehaviour go, T param) { foreach (var item in go.GetComponents<ITrigger<T>>()) { item.OnTrigger(param); } }

    //
    public static void InvokeCreated(this MonoBehaviour go) { foreach (var item in go.GetComponents<ICreated>()) { item.OnCreated(); } }
    public static void InvokeChanged(this MonoBehaviour go) { foreach (var item in go.GetComponents<IChanged>()) { item.OnChanged(); } }
    public static void InvokeUpdated(this MonoBehaviour go) { foreach (var item in go.GetComponents<IUpdated>()) { item.OnUpdated(); } }
    public static void InvokeTickerd(this MonoBehaviour go) { foreach (var item in go.GetComponents<ITickerd>()) { item.OnTickerd(); } }
    public static void InvokeDeleted(this MonoBehaviour go) { foreach (var item in go.GetComponents<IDeleted>()) { item.OnDeleted(); } }
    public static void InvokeTrigger(this MonoBehaviour go) { foreach (var item in go.GetComponents<ITrigger>()) { item.OnTrigger(); } }
}
