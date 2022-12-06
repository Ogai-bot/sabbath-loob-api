using System;
namespace SabbathLoop.Domain.Util
{
	public interface ICommand
	{
		Task<ReturnData> GetErrorAsync(CommandsHandler handler);
		Task<bool> HasPermitionAsync(CommandsHandler handler);
		Task<ReturnData> ExecuteAsync(CommandsHandler handler);
    }
}

