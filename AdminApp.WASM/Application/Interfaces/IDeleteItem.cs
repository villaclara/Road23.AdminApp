﻿namespace AdminApp.WASM.Application.Interfaces
{
	public interface IDeleteItem<T> where T : class
	{
		Task<bool> DeleteItemFromURLAsync(string url);
	}
}
