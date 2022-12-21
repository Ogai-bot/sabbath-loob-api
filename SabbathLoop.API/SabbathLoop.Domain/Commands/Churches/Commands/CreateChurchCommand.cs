using Microsoft.EntityFrameworkCore;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Churches.Commands
{
    public class CreateChurchCommand : ICommand
    {
        public string Name { get; set; }

        public async Task<ReturnData> GetErrorAsync(CommandsHandler handler)
        {
            if (string.IsNullOrEmpty(Name))
                return await Task.FromResult(new ReturnData(EErrorCode.InvalidParameters, "Parâmetro nome não pode ser nulo. Insira um valor válido."));

            var isThereSameName = await handler.DbContext.Churches
                .AsNoTracking()
                .AnyAsync(c => c.Name == Name);
            if (isThereSameName)
                return await Task.FromResult(new ReturnData(EErrorCode.DuplicateUniqueIdentifier, "Já existe igreja com esse nome. Insira um nome unico para a nova igreja"));

            return await Task.FromResult<ReturnData>(result: null);
        }

        public Task<bool> HasPermissionAsync(CommandsHandler handler)
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnData> ExecuteAsync(CommandsHandler handler)
        {
            throw new NotImplementedException();
        }

    }
}

