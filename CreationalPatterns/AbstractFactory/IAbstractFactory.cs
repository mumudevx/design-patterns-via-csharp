﻿namespace CreationalPatterns.AbstractFactory;

public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}