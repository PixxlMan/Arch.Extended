using System.Collections.Concurrent;

namespace Arch.Bus;

public delegate void EventDelegate<T>(ref T eventArgument);

public static class GlobalEventRegistry
{
	public static object SyncRoot = new();

	public static Dictionary<string, List<WeakReference<EventDelegate<object>>>> StaticEvents = [];

	public static ConcurrentDictionary<string, object> Instances = new();
}
