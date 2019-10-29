﻿namespace CalendarSkill.Models
{
    public class CreateEventStateModel
    {
        public enum RecreateEventState
        {
            /// <summary>
            /// Cancel the recreate
            /// </summary>
            Cancel = 0,

            /// <summary>
            /// Change the time and recreate.
            /// </summary>
            Time = 1,

            /// <summary>
            /// Change the duration and recreate.
            /// </summary>
            Duration = 2,

            /// <summary>
            /// Change the location and recreate.
            /// </summary>
            Location = 3,

            /// <summary>
            /// Change the participants and recreate.
            /// </summary>
            Participants = 4,

            /// <summary>
            /// Change the subject and recreate.
            /// </summary>
            Subject = 5,

            /// <summary>
            /// Change the content and recreate.
            /// </summary>
            Content = 6,

            /// <summary>
            /// Change the meeting room and recreate.
            /// </summary>
            MeetingRoom = 7
        }
    }
}
