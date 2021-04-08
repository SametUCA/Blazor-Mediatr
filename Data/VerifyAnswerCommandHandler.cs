using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorMediatR.Data
{
    public class VerifyAnswerCommandHandler : IRequestHandler<VerifyAnswerCommand,Boolean>
    {
        public VerifyAnswerCommandHandler()
        {

        }

        public async Task<bool> Handle(VerifyAnswerCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(500, cancellationToken);
            return Basic.HandleRoles(request.Name, request.Role);
        }
    }
}
