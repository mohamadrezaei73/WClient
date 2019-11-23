using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WClient
{
    class StringMaster
    {
        public string GetStringBetween(string token , string first , string second)
        {
            if (!token.Contains(first)) return "";

            var afterFirst = token.Split(new[] { first }, StringSplitOptions.None)[1];

            if (!afterFirst.Contains(second)) return "";

            var result = afterFirst.Split(new[] { second }, StringSplitOptions.None)[00];

            return result;


        }

        public List<string> GetAllTags(string token , string first , string second )
        {
            List<string> Alltg = new List<string>();
            while(true)
            {

                string flag = GetStringBetween(token, first, second);
                if (string.IsNullOrEmpty(flag))
                {
                    Alltg.Add(flag);
                    flag = first + flag + second;
                    token = token.Replace(flag, "");
                }
                else { break; }
                //salam
            }
            return Alltg;

        }


    }
}
