﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dashboard.Model
{
    public class Entity
    {
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId internalId { get; set; }

        public string entityId { get; set; }

        public string entityCategoryId { get; set; }
        public string entityName { get; set; }
        public string contactName { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }
}
