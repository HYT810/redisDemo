using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //测试
            Console.WriteLine("使用redis存放数据");
            //RedisHelper.Add<string>("name", "hyt", DateTime.Now.AddDays(1));
            //RedisHelper.Add<string>("Age", "28", DateTime.Now.AddDays(1));
            Console.WriteLine(RedisHelper.Get<string>("name").ToString());
            Console.ReadKey();
        }
    }
}
