using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHW2
{
    public interface ISherPref
    {
        void setData(string key, string pass);
        string getData(string key);
    }
}
