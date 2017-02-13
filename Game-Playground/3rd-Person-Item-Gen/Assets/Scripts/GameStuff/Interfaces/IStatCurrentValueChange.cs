using System;

namespace GameStuff.Interfaces
{
    // Used to indicate when the stat's current value changes

    public interface IStatCurrentValueChange
    {
        event EventHandler OnCurrentValueChange;
    }
}