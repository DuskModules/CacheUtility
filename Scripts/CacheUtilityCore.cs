using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.CacheUtility {

	/// <summary> Static class containing the static caches, and an extension method for anything that can access a cache.
	/// Caches are useful for scriptable objects to keep runtime data which is reset at launch. </summary>
	public static class CacheUtilityCore {

		/// <summary> All caches available to Cache Carriers </summary>
		public static Dictionary<Type, Dictionary<ICacheCarrier, ICache>> caches;

		/// <summary> Extension method for any ICacheCarrier which needs to access it's own cache.
		/// If the Cache doesn't exist yet, create it and call the onSetup to fill it with data. </summary>
		public static T GetCache<T>(this ICacheCarrier carrier, Action onSetup) where T : ICache, new() {
			return (T)BuildCache<T>(carrier, onSetup)[carrier];
		}

		/// <summary> Extension method for any ICacheCarrier which needs to set the cache to a reference of something else.
		/// If the Cache doesn't exist yet, create it and call the onSetup to fill it with data. </summary>
		public static void SetCache<T>(this ICacheCarrier carrier, Action onSetup, T cache) where T : ICache, new() {
			BuildCache<T>(carrier, onSetup)[carrier] = cache;
		}

		// Builds the cache, and ensures the carrier has an entry within.
		private static Dictionary<ICacheCarrier, ICache> BuildCache<T>(ICacheCarrier carrier, Action onSetup) where T : ICache, new() {
			if (caches == null)
				caches = new Dictionary<Type, Dictionary<ICacheCarrier, ICache>>();

			Dictionary<ICacheCarrier, ICache> subCache;
			if (caches.ContainsKey(typeof(T))) {
				subCache = caches[typeof(T)];
			}
			else {
				subCache = new Dictionary<ICacheCarrier, ICache>();
				caches.Add(typeof(T), subCache);
			}

			if (!subCache.ContainsKey(carrier)) {
				T c = new T();
				subCache.Add(carrier, c);
				onSetup?.Invoke();
			}
			return subCache;
		}

	}
}