using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands
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
            ReturnData result = await cmd.GetErrorAsync(this);
            if (result != null && result.ErrorCode != EErrorCode.None)
                return result.FinalizeTransition(beginDate);

            var hasPermission = await cmd.HasPermissionAsync(this);
            if (!hasPermission)
            {
                result = await Task.FromResult(new ReturnData(EErrorCode.Unauthorized, "Sem permissão para executar esse comando"));
                return result.FinalizeTransition(beginDate);
            }

            result = await cmd.ExecuteAsync(this);
            return result.FinalizeTransition(beginDate);
        }
    }
}

