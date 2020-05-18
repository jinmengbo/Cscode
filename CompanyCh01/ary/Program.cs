using System;

namespace ary
{
    class Program
    {
        static void Main(string[] args)
        {
        // 数组默认初始化
        //  int [] a=new int[1000];
        //  System.Console
        /* 
        2. 调用下边的结构体。
        */
        // Point point;
        // point.x=5;
        // point.y=6;
        // Point [] points=new Point[10];
      
        // int x=points[5].x;
        // System.Console.WriteLine(x);
        // System.Console.WriteLine(point.x);
        // }
        // 4. 调用下边引用类型
        // Point[] a=new Point[100];
        // for (int i=-0;i<a.Length;i++)
        //     a[i]=new Point();
           // 5. 多维数组,下的矩形数组。
    // 1).矩形数组声明时用逗号分隔每个维度。
    //         int [,] matrix= new int[3,3];
    // // 数组的GetLnegth方法返回维度的长度。
    //         for (int i=0;i<matrix.GetLength(0);i++)
    //         {
    //             for (int j=0;j<matrix.GetLength(1);j++)
                
    //             {
    //                 matrix[i,j]=i*3+j;
    //                 System.Console.Write(matrix[i,j]);
    //                 System.Console.WriteLine("\t");
    //             }
    //             // System.Console.WriteLine();
            
    //         }
            //    int [,] matrix=new int[,]
            //    {
            //        {0,1,2},
            //        {3,4,5},
            //        {6,7,8}
            //    };
            //    int val =matrix[1,2];
            //    System.Console.WriteLine(val);
            int [] [] a =new int [][]
            {
            new int[]{0,0},
            new int []{1,2},
            new int [] {6,7},
            new int [] {11,12}
            };
            int i, j;
          
            // 把上边定义的交叉数组进行输出
            
            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 2; j++)
                {
                    // System.Console.WriteLine("数组的输出[{0}][{1}]={2}",i,j,a[i][j]);
                    // System.Console.WriteLine("数组格式化输出{0}",i);
                    // System.Console.WriteLine("数组格式化输出{0}",j);
                    System.Console.WriteLine("数据格式化输出{0}{1}={2}总和",i,j,a[i][j]);
                }
                // System.Console.ReadKey();
            }
    }

    }

       /* c# 值类型和类引用
        1.  下边定义了值的结构体。
        */
        // public struct Point
        // {
        //     public int x,y;
        // }
    // 3.类的结构体
    //  public class Point
    //     {
    //         public int X,Y;
    //     }
}
