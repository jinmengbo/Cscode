namespace ApiTwo
{
    // 我们先定义需求方的接口。
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Rest();
    }
}