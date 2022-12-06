using System;
using SabbathLoop.Domain.Commands;

namespace SabbathLoop.Domain.Util
{
	public class CommandsHandler
	{
		public CommandDbContext DbContext;

        public CommandsHandler(CommandDbContext dbContext)
		{
            DbContext = dbContext;
		}

		public async Task<ReturnData> Handler(ICommand cmd)
		{
			var beginDate = DateTimeOffset.UtcNow;
			var result = await cmd.GetErrorAsync(this);
			if (result != null && result.ErrorCode != EErrorCode.None)
			{
				result.FinalizeTransition(beginDate);
                return result;
            }

            var hasPermition = await cmd.HasPermitionAsync(this);
			if (!hasPermition)
				return await Task.FromResult(new ReturnData(EErrorCode.Unauthorized, "Sem permissão para executar esse comando"));

			result = await cmd.ExecuteAsync(this);
			result.FinalizeTransition(beginDate);
			return result;
		}
	}
}

