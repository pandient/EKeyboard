using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TETCSharpClient;
using TETCSharpClient.Data;

namespace EyeTrackingKeyBoard
{
    class GazePoint :  IGazeListener
    {

        public static Double X = 0.0d;
        public static Double Y = 0.0d;


        public GazePoint()
        {
            // Connect client
            GazeManager.Instance.Activate(GazeManager.ApiVersion.VERSION_1_0, GazeManager.ClientMode.Push);

            // Register this class for events
            GazeManager.Instance.AddGazeListener(this);

           // Thread.Sleep(5000); // simulate app lifespan (e.g. OnClose/Exit event)

            // Disconnect client
            
        }

        public void OnGazeUpdate(GazeData gazeData)
        {
            double gX = gazeData.SmoothedCoordinates.X;
            double gY = gazeData.SmoothedCoordinates.Y;

            X = gX;
            Y = gY;
        }

        ~GazePoint()
        {
            GazeManager.Instance.Deactivate();
        }

    }
}
