﻿namespace EMo.Core
{
    /// <summary>
    /// This class is used to store data about an intercepted event
    /// </summary>
    public class RecordedEvent
    {
        /// <summary>
        /// Default constructor stores the parameters the event was raised with
        /// </summary>
        public RecordedEvent( params object[] parameters)
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Parameters for the event
        /// </summary>
        public object[] Parameters { get; private set; }

    }
}