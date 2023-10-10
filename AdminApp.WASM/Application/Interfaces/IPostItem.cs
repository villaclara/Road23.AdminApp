﻿namespace AdminApp.WASM.Application.Interfaces
{
	// post the entity of type T to url
	public interface IPostItem<T> where T : class
	{
		Task<bool> PostItem(string url, T item);
	}
}
