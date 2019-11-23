using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strDown = new StringBuilder("");
            StringMaster str = new StringMaster();

            

            Console.WriteLine("There is Hot News!");
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            strDown.Append(wc.DownloadString("http://www.film2serial.ir/"));
            

            List<string>Mohammad = str.GetAllTags(strDown.ToString(), "<div class=\"content\">", "</div>");
            
            strDown = new StringBuilder(Mohammad.Find(x => x == "آخرین مطلب"));
            Mohammad = str.GetAllTags(strDown.ToString(), "<Li>", "/Li");
            List<Movies> AllMoveis = new List<Movies>();
            for(int i =0; i <Mohammad.Count;i++)
            {

                Movies movies = new Movies();
                movies._MovieSite = " http://www.film2serial.ir/ ";
                movies._MovieName = str.GetStringBetween(Mohammad[i], "\">", "/a>");
                movies._MovieLink = str.GetStringBetween(Mohammad[i], "a href = \"", "\" >");
                AllMoveis.Add(movies);

                
            }

            for(int i = 0; i< AllMoveis.Count; i++ )
            {

                Console.WriteLine($"Movie Site : {AllMoveis[i]._MovieSite} \nMovie Name : {AllMoveis[i]._MovieName} \n Movie Link : { AllMoveis[i]._MovieLink}\n....................\n");
                
            }
           Console.ReadLine();
        }   
         

            //Console.WriteLine(strDown.ToString());
            

        }
    }

