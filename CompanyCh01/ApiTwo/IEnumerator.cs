namespace ApiTwo
{
    /*
     * 1. 定义一个隐式接口，定义下边公共的三个方法。
     * 2. 定义了一个bool值类型的字段，
     * 3. 定义了一个object拥有所有的类的字段，后边get的定义就是,谁是用到我们这个Current的字段，传入的值都是会return返回回去
     * 4. 一个需要有返回值的字段。
     * 5. 我们在定义一个类，来继承我们接口 。接口就是我们的需求方，我们继承了它，就要按照她这个合约来走，契约精神。
     */
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();

    }
}