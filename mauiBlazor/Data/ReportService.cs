using Radzen;
using Microsoft.AspNetCore.Components;

namespace mauiBlazor.Data
{
    public class ReportService
    {
        private readonly NavigationManager navigationManager;

        public ReportService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public void Export(string table, string type, Query query = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"/export/northwind/{table}/{type}") : $"/export/northwind/{table}/{type}", true);
        }
    }
}
