﻿namespace PayrollBureau.Data.Interfaces
{
    public interface IDatabaseFactory<T>
    {
        T CreateContext();
    }
}
