package com.payrollhr.rest_api.model;

import com.payrollhr.rest_api.CUST.Adult;
import com.payrollhr.rest_api.data_repository.ModelBase;
import org.springframework.data.mongodb.core.mapping.Document;

import javax.validation.constraints.NotNull;
import java.time.LocalDate;

@Document(collection = "student")

public class Student extends ModelBase  //
{
    public String name;
    public String test;

    @NotNull(message = "User Name is compulsory")
    public String user_name;

    @Adult(message = "{user.dateOfBirth.adult}")
    public LocalDate kl;
}