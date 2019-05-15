using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace VPLab9i10
{
    [Serializable()]
    public class RedCircles :ISerializable
    {
        private IUpdatableView frmView;
        public int NumCircles { get; set; }

        public RedCircles(IUpdatableView view,int n = 1)
        {
            frmView = view;
            if (n >= 0)
                NumCircles = n;
        }
        public void AddCircle()
        {
            NumCircles++;
            frmView.UpdateView();
        }
        public void RemoveCircle()
        {
            frmView.UpdateView();
            if (NumCircles > 0)
                NumCircles--;
        }
        public RedCircles(SerializationInfo info, StreamingContext ctxt)
        {
            NumCircles = (int)info.GetValue("#RedCircles", typeof(int));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("#RedCircles", NumCircles);
        }
    }
}
