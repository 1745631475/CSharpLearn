using System;

namespace _003_转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            // \a 响铃
            Console.WriteLine("\a");
            // \b 退格 将当前位置移到前一列
            Console.WriteLine("退格  \b\b测试");
            // \f 换页 将当前位置移到下页开头
            Console.WriteLine("换页\f  测试");
            // \n 换行 将当前位置移到下一行开头
            Console.WriteLine("换行\n测试");
            // \r 回车 将当前位置移到本行开头
            Console.WriteLine("    回车\r测试");
            // \t 水平制表 跳到下一个TAB位置
            Console.WriteLine("水平制\t表符测试");
            // \v 垂直制表
            Console.WriteLine("垂直制\v  表符测试");
            // \\ 代表一个反斜线字符''\'
            Console.WriteLine("反斜杠\\测试");
            // \' 代表一个单引号（撇号）字符
            Console.WriteLine("单引号\'测试");
            // \" 代表一个双引号字符
            Console.WriteLine("双引号\"测试");
            // \? 代表一个问号
            //Console.WriteLine("问号\?测试");//测试无法识别
            // \0 空字符(NUL)
            Console.WriteLine("空字符\0测试");
        }
    }
}
