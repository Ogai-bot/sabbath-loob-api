using SabbathLoop.Domain.Commands;

namespace SabbathLoop.Domain.Util
{
	public interface ICommand
	{
		Task<ReturnData> GetErrorAsync(CommandsHandler handler);
		Task<bool> HasPermissionAsync(CommandsHandler handler);
		Task<ReturnData> ExecuteAsync(CommandsHandler handler);
    }
}

