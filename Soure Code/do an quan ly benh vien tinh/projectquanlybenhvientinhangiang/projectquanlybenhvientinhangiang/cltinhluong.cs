using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectquanlybenhvientinhangiang
{
    class cltinhluong
    {
        public float tinhluong(float mucluong, float hesoluong, float phucap, float ngaylam, float ngaythang)
        {
            float tienluong=(mucluong*hesoluong)+phucap;
            float ngaynghi = ngaythang - ngaylam;
            float luongmotngay=tienluong/ngaythang;
            return (tienluong - (luongmotngay * ngaynghi));
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
