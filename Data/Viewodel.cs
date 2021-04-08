using System.Collections.Generic;

namespace BlazorMediatR.Data
{
    public class Viewodel
    {
        public Viewodel(IList<string> roles, IList<string> names)
        {
            Roles = roles;
            Names = names;

        }
        public IList<string> Names { get; set; }
        public IList<string> Roles { get; set; }
        public string SelectedName { get; set; }
        public string SelectedRole { get; set; }
    }
}