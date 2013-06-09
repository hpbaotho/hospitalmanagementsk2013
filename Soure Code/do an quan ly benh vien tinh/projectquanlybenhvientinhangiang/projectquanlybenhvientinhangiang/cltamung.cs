using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectquanlybenhvientinhangiang
{
    class cltamung
    {
        public float tinhtienhoanlai(float tientamung, float tienphaitra)
        {
            return (tientamung-tienphaitra);
        }
        public float chuyensangso(string str)
        {
            return float.Parse(str);
        }
        public string chuyensangchuoi(float so)
        {
            return Convert.ToString(so);
        }
    }
}
