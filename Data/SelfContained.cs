using MediatR;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMediatR.Data
{
    public class SelfContained : ComponentBase
    {
        [Inject]
        public IMediator mediator { get; set; }
        public Viewodel Model { get; set; }
        public string Result { get; set; }
        public async Task VerifySelections()
        {
            var result = await this.mediator.Send(new VerifyAnswerCommand
            {
                Name = Model.SelectedName,
                Role = Model.SelectedRole
            });
            if (result)
            {
                this.Result = $"Doğru Cevap, {this.Model.SelectedName} ismi bir {this.Model.SelectedRole} ";
            }
            else
            {
                this.Result = "Yanlış Cevap :(";
            }
        }
        protected override async Task OnInitializedAsync()
        {
            var selections = await this.mediator.Send(new GetSelectionQuery());
            this.Model = new Viewodel(selections.Roles, selections.Names);
        }
    }
}
