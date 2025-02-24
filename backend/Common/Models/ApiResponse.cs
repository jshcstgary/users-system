using System.Net;

using Microsoft.AspNetCore.Mvc;

namespace Common.Models;

/// <summary>
/// Proporciona una estructura consistente para las respuestas de una API REST,
/// ya sean exitosas o fallidas. Hereda de <see cref="ProblemDetails"/> para
/// aprovechar la funcionalidad de manejo de errores estándar de ASP.NET Core,
/// al mismo tiempo que agrega la capacidad de transportar datos en caso de éxito.
/// </summary>
/// <typeparam name="T">El tipo de datos que se devolverán en caso de éxito.</typeparam>
public class ApiResponse<T> : ProblemDetails
{
	/// <summary>
	/// Indicates whether the request was successful.
	/// </summary>
	public bool Success { get; set; }

	/// <summary>
	/// Indicates the status code of the returned HTTP request.
	/// </summary>
	public new HttpStatusCode Status { get; set; }

	/// <summary>
	/// Contains the data returned by the API in case of success.
	/// </summary>
	public T? Data { get; set; }

	/// <summary>
	/// Contains specific errors returned b the API in case of failure.
	/// </summary>
	public Dictionary<string, string[]> Errors { get; set; } = [];

	/// <summary>
	/// Adds an error to the error list of the response object when the HTTP request failed.
	/// </summary>
	/// <param name="key">The key to error.</param>
	/// <param name="values">Error values.</param>
	public void AddError(string key, string[] values)
	{
		Errors[key] = values;
	}
}
