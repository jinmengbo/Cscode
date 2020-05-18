using System;
using System.Collections.Generic;
using System.Text;

namespace ApiOne
{
    /*
      1. 首先我们先定义一个接口,下边写下两个方法,作为供方,别人都得按照我这个方法使用。
      2. 这是我们演示使用。
    */
    interface IFileCompression
    {
        //  我们定义两个方法,然后没有返回值,一个字符串,一个字符列表,下班是压缩的方法。
        void Compress(string targetFileName, string[] fileLIst);
        void UnCompress(string compressedFileName,string expandDirectoryName);

    }
    
}
