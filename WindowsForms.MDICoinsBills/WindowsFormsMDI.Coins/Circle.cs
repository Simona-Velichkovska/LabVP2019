using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsMDI.Coins
{
    [Serializable()]
    public class Circle : ISerializable
    {
        public int NumCircles
        {
            get;
            private set;
        }
        public Circle(int n = 1)
        {
            if (n >= 0)
                NumCircles = n;
        }
        public void AddOne()
        {
            NumCircles++;
        }
        public void RemoveOne()
        {
            if(NumCircles>0)
                NumCircles--;
        }
        public Circle(SerializationInfo info, StreamingContext ctxt)
        {
            NumCircles = (int)info.GetValue("#Coins", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("#Coins", NumCircles);
        }
    }
}
