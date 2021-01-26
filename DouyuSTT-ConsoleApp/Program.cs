using Douyu.STT;
using System;

namespace DouyuSTT_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string message = "type@=loginres/userid@=0/roomgroup@=0/pg@=0/sessionid@=0/username@=/nickname@=/live_stat@=0/is_illegal@=0/ill_ct@=/ill_ts@=0/now@=0/ps@=0/es@=0/it@=0/its@=0/npv@=0/best_dlev@=0/cur_lev@=0/nrc@=1740613392/ih@=0/sid@=70714/sahf@=0/sceneid@=0/newrg@=0/regts@=0/ip@=1.1.1.1/";
            STT data = new STT(message);
            Console.WriteLine($"消息类型: {data.Get("type")}");
        }
    }
}
