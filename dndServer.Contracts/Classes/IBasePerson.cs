using System;
using System.Collections.Generic;
using System.Text;

namespace dndServer.Contracts.Classes
{
    public interface IBasePerson
    {
        string Name { get; set; }
        void LevelUp();

    }
}
