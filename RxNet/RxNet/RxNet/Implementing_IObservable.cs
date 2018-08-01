using System;

namespace RxNet
{
    internal class Implementing_IObservable
    {
        private int v1;
        private int v2;

        public Implementing_IObservable(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal object Subscribe(MyObserver<int> observer)
        {
            throw new NotImplementedException();
        }
    }
}