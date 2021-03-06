﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization.Attributes;
using dashboard.Interfaces;
using dashboard.Model;

namespace dashboard.Controllers
{
    [Produces("application/json")]
    public class EntitiesController : Controller
    {
        public IEntityRepository _entityRepository;

        public EntitiesController(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }

        [HttpGet]
        [Route("api/entities")]
        public async Task<IEnumerable<Entity>> Get()
        {
            return await _entityRepository.GetEntities();
        }

        [HttpGet]
        [Route("api/entities/{id}")]
        public async Task<Entity> Get(string id)
        {
            return await _entityRepository.GetEntity(id);
        }

        [HttpPut]
        [Route("api/entity")]
        public async Task UpdateEntity([FromBody] EntityJsonPayload payload)
        {
            try
            {
                if (payload != null)
                {
                    Entity entity = await _entityRepository.GetEntity(payload.EntityId);
                    await _entityRepository.UpdateEntity(entity);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }

    public class EntityJsonPayload
    {
        [BsonId]
        public string InternalId { get; set; }
        public string EntityId { get; set; }
        public string EntityCategoryId { get; set; }
        public string EntityName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}