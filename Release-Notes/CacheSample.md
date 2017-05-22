```csharp
using AdHoc.Cache.DataCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using StackExchange.Redis;

public class CustomDbSchemaCache : IPermanentDataCache
{
	ConnectionMultiplexer redis;
	private string serverString;
	private string dbCachePrefix = "iz_db_"; // Used to determine which keys in redis DB are from Izenda DB Cache so they can be queried in a batch

	public CustomDbSchemaCache()
	{
		serverString = "localhost:6379";
		redis = ConnectionMultiplexer.Connect(serverString);
	}

	#region IPermanentDataCache

	public byte[] Get(string key)
	{
		key = dbCachePrefix + key;
		return redis.GetDatabase().StringGet(key);
	}

	public void Set(string key, byte[] value)
	{
		key = dbCachePrefix + key;
		redis.GetDatabase().StringSet(key, value);
	}

	public void Remove(string key)
	{
		key = dbCachePrefix + key;
		redis.GetDatabase().KeyDelete(key);
	}

	public void Invalidate()
	{
		var server = redis.GetServer(serverString);
		foreach (var key in server.Keys(pattern: dbCachePrefix + "*"))
			redis.GetDatabase().KeyDelete(key);
	}

	public string[] AllKeys()
	{
		var server = redis.GetServer(serverString);
		return server.Keys(pattern: dbCachePrefix + "*").Select(k => k.ToString().Replace(dbCachePrefix, "")).ToArray();
	}

	#endregion
}
```