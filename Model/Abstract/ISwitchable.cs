using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    internal interface ISwitchable
    {
        bool OnOffCommand { get; set; }
        void Switch();
        bool GetStatus();
    }
}
