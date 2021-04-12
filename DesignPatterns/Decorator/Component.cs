﻿namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    // The base Component interface defines operations that can be altered by
    // decorators.
    public abstract class Component
    {
        public abstract string Operation();
    }
}