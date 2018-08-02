package com.payrollhr.rest_api.model;

import com.payrollhr.rest_api.data_repository.ModelBase;
import org.springframework.data.mongodb.core.mapping.Document;

@Document(collection = "employee")
public class Employee extends ModelBase  //
{
    public String name;
}