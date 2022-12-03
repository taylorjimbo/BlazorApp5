using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebRTCme.Middleware;

namespace BlazorApp5.Pages
{
    public partial class ConnectionParametersPage
    {
        [Inject]
        ConnectionParametersViewModel ConnectionParametersViewModel { get; set; }

        string[] _servernames { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ConnectionParametersViewModel.OnPageAppearing(_servernames);
            await base.OnInitializedAsync();
        }

        private void ReRender()
        {
            StateHasChanged();
        }
    }
}
