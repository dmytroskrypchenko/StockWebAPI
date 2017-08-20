﻿namespace Stock.BL.Services.Concrete
{
    using System.Collections.Generic;
    using Abstract;
    using DAL.Infrastructure.Abstract;
    using Mapper.Abstract;


    public class BaseService<TEntity, TEntityDto> : IBaseService<TEntity, TEntityDto>
        where TEntityDto : class
        where TEntity : class
    {
        protected readonly IUnitOfWorkFactory _factory;

        public BaseService(IUnitOfWorkFactory factory, IMapper<TEntity, TEntityDto> mapper)
        {
            _factory = factory;
            mapper.Configure();
        }

        public void Delete(TEntityDto entity)
        {
            using (var uow = _factory.Create())
            {
                var entityToDelete = AutoMapper.Mapper.Map<TEntity>(entity);
                uow.Repository<TEntity>().Delete(entityToDelete);
                uow.Save();
            }
        }

        public void DeleteById(int id)
        {
            using (var uow = _factory.Create())
            {
                uow.Repository<TEntity>().DeleteById(id);
                uow.Save();
            }
        }

        public IEnumerable<TEntityDto> GetAll()
        {
            using (var uow = _factory.Create())
            {
                var entitiesDto = new List<TEntityDto>();
                var entities = uow.Repository<TEntity>().Get();
                foreach (var item in entities)
                {
                    var entityDto = AutoMapper.Mapper.Map<TEntityDto>(item);
                    entitiesDto.Add(entityDto);
                }

                return entitiesDto;
            }
        }

        public TEntityDto GetById(int id)
        {
            using (var uow = _factory.Create())
            {
                var entity = uow.Repository<TEntity>().GetById(id);
                var entityDto = AutoMapper.Mapper.Map<TEntityDto>(entity);
                return entityDto;
            }
        }

        public void Insert(TEntityDto entity)
        {
            using (var uow = _factory.Create())
            {
                var entityToInsert = AutoMapper.Mapper.Map<TEntity>(entity);
                uow.Repository<TEntity>().Insert(entityToInsert);
                uow.Save();
            }
        }

        public void Insert(IEnumerable<TEntityDto> entities)
        {
            using (var uow = _factory.Create())
            {
                foreach (var entity in entities)
                {
                    var entityToInsert = AutoMapper.Mapper.Map<TEntity>(entity);
                    uow.Repository<TEntity>().Insert(entityToInsert);
                }
                uow.Save();
            }
        }

        public void Update(TEntityDto entity)
        {
            using (var uow = _factory.Create())
            {
                var entityToUpdate = AutoMapper.Mapper.Map<TEntity>(entity);
                uow.Repository<TEntity>().Update(entityToUpdate);
                uow.Save();
            }
        }
    }
}
