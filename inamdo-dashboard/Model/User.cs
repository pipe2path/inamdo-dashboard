﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dashboard.Model
{
    public class User
    {
        [BsonId]
        public ObjectId internalId { get; set; }

        public int surveyId { get; set; }
        public string userName { get; set; }
        public string userPhone { get; set; }
        public string userEmail { get; set; }
        public bool optIn { get; set; }
    }
}
