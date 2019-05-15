using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsMDI.Coins
{
    [Serializable]
    public class Triangle : ISerializable
    {
        public int NumTriangles
        {
            get;
            private set;
        }
        public Triangle(int n = 1)
        {
            if (n >= 0)
                NumTriangles = n;
        }
        public void AddBill()
        {
            NumTriangles++;
        }
        public void RemoveBill()
        {
            if (NumTriangles > 0)
                NumTriangles--;
        }
        public Triangle(SerializationInfo info, StreamingContext ctxt)
        {
            NumTriangles = (int)info.GetValue("#Bills", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("#Bills", NumTriangles);
        }
    }
}
