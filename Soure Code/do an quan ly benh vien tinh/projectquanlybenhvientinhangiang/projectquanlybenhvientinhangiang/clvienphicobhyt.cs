using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projectquanlybenhvientinhangiang
{
    class clvienphicobhyt
    {
        public float tinhvienphi(float tienkham, float soluongthuoc, float dongiathuoc)
        { 
           
            return (((tienkham + (soluongthuoc * dongiathuoc))*50)/100);
        }
        public float tinhvienphi1(float tienkham, float soluongthuoc, float dongiathuoc)
        {

            return (tienkham + (soluongthuoc * dongiathuoc));
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
