using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radzen.Blazor;

namespace mauiBlazor.Data
{
    public class AtributDataGrid
    {
        public RadzenDataGridColumn<object> NamaControl { get; set; }
        public string NamaProperty { get; set; }
        public string Title { get; set; }
        public bool Tampilkan { get; set; }
    }
}
