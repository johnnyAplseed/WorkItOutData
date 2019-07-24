using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WorkItOut.Data.Models
{
    [DataContract]
    public class WorkoutModel
    {
        [DataMember]
        public int workoutID { get; set; }
        [DataMember]
        public string workoutName { get; set; }
        [DataMember]
        public string workoutCategory { get; set; }
        [DataMember]
        public int numberOfExercises { get; set; }
        [DataMember]
        public int exercisesGroupID { get; set; }
    }
}