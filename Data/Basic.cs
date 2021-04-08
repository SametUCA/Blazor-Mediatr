using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMediatR.Data
{
    public static class Basic
    {
        public static List<string> GetRoles()
        {
            return new List<string>
            {
                "Aktör","Futbolcu","Film","Ülke"

            };           
        }

        public static List<string> GetNames()
        {
            return new List<string>
            {
                "Samet","Messi","Arjantin","Yıldızlar Arası"

            };
        }
        public static bool HandleRoles(string name,string role)
        {
            switch (role)
            {
                case "Aktör":
                    if (name == "Samet") return true;
                    break;
                case "Futbolcu":
                    if (name == "Messi") return true;
                    break;
                case "Film":
                    if (name == "Yıldızlar Arası") return true;
                    break;
                case "Ülke":
                    if (name == "Arjantin") return true;
                    break;
                default:
                    break;
            }
            return false;
        }
    }
}
