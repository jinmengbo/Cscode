namespace ApiTwo
{
    /*
     * 1. 我们用Countdown这个类继承了我们IEnumerator这个接口，
     * 2. 我们定义了一个int类型的count给他赋了值，等于，count为11。
     * 3. 然后我们在接口定义的字段，进行了自减,到自减到0时,停止下来。
     * 4. 然后我们定义的Current字段取到的值就是,我们上个MoveNext字段进行自减后的，
     * 5. 我们最后定义了一个,Rest异常，它的意思就是，当我们调用的方法不支持,或者尝试着读取搜索写入,不支持的调用功能的时候，抛出异常。
     */

    internal  class Countdown: IEnumerator
    {
        private int count = 11;
        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset()
        {
            throw new System.NotSupportedException();
        }
    }
}