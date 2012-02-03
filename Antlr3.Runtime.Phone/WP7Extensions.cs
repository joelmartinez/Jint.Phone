using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace System
{
    public class SerializableAttribute : Attribute
    {

    }

    public class NonSerializedAttribute : Attribute
    {
    }

    public interface ICloneable
    {
        // Methods
        object Clone();
    }


}

namespace System.Runtime.Serialization
{
    public class SerializationInfo
    {
        internal void AddValue(string p, object _elementDescription)
        {
            throw new NotImplementedException();
        }

        internal string GetString(string p)
        {
            throw new NotImplementedException();
        }

        internal int GetInt32(string p)
        {
            throw new NotImplementedException();
        }

        internal bool GetBoolean(string p)
        {
            throw new NotImplementedException();
        }

        internal object GetValue(string p, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
