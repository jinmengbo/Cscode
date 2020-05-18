using System;
using System.Collections;

namespace ApiOne
{
    class Program
    {
        /**
         * 我们写接口的时候,需要捋清楚概念。
         * 1. 接口的产生：自底向上(重构)，自顶向下(设计)
         * 2. c#中接口的实现(隐式，显示，多接口)
         * 3. 我们可以简答理解为：接口就是有一个供方，有一个需求方，我们供方提供数据,我们需求方接受这些数据。
         * 4. 接口因为是一种协议，一种锲约， 好比一种合同，我们通过这个锲约，然后我们按照这个锲约进行访问，我们不会像供方多要，供方也不会多给我们,因为我们按照接口这个契约协议走的。
         * 5. 所以我们从上边的描述可以明白，像协议和锲约这种东西，他肯定就是一个公共，公开的，所以接口也就是一个，必须公开的协议，所以它默认就是public，公开。
         * 6. 我们从下边这些例子，得知，我们使用接口，会比我们写普通方法,更加的方便， 更加的减少我们重复的代码量。 
         **/

        // 我们通过下边计算的例子，来先了解一下。
        static void Main(string[] args)
        {
            //     // 1. 因为我们要去处理计算,所以我们肯定有供方,所以我在这里写下两个供方,因为是计算,所以我在下边定义的是数组。
            //     // 整形数组
            //     int[] nums1 = new int[] { 1, 2, 3, 4, 5 };
            //     // ArrayList实例
            //     ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            //     Console.WriteLine(Sum2(nums1));
            //     Console.WriteLine(Avg2(nums1));
            //     Console.WriteLine(Sum2(nums2));
            //     Console.WriteLine(Avg2(nums2));
            //
            //
            // }
            // // 2. 我们知道我们供方有两个后，我们在不使用接口的时候，处理上边的相加计算和求平均值计算,能猜出来我们需要定义四个方法,四个需求方。
            // // 求和计算
            // static int Sum(int[] nums)
            // {
            //     int sum = 0;
            //     foreach (var item in nums) sum += item;
            //     return sum;
            // }
            // // 平均值计算
            // static double Avg(int[] nums)
            // {
            //     int sum = 0; double count = 0;
            //     foreach (var itms in nums) { sum += itms; count++; }
            //     return sum / count;
            // }
            // // 3. 我们上边已经处理了一个供方,在去处理下一个供方,我们还得再写两个方法,但是我们看到我们第二个供方是ArrayList,所以我们也要方法也要改成ArrayList类型,但是foreach只能处理整数类型所以,我们还得转换成int类型。
            // // 求和计算.把类型更改为ArrayList
            // // 我们看一下
            // static int Sum1(ArrayList nums)
            // {
            //     int sum = 0;
            //     // 我们在这里用int，把ArrayList强制转换成int类型.
            //     foreach (var item in nums) sum += (int)item;
            //     return sum;
            // }
            // // 平均值计算,把类型更改为ArrayList
            // static double Avg1(ArrayList nums)
            // {
            //     int sum = 0; double count = 0;
            //     // 我们在这里用int，把ArrayList强制转换成int类型.
            //     foreach (var itms in nums) { sum += (int)itms; count++; }
            //     return sum / count;
            // }
            // // 4. 我们看出上方如果不使用接口，去进行处理发现是很麻烦的,我们知道int整型数组是Array,我们看看array和ArrayList是否有共同的接口协议,合同,我们下边写的方法,去继承他们共同的方法就行了。
            //     static int Sum2(IEnumerable nums)
            // {
            //     int sum = 0;
            //     foreach (var i in nums) sum += (int)i;
            //     return sum;
            // }
            // static double Avg2(IEnumerable nums)
            // {
            //     int sum = 0;double count = 0;
            //     foreach (var items in nums) { sum += (int)items;count++; }
            //     return sum / count;
            // }
            // 我们来实现我们的方法。我们是供方
            Contact[] contacts = new Contact[]
            {
                // 因为我们这个类性有四个必传项。
                new Contact(
                    "Dick", "Traci", "123 Main st..", "158-903"),
                new Contact(
                    "jin", "男性", "地址 河南 开封 通许", "888-31")
            };
            ConsoleListContol.List(Contact.Headers, contacts);
            Console.WriteLine();
            PubLication[] pubLications = new PubLication [2]
            {
                new PubLication(
                    "标题就是：金金写不动代码了",
                    "jinjin", 2020.5),
                new PubLication("标题", 
                    "金金", 2020.6),
            };
            ConsoleListContol.List(PubLication.Headers,pubLications);
        }
    }
    }
      
