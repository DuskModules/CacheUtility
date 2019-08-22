using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuskModules.CacheUtility {

	/// <summary> An AssetObject is a base ScriptableObject with a cache. </summary>
	public class AssetObject<C> : ScriptableObject, ICacheCarrier where C : ICache, new() {

		/// <summary> Data cache kept during runtime </summary>
		public C cache {
			get => this.GetCache<C>(CacheSetup);
			set => this.SetCache(CacheSetup, value);
		}

		/// <summary> Called the first time the cache has been initialized. </summary>
		protected virtual void CacheSetup() {

		}

	}

}