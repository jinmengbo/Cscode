namespace ApiOne
{
     interface IListable
    {
        // 定义方法,只有返回值,返货的还是列表
        string [] ColumnValues { get; }
    }
     // 开始定义抽象类,和方法
     public abstract class PdaItem
     {
         // 定义一个方法,需要传值。
         public PdaItem(string name)
         {
             // 别人调用PdaItem方法就需要传值,然后我们赋值给Nmae方法。
             Name = name;
         }
         public  virtual  string Name { get; set; }
     }
}