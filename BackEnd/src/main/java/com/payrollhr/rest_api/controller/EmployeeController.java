package com.payrollhr.rest_api.controller;

import com.payrollhr.rest_api.data_repository.EmployeeRepository;
import com.payrollhr.rest_api.model.Employee;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.util.UriComponentsBuilder;

import java.util.List;

@RestController
@RequestMapping("/api/employee")
public class EmployeeController {

    @Autowired
    private EmployeeRepository repository;

    @GetMapping
    public ResponseEntity<List<Employee>> Gets()//
    {
        return new ResponseEntity<>(this.repository.findAll(), HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<Employee> Add(@RequestBody Employee employee, UriComponentsBuilder ucBuilder) //
    {
        //employee._id = UUID.randomUUID();
        return new ResponseEntity<>(employee, HttpStatus.ACCEPTED);
    }
}