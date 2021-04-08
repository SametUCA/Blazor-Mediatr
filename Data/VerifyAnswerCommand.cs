using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMediatR.Data
{
    public class VerifyAnswerCommand : IRequest<Boolean>
    {
        public VerifyAnswerCommand()
        {

        }
        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
    }
}
