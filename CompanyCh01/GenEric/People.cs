using System;
using System.Collections.Generic;
using System.Text;

namespace GenEric
{
    class People
    {
        // 姓名
        public string name { get; set; }
        //能量
        public int energy { get; set; }
        // 能量作判断
        public void plant<T>(T tree) where T:TreBase
        {
            if (energy<tree.needEnergy())
            {
                Console.WriteLine("能量不够");

            }
            else{
                energy = energy - tree.needEnergy();
                    Console.WriteLine($"廾喜{name}");

                }
            }
        }
    }

