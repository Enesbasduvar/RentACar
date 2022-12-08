using System;

namespace Core.Utilities.Results
{
	public interface IResult
	{
		bool Success { get; }
		String Message { get; }
	}
}