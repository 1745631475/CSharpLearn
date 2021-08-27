using System;

namespace _002_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数据类型和变量声明
            //值类型
            sbyte vluae1;short vluae2;int vluae3;long vluae4;
            byte vluae5;ushort vluae6;uint vluae7;ulong vluae8;
            char vluae9;float vluae10;double vluae11;decimal vluae12;
            bool vluae13;
            //引用类型
            string vluae14;
            object vluae15;
            dynamic vluae16;
            //以上类型不包含用户自定义类型和其他特殊类型
            //同类型变量可以连续声明
            int vluae17, vluae18, vluae19;
            #endregion

            #region 变量赋值
            //变量声明的时候就可以直接赋值
            int vluae20 = 20;
            //同类型的多变量赋值
            int vluae21 = 21, vluae22, vluae23 = 23;
            //赋值声明过的变量
            vluae3 = 24;
            #endregion

            #region 变量赋值范围
            //sbyte 127 -128
            //short 32767 -32768
            //int 2147483647 -2147483648
            //long 9223372036854775807 -9223372036854775808
            //byte 255 0
            //ushort 65535 0
            //uint 4294967295 0
            //ulong 18446744073709551615 0
            //char \uffff \0 表示为字符
            //float -3.40282347E+38F 3.40282347E+38F
            //double -1.7976931348623157E+308 1.7976931348623157E+308
            //decimal 79228162514264337593543950335M -79228162514264337593543950335M
            //bool true false
            //string 任意字符的组合（字符串）
            //object 所有类型的最终基类
            //dynamic 动态类型
            #endregion

            #region 常量声明
            //变量声明前加修饰符 const 修饰为常量
            //常量声明必须声明时就赋值
            //常量赋值后不可改变
            const int vluae24 = 15;
            #endregion

            #region 变量的本质
            //变量的本质是一块内存空间
            //内存空间存储数据
            //声明一个变量就是声明了一块内存空间
            //变量的类型觉得了这块内存空间的大小
            //使用sizeof可以获取基本值类型的内存空间大小,以字节为单位
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(bool));
            #endregion
        }
    }
}
