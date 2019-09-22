namespace App.Builder
{
    interface IBuilder<T>
    {
        T build();
    }
}