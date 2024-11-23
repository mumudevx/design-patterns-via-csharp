﻿namespace BehavioralPatterns.Strategy;

public interface IPaymentStrategy
{
    public void Pay(decimal amount);
}