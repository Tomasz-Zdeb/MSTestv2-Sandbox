using System;

namespace MyLibrary
{
    public class MyClass
    {
        public void MyMethod(bool throwsException)
        {
            if(throwsException)
            {
                throw new NotImplementedException("Method was instructed to throw excepton");
            }
        }
    }
}
