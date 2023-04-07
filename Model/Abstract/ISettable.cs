using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    internal interface ISettable
    {
        int Value { get; set; }
        int FeedBack { get; set; }
        void SetValue(int value);
        
    }
}
