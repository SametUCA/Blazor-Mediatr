using System.Collections.Generic;

namespace BlazorMediatR.Data
{
    public class SelectionDto
    {
        public SelectionDto()
        {

        }
        public IList<string> Names { get; set; }
        public IList<string> Roles { get; set; }
    }
}