using System;
using System.Collections.Generic;
using System.Text;

namespace soletechs.Models
{
    interface ITabIcon
    {
        bool IsSelected { get; set; }
        string CurrentIcon { get; }
    }
}
