using System;

namespace RxNet
{
    interface IObserable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
    }

    interface IObserver<T>
    {
        //we have a value
        void OnNext(T value);

        //we have an error
        void OnError(Exception ex);

        //completion
        void OnCompleted();
    }
}
