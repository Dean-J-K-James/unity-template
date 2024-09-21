/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

//
public interface ICreated<T> { void OnCreated(T param); }
public interface IChanged<T> { void OnChanged(T param); }
public interface IUpdated<T> { void OnUpdated(T param); }
public interface ITickerd<T> { void OnTickerd(T param); }
public interface IDeleted<T> { void OnDeleted(T param); }
public interface ITrigger<T> { void OnTrigger(T param); }
public interface IIsValid<T> { bool OnIsValid(T param); }

//
public interface ICreated { void OnCreated(); }
public interface IChanged { void OnChanged(); }
public interface IUpdated { void OnUpdated(); }
public interface ITickerd { void OnTickerd(); }
public interface IDeleted { void OnDeleted(); }
public interface ITrigger { void OnTrigger(); }
