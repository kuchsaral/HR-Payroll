package com.payrollhr.rest_api.data_repository;

import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.repository.NoRepositoryBean;

import java.util.UUID;

@NoRepositoryBean
public interface RepositoryBase<T extends ModelBase> extends MongoRepository<T, UUID> //
{

}
