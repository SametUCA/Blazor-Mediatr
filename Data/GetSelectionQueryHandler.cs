using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorMediatR.Data
{
    public class GetSelectionQueryHandler : IRequestHandler<GetSelectionQuery, SelectionDto>
    {
        public async Task<SelectionDto> Handle(GetSelectionQuery request, CancellationToken cancellationToken)
        {
            await Task.Delay(5000, cancellationToken);
            return new SelectionDto
            {
                Roles = Basic.GetRoles(),
                Names = Basic.GetNames()
            };
        }
    }
}
