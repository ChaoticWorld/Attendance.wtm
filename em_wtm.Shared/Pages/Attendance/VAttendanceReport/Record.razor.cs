using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace em_wtm.Shared.Pages.Attendance.VAttendanceReport
{
    //public partial class Record : ComponentBase, IResultDialog {
    public partial class _Record : IResultDialog
    {
        [Parameter]
        public EventCallback<bool> ClosedEvent { get; set; }
        public async Task OnClose(DialogResult result)
        {
            if (ClosedEvent.HasDelegate)
                await ClosedEvent.InvokeAsync(true);
        }
    }
}
