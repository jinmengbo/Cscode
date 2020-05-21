using System;
using System.Collections.Generic;
using System.Text;

namespace GenEric
{
    public abstract class TreBase
    {
        public abstract string GetTreeName();
        public abstract int needEnergy();

    }
    public class SuosuoTree : TreBase
    {
        public override int needEnergy()
        {
            return 17900;
        }
        public override string GetTreeName()
        {
            return "金金树";
        }
    }
    public class NingTiaoTree : TreBase
    {
        //种植柠条需要的能量
        public override int needEnergy()
        {
            return 16930;
        }
        public override string GetTreeName()
        {
            return "柠条";
        }
    }

    public class ZhangZiSongTree : TreBase
    {
        //种植樟子松需要的能量
        public override int needEnergy()
        {
            return 146210;
        }
        public override string GetTreeName()
        {
            return "樟子松";
        }
    }
}
