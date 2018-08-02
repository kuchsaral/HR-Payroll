package com.payrollhr.rest_api.data_repository;

import org.springframework.data.annotation.Id;

import java.util.UUID;

public abstract class ModelBase  //
{
    @Id
    private UUID _id;

    public void set_id() {
        this._id = UUID.randomUUID();
    }

    public void set_id(String idText) {
        this._id = UUID.fromString(idText);
    }

    public UUID get_ID() {
        return this._id;
    }
}
