namespace App.Builder
{
    abstract class Builder<T> : IBuilder<T>
    {
        public abstract T build();
        public abstract T build<A1>(A1 arg1);
        public abstract T build<A1, A2>(A1 arg1, A2 arg2);
    }
}