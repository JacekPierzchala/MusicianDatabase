using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public abstract class ModelBase : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
