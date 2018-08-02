package com.payrollhr.rest_api.controller;

import com.payrollhr.rest_api.data_repository.EmployeeRepository;
import com.payrollhr.rest_api.model.Employee;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.util.UriComponentsBuilder;

import java.util.List;

@Controller
//@RestController
//@RequestMapping("/api")
public class EmployeeController {

    @Autowired
    private EmployeeRepository repository;

    @GetMapping("/employee")
    public ResponseEntity<List<Employee>> Gets()//
    {
        return new ResponseEntity<>(this.repository.findAll(), HttpStatus.OK);
    }

    @PostMapping("/employee")
    public ResponseEntity<Employee> Add(@RequestBody Employee employee, UriComponentsBuilder ucBuilder) //
    {
        //employee._id = UUID.randomUUID();
        return new ResponseEntity<>(employee, HttpStatus.ACCEPTED);
    }
}