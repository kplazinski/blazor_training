using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTraining.Extensions
{
    public static class JSRuntimeExtensions
    {
        public static async Task SwalAdvanced(this IJSRuntime jSRuntime,
               string icon, string title, string text, string footerMsg, string footerLink)
        {
            string footer = $"<a href='{footerLink}'>{footerMsg}</a>";

            await jSRuntime.InvokeVoidAsync("Swal.fire", new { icon, title, text, footer });
        }
    }
}
